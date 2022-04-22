using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductListed = "Ürünler listelendi";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string UnitPriceInvalid = "Ürün fiyatı geçersiz";
        public static string ProductCountOfCategoryError = "Bir ketogoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Aynı isimli zaten başka bir ürün var";
        public static string CategoryLimitExceeded = "Kategori sayısı limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";

    }
}
