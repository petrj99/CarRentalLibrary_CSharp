using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalLibrary
{
    [Serializable]
    public class Company
    {
        [System.ComponentModel.DisplayName("Název")]
        public string CompanyName { get; set; }
        [System.ComponentModel.DisplayName("Počet zaměstnanců")]
        public int NumberOfEmployees { get; set; }
        [System.ComponentModel.DisplayName("Roční příjem (v mil. CZK)")]
        public int YearlyIncome { get; set; }
        [System.ComponentModel.DisplayName("Vlastník")]
        public string OwnerName { get; set; }

        public Company(string name, int employeesCount, int yearlyIncome, string ownerName)
        {
            this.CompanyName = name;
            this.NumberOfEmployees = employeesCount;
            this.YearlyIncome = yearlyIncome;
            this.OwnerName = ownerName;
        }
    }
}
