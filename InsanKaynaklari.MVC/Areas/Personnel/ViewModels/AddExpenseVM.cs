using InsanKaynaklari.Domain.Enums;
using InsanKaynaklari.MVC.CustomeValidations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace InsanKaynaklari.MVC.Areas.Personnel.ViewModels
{
    public class AddExpenseVM
    {
        public AddExpenseVM()
        {
            ExpenseTypes = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Accomodation", Value = ExpenseType.Accomodation.ToString()},
                    new SelectListItem {Text = "Transport", Value = ExpenseType.Transport.ToString()},
                    new SelectListItem {Text = "Food", Value = ExpenseType.Food.ToString()}
                };
            Currencies = new List<SelectListItem>()
            {
                new SelectListItem {Text = "₺", Value = Currency.TL.ToString()},
                    new SelectListItem {Text = "$", Value = Currency.USD.ToString()},
                    new SelectListItem {Text = "€", Value = Currency.EUR.ToString()}
            };
        }
        public ExpenseType ExpenseType { get; set; }
        public List<SelectListItem>? ExpenseTypes { get; set; }
        [Required(ErrorMessage = "Amount cannot be left blank.")]
        public string ExpenseAmount { get; set; } = null!;
        public Currency Currency { get; set; }
        public List<SelectListItem>? Currencies { get; set; }

        [Required(ErrorMessage = "Attachment cannot be left blank")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png", ".pdf" }, ErrorMessage = "Please upload a file in JPEG, JPG, PNG or PDF format.")]
        public IFormFile? NewPicturePath { get; set; }
    }
}
