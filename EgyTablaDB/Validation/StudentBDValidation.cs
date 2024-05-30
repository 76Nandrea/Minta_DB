using System.ComponentModel.DataAnnotations;

namespace EgyTablaDB.Validation
{
    public class StudentBDValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime date)
            {
                if (date > DateTime.Today)
                {
                    return new ValidationResult("A születési dátum nem lehet későbbi mint a mai nap!");

                }
            }

            return ValidationResult.Success!;
        }
    }
}
