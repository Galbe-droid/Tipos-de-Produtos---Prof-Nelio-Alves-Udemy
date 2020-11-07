using System;
using System.Collections.Generic;
using System.Text;

namespace ProductType.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureTime { get; private set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            ManufactureTime = date;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + "\nManufacture Date: " + ManufactureTime.ToString("dd/MM/yyyy");
        }
    }
}
