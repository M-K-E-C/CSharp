using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_NESNE_YÖNELİMLİ_PROGRAMLARI_
{
    class Product
    {
        public int Id { get; set; } // id

        public int CategoryId { get; set; }// kategori id

        public string ProductName { get; set; } // ürün ismi

        public double UnitPrice { get; set; }//ürün fiyatı

        public int UnitInStock { get; set; } //stok adedi


    }
}
