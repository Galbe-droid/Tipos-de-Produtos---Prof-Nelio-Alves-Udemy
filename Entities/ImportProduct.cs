using System;
using System.Collections.Generic;
using System.Text;

namespace ProductType.Entities
{
    class ImportProduct : Product
    {
        public double CustomFees { get; private set; }

        public ImportProduct()
        {

        }

        public ImportProduct(string name, double price, double fee) : base (name, price)
        {
            CustomFees = fee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + "\nFee: " + CustomFees;
        }
    }
}
