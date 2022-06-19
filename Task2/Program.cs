using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double grossSalary = 0;
            do
            {
                var input = Console.ReadLine();
                double.TryParse(input, out grossSalary);
            } while (grossSalary <= 0);

            
            var taxesMethods = new List<TaxEnum>() {TaxEnum.Income,TaxEnum.SocialContribution };
            var netSalary = GetSalary(grossSalary, taxesMethods);
            Console.WriteLine(netSalary);
        }

        public static double GetSalary(double grossSalary, List<TaxEnum> taxes)
        {
            var factory = new TaxFactory();
            double nonTaxableAmount = 1000;
            double netSalary = grossSalary;
            foreach (var tax in taxes)
            {
                if (netSalary > nonTaxableAmount)
                {
                    netSalary = factory.Create(tax).Apply(netSalary, nonTaxableAmount);
                }
            }
            return netSalary;
        }

    }
    
}

// If you want to add more taxes you need to create an interface and a class for it , add it to the TaxEnum and to the TaxFactory class dictionary and to the taxesMethods list in Main