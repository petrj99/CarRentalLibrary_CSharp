using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalLibrary
{
    [Serializable]
    public class CompanyOwner
    {
        [System.ComponentModel.DisplayName("Jméno")]
        public string Name { get; set; }
        [System.ComponentModel.DisplayName("Věk")]
        public int Age { get; set; }
        [System.ComponentModel.DisplayName("Hodnota majetku (v mil. CZK)")]
        public int Wealth { get; set; }

        public CompanyOwner(string name, int age, int wealth)
        {
            this.Name = name;
            this.Age = age;
            this.Wealth = wealth;
        }
    }
}
