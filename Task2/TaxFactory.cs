using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class TaxFactory
    {
        private Dictionary<TaxEnum, ITax> dict = new Dictionary<TaxEnum, ITax>() {
        {TaxEnum.Income, new IncomeTax{ } },
            {TaxEnum.SocialContribution, new SocialContributionTax{ } }
        };
        public ITax Create(TaxEnum type)
        {
            return dict[type];
        }
    }

}
