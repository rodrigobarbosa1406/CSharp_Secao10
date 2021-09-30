using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao10.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public sealed override string PriceTag()
        {
            return base.Name
                + $" (used) $ {base.Price.ToString("F2", CultureInfo.InvariantCulture)}"
                + $" (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
