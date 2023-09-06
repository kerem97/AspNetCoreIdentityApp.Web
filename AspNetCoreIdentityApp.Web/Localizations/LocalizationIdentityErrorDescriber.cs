using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentityApp.Web.Localizations
{
    public class LocalizationIdentityErrorDescriber : IdentityErrorDescriber
    {

        public override IdentityError DuplicateUserName(string userName)
        {
            //return base.DuplicateUserName(userName);

            return new() { Code = "DuplicateUserName", Description = $" {userName} kullanılmaktadır" };


        }

        public override IdentityError DuplicateEmail(string email)
        {
            //return base.DuplicateEmail(email);
            return new() { Code = "DuplicateEmail", Description = $" {email} kullanılmaktadır" };
        }

        public override IdentityError PasswordTooShort(int length)
        {
            //return base.PasswordTooShort(length);

            return new() { Code = "PasswordTooShort", Description = $"Şifre en az 6 karakter olmalıdır" };

        }
    }
}
