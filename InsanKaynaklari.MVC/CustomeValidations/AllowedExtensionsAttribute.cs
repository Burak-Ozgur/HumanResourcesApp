﻿using System.ComponentModel.DataAnnotations;

namespace InsanKaynaklari.MVC.CustomeValidations
{
    public class AllowedExtensionsAttribute : ValidationAttribute
    {
        private readonly string[] _extensions;

        public AllowedExtensionsAttribute(string[] extensions)
        {
            _extensions = extensions;
        }



        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return ValidationResult.Success;



            var file = value as IFormFile;
            var fileExtension = Path.GetExtension(file.FileName).ToLower();



            if (!_extensions.Contains(fileExtension))
                return new ValidationResult(GetErrorMessage());



            return ValidationResult.Success;
        }



        public string GetErrorMessage()
        {
            return $"Invalid file type. Supported file types: {string.Join(", ", _extensions)}";
        }
    }
}
