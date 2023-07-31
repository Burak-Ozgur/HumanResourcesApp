using InsanKaynaklari.MVC.CustomeValidations;
using System.ComponentModel.DataAnnotations;

namespace InsanKaynaklari.MVC.Areas.CompanyManager.ViewModels
{
    public class EditPageVM
    {

        public string? PicturePath { get; set; }
        [Required(ErrorMessage = "Address cannot be left blank.")]
        public string Address { get; set; } = null!;
        [RegularExpression(@"^(05\d{9})$", ErrorMessage = "Please enter a valid phone number.")]
        public string PhoneNumber { get; set; } = null!;

        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" }, ErrorMessage = "Please upload a file in JPEG, JPG or PNG format.")]
        public IFormFile? NewPicturePath { get; set; }
    }
}
