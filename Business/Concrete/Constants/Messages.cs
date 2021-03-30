using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Concrete.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Ürün eklendi.";
        public static string BrandAdded = "Brand eklendi.";
        public static string ColorAdded = "Color eklendi.";
        public static string CarDeleted = "Ürün silindi";
        public static string BrandDeleted = "Brand silindi";
        public static string ColorDeleted = "Color silindi";
        public static string CarUpdate = "Ürün güncellendi";
        public static string BrandUpdate = "Brand güncellendi";
        public static string ColorUpdate = "Color güncellendi";
        public static string CarNameInvalid = "Araba ismi min 2 karakter olmalıdır.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Ürünler listelendi";
        public static string BrandsListed = "Markalar listelendi";
        public static string ColorsListed = "Renkler listelendi";
        public static string CarDailyPriceInvalid = "Araba ücreti 0 dan büyük bir sayı olmalıdır.";
        public static string BrandNameInvalid = "Marka ismi min 2 karakter olmalıdır.";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string RentalAdded = "Kiralama oluşturuldu";
        public static string RentalUpdate = "Kiralama güncellendi";
        public static string RentalDeleted = "Kiralama silindi";


        public static string RentalInvalid = "Araba teslim edilmediği için kiralanamaz";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string CustomerUpdate = "Müşter güncellendi";
        public static string UserAdded = "Kullanıcı Eklendi.";
        public static string UserNameInValid = "Kullanıcı ismi geçersiz.";
        public static string UserMaintenenceTime = "Sistem bakımda olduğundan işleminize devam edilemiyor.";
        public static string UserListed = "Kullanıcılar Listelendi. ";
        public static string UserUpdated = "Kullanıcı bilgileri veritabanında güncellendi. ";
        public static string AuthorizationDenied = "Yetkiniz Yok.";
        internal static string UserRegistered = "Kayıt oldu";

       
        public static string UserNotFound = "Kayıt bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string UserAlreadyExists = "Kullanıcı zaten var.";
        public static string AccessTokenCreated = "Token oluşturuldu";

        public static string ErrorGetByUserMail = "Sistemde Bu Kullanıcıya Ait Mail Adresi Bulunamamaktadır.";
        public static string SuccessGetByUserMail = "Kullanıcının Mail Adresi Başarıyla Sorgulandı.";
    }
}
