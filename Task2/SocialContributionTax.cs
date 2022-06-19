using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class SocialContributionTax : ISocialContributionTax
    {
        public double Apply(double amount, double nonTaxableAmount)
        {
            double amountToBeTaxed = amount - nonTaxableAmount;
            if (amount - nonTaxableAmount <= 3000)
            {

                double salaryAfterTax = nonTaxableAmount + amountToBeTaxed * 0.85;
                return salaryAfterTax;
            }
            else
            {
                double amountAboveMaximumSocContAmount = amount - nonTaxableAmount - 3000;
                double taxAmountForSocCont = 3000 * 0.85;
                double salaryAfterTax = amountAboveMaximumSocContAmount + nonTaxableAmount + taxAmountForSocCont;
                return salaryAfterTax;
            }
        }
    }
}
