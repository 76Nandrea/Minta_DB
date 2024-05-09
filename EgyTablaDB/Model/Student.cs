using Org.BouncyCastle.Asn1.X509;
using System.ComponentModel.DataAnnotations;

namespace EgyTablaDB.Model
{
    public class Student
    {
        [MinLength(12)]
        [MaxLength(12)]
        [Required]
        public Int64 StudentID { get; set; }

        [Required]
        [MaxLength(50)]
        public string? FName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? LName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? MotherFName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? MotherLName { get; set; }

        [Required]
        public string? BirthPlace { get; set; }

        [Required]
        [MaxLength(50)]
        public DateTime BirthDay { get; set; }

        [Required]
        [MaxLength(50)]
        public string? City { get; set; }

        public string GetFullname()
        {
            return $"{FName} {LName}";
        }

        public string GetFullname2()
        {
            return $"{MotherFName} {MotherLName}";
        }
    }
}
