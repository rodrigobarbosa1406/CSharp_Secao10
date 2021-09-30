using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao10.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.0;

            if (base.AnualIncome < 20000.00)
            {
                tax = 0.15;
            } 
            else
            {
                tax = 0.25;
            }

            return (base.AnualIncome * tax) - (HealthExpenditures * 0.5);
        }
    }
}
