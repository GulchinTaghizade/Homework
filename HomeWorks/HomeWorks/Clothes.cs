using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Clothes
    {
        public string Brand;
        public string Size;
        public string Color;
        public string Material;
        public int Price;

        public Clothes()
        {

        }
        public Clothes(string brand,string size,string color, string material, int price)
        {
            Brand = brand;
            Size = size;
            Color = color;
            Material = material;
            Price = price;
        }
    }
}
