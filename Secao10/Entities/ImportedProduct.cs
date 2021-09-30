using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao10.Entities
{
    sealed class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return base.Price + CustomsFee;
        }

        public sealed override string PriceTag()
        {
            return  base.Name
                + $" $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}"
                + $" (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
