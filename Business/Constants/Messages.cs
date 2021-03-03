using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //public ler büyük harfle yazılır
        public const string ProductAdded = "Ürün eklendi";
        public const string ProductNameInvalid = "Ürün ismi geçersiz";
        public const string MaintenanceTime = "Sistem kapalı";
        public const string ProductsListed = "Ürünler listelendi";
        public const string ProductCountError = "Bir kategoride en fazla 10 ürün olabilir";
        public const string CategoryLimitExceded = "Kategori limiti 15 i aştığı için ürün eklenemiyor";
        public const string AuthorizationDenied = "Yetkiniz yok";
        public const string UserRegistered = "Kayıt olundu";
        public const string UserNotFound = "Kullanıcı bulunamadı";
        public const string PasswordError = "Parola hatası";
        public const string SuccessfulLogin = "Başarılı giriş";
        public const string UserAlreadyExists = "Kullanıcı mevcut";
        public const string AccessTokenCreated = "Token oluşturuldu";
        public const string ProductUpdated = "Ürün güncellendi";
    }
}

