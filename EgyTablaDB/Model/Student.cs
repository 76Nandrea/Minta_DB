using Org.BouncyCastle.Asn1.X509;
using System.ComponentModel.DataAnnotations;

namespace EgyTablaDB.Model
{
    public class Student
    {
        [RegularExpression(@"^.{12,12}$")]
        [Required]
        public long StudentID { get; set; }

        
        [RegularExpression(@"^\d{12}$", ErrorMessage = "12 számjegy lehet csak")]
        [MaxLength(12)]
        public string? StudentID2 { get; set; }

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
