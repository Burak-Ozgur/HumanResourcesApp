using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklari.Domain.Validations
{
    public class NumericStringAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string numericString && decimal.TryParse(numericString, out decimal result) && result >= 0)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage ?? "ExpenseAmount must be a valid non-negative numeric value.");
        }
    }
}
