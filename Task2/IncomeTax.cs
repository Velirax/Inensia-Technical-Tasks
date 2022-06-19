using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class IncomeTax : IIncomeTax
    {
        public double Apply(double amount, double nonTaxableAmount)
        {
            double amountToBeTaxed = amount - nonTaxableAmount;
            double salaryAfterTax = amountToBeTaxed * 0.9 + nonTaxableAmount;

            return salaryAfterTax;
        }

    }
}
