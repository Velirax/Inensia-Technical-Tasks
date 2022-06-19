using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
   public class Person
    {
        public DateTime dateOfBirth { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Sex { get; set; }

        public string Nationality { get; set; }

       public string CalculateYourAge()
        {
            int Years = new DateTime(DateTime.Now.Subtract(dateOfBirth).Ticks).Year - 1;
            return String.Format("{0} Years years old",Years);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name + " " + Surname);
            sb.AppendLine(Sex);
            sb.AppendLine(Nationality);
            sb.AppendLine(CalculateYourAge());
            return sb.ToString();
        }

    }

    
}
