using csv_seed_data.Data.Entities;
using ExternalSystems.FileStorage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;

namespace csv_seed_data.Data
{
    public class DataContext : DbContext
    {
        private readonly IFileStorageSystem _fileStorageSystem;

        public DataContext(DbContextOptions<DataContext> options, IFileStorageSystem fileStorageSystem) : base(options)
        {
            _fileStorageSystem = fileStorageSystem;
        }

        public DbSet<Icd10Blob> Icd10Blob { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var icd10SeedData = SeedIcd10Blob();

            modelBuilder
                .Entity<Icd10Blob>()
                .HasData
                (
                    icd10SeedData
                );
        }

        private List<Icd10Blob> SeedIcd10Blob()
        {
            var icd10Data = new List<Icd10Blob>();
            var csvData = _fileStorageSystem.ReadFileAsync("test.csv");

            using (var reader = new StreamReader(csvData.Result.Stream))
            {
                var isHeader = true;
                var lineNumber = 0;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    if (isHeader)
                    {
                        isHeader = false;
                        lineNumber++;
                        continue;
                    }

                    var values = line.Split(',');

                    if (values.Length < 24) continue;

                    icd10Data.Add(new Icd10Blob
                    {
                        Id = Guid.NewGuid().ToString(),
                        Number = Convert.ToInt32(values[0]),
                        Chapter = values[1],
                        ChapterDescription = values[2],
                        GroupCode = values[3],
                        GroupDescription = values[4],
                        Icd103Code = values[5],
                        Icd103CodeDescription = values[6],
                        Icd10Code = values[7],
                        WhoFullDescription = values[8],
                        ValidIcd10ClinicalUse = values[9],
                        ValidIcd10Primary = values[10],
                        ValidIcd10Asterix = values[11],
                        ValidIcd10Dagger = values[12],
                        ValidIcd10Sequelae = values[13],
                        AgeRange = values[14],
                        Gender = values[15],
                        Status = values[16],
                        WhoStartDate = values[17],
                        WhoEndDate = values[18],
                        WhoRevisionHistory = values[19],
                        SaStartDate = values[20],
                        SaEndDate = values[21],
                        SaRevisionHistory = values[22],
                        Comment = values[23]
                    });

                    lineNumber++;
                }
            }

            return icd10Data;
        }
    }
}
