using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface ITax
    {
        public double Apply(double amount, double nonTaxableAmount);
    }

}
