using System.ComponentModel.DataAnnotations;

namespace csv_seed_data.Data.Entities
{
    public class Icd10Blob
    {
        [Key]
        public string Id { get; set; }
        public int? Number { get; set; }
        public string Chapter { get; set; }
        public string ChapterDescription { get; set; }
        public string GroupCode { get; set; }
        public string GroupDescription { get; set; }
        public string Icd103Code { get; set; }
        public string Icd103CodeDescription { get; set; }
        public string Icd10Code { get; set; }
        public string WhoFullDescription { get; set; }
        public string ValidIcd10ClinicalUse { get; set; }
        public string ValidIcd10Primary { get; set; }
        public string ValidIcd10Asterix { get; set; }
        public string ValidIcd10Dagger { get; set; }
        public string ValidIcd10Sequelae { get; set; }
        public string AgeRange { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string WhoStartDate { get; set; }
        public string WhoEndDate { get; set; }
        public string WhoRevisionHistory { get; set; }
        public string SaStartDate { get; set; }
        public string SaEndDate { get; set; }
        public string SaRevisionHistory { get; set; }
        public string Comment { get; set; }
    }
}
