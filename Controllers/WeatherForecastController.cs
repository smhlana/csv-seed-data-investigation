using ExcelSeedData.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelSeedData.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var icd10Data = SeedIcd10();

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        private List<Icd10> SeedIcd10()
        {
            var icd10Data = new List<Icd10>();
            using (var reader = new StreamReader(@"C:\Users\smhla\OneDrive\Documents\Market MX\Import and store list of ICD10 codes in database\test.csv"))
            {
                var lineNumber = 0;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    if (lineNumber == 0)
                    {
                        lineNumber++;
                        continue;
                    }
                    
                    var values = line.Split(',');

                    if (values.Length != 24) continue;

                    var Number = Convert.ToInt32(values[0]);
                    var Chapter = values[1];
                    var ChapterDescription = values[2];
                    var GroupCode = values[3];
                    var GroupDescription = values[4];
                    var Icd103Code = values[5];
                    var Icd103CodeDescription = values[6];
                    var Icd10Code = values[7];
                    var WhoFullDescription = values[8];
                    var ValidIcd10ClinicalUse = values[9];
                    var ValidIcd10Primary = values[10];
                    var ValidIcd10Asterix = values[11];
                    var ValidIcd10Dagger = values[12];
                    var ValidIcd10Sequelae = values[13];
                    var AgeRange = values[14];
                    var Gender = values[15];
                    var Status = values[16];
                    var WhoStartDate = values[17];
                    var WhoEndDate = values[18];
                    var WhoRevisionHistory = values[19];
                    var SaStartDate = values[20];
                    var SaEndDate = values[21];
                    var SaRevisionHistory = values[22];
                    var Comment = values[23];

                    icd10Data.Add(new Icd10
                    {
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
                        ValidIcd10Dagger =  values[12],
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
                }
            }

            return icd10Data;
        }
    }
}
