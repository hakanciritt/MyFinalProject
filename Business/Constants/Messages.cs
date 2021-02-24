using System;
using System.Collections.Generic;
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
    }
}
