using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Display(Name = "ID Pracownika")]
        [Range(100000, 999999, ErrorMessage = "Wartość poza zakresem.")]
        public int EmplyeeId { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Musisz podać swoje imię.")]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Musisz podać swoje nazwisko.")]
        public string LastName { get; set; }

        [Display(Name = "Adres e-mail")]
        [Required(ErrorMessage = "Musisz podać swój adres e-mail.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Zły format adresu e-mail.")]
        public string EmailAdress { get; set; }

        [Display(Name = "Powtórz adres e-mail")]
        [Compare("EmailAdress", ErrorMessage = "Adres e-mail różni się.")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Hasło")]
        [Required(ErrorMessage = "Musisz podać swoje hasło")]
        [DataType(DataType.Password)]
        [StringLength(25, MinimumLength = 8, ErrorMessage = "Hasło musi posiadać conajmniej 8 znaków.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Powtórz hasło")]
        [Compare("Password", ErrorMessage = "Hasła różnią się.")]
        public string ConfirmPassword { get; set; }
    }
}