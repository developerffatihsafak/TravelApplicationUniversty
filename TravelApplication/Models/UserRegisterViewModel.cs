using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelApplication.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Adınızı ve Soyadınızı ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mail adresini giriniz ")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Telefon Numarasını giriniz giriniz")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Şifre giriniz giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrarı  giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil.")]
        public string ConfirmPassword { get; set; }
    }
}
