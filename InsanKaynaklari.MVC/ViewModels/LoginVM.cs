using System.ComponentModel.DataAnnotations;

namespace InsanKaynaklari.MVC.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "This section cannot be left blank.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "This section cannot be left blank.")]
        public string Password { get; set; }
    }
}
