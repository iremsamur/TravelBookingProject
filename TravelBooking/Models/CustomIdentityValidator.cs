using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TravelBooking.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber //Bu sınıf
        //ingilizce gelen validasyon mesajlarına müdahale edip değiştirebilmemizi,
        //türkçeye çevirmemizi sağlar.
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",//validasyonun kodu adı yazılır.
                Description = $"Parola minimum {length} karakter olmalıdır."//o validasyonu sağlamazsa yeni yazacağımız açıklama



            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",//validasyonun kodu adı yazılır.
                Description = $"Parola en az 1 büyük harf içermelidir."//o validasyonu sağlamazsa yeni yazacağımız açıklama



            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",//validasyonun kodu adı yazılır.
                Description = $"Parola en az 1 küçük harf içermelidir."//o validasyonu sağlamazsa yeni yazacağımız açıklama



            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",//validasyonun kodu adı yazılır.
                Description = $"Parola en az 1 sembol içermelidir."//o validasyonu sağlamazsa yeni yazacağımız açıklama



            };
        }
    }
}
