using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = " Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError="Kategorideki ürün sayısını aştınız! ";
        public static string ProductnameAlreadyExists="Bu ürün isminden zaten var";
        public static string CheckIfCategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string  AuthorizationDenied="Yetkiniz yok.";
    }
}
