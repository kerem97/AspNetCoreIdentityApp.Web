using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class SignUpViewModel
    {
        public SignUpViewModel()
        {

        }
        public SignUpViewModel(string userName, string email, string phone, string password)
        {
            UserName = userName;
            Email = email;
            Phone = phone;
            Password = password;
        }

        
        [Required(ErrorMessage = "Kullanıcı Adı Boş Bırakılamaz")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mail Alanı Boş Bırakılamaz")]
        [EmailAddress(ErrorMessage = "Mail Formatı Hatalıdır")]
        public string Email { get; set; }

        
        [Required(ErrorMessage = "Telefon Alanı Boş Bırakılamaz")]
        [Display(Name = "Telefon Numarası")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Şifre Boş Bırakılamaz")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Şifreler Uyuşmuyor")]  
        [Required(ErrorMessage = "Şifre Onayı Boş Bırakılamaz")]
        [Display(Name = "Şifre Tekrar")]
        public string PasswordConfirm { get; set; }

    }
}
