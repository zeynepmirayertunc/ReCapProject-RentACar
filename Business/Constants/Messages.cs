﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Yeni Araba eklendi!";

        public static string InvalidTransaction = "Hatalı işlem!!! Lütfen işlem şartlarını dikkate alarak işleminizi kontor ediniz";
        public static string CarsListed = "Arabalar listelendi";
        public static string MaintenanceTime = "Üzgünüm Sistem şu anda bakımda!!!";
        public static string ReturnDateError = "Araba henüz teslim edilmemiş bu araba kiralanamaz!!!";
        public static string RentalAdded = "Teebrikler araba kiralandı";
        public static string RentalUpdated = "Kiralama işlemi güncellendi";
        public static string RentalsListed = "Kiralama bilgileri listelendi";
        public static string RentalDeleted = "Kiralama işlemi silindi";
        public static string CarsUpdated = "Araba bilgileri güncellendi";
        public static string CarsDeleted = "Araba silindi";
        public static string UserAdded = "Yeni kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı bilgileri silindi";
        public static string UserUpdated = "Kullanıcı bilgileri güncellendi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string CustomerAdded = "Tebrikler!!! Yeni müşteri eklendi";
        public static string CustomerDeleted = "Müşteri bilgileri silindi";
        public static string CustomerUpdated = "Müşteri bilgileri güncellendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string ColorAdded = "Yeni renk eklendi";
        public static string ColorDeleted = "Mevcut renk silindi";
        public static string ColorUpdated = "Mevcut renk bilgisi güncellendi";
        public static string ColorsListed = "Mevcut araba renkleri listelendi";
        public static string BrandAdded = "Yeni marka eklendi";
        public static string BrandDeleted = "Mevcut marka silindi";
        public static string BrandUpdated = "Mevcut marka bilgisi güncellendi";
        public static string BrandsListed = "Mevcut araba markaları listelendi";
        public static string DailyPriceInvalid = "Uyarı!!!. Arabanın günlük fiyatı 0 dan büyük olmalıdır";
        public static string CarNameInvalid = "Uyarı!!! Arabanın ismi minimum 2 karekter olmalıdır";
        public static string CarImageCountError = "Uyarı!!! Bir araba için maksimum 5 resim yüklenebilir.";
        public static string CarImagesAdded = "Araba fotoğrafı eklendi";
        public static string CarImagesListed = "Araba fotoğrafları listelendi";
        public static string CarImagesUpdated = "Araba fotoğrafları güncellendi";
        public static string CarImageDeleted = "Araba fotoğrafı silindi";
        public static string CarImagesNotFound = "Araba resmi sistemde bulunmamaktadır";
        public static string AuthorizationDenied = "Yetkilendirme Reddedildi";
        public static string UserRegistered = " Kayıt oldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola Hatası";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı kayıtlı";
        public static string AccessTokenCreated= "Access Token Oluşturuldu";
    }
}
