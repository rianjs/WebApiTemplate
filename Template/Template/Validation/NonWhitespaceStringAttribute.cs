using System.ComponentModel.DataAnnotations;

namespace Template.Validation
{
    public class NonWhitespaceStringAttribute :
        ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext ctx)
        {
            var str = value as string;
            return string.IsNullOrWhiteSpace(str)
                ? new ValidationResult("Value must not be null, empty, or whitespace")
                : ValidationResult.Success;
        }
    }
}