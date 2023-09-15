using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalLibrary
{
    [Serializable]
    public class Garage
    {
        [System.ComponentModel.DisplayName("Adresa garáže")]
        public string Address { get; set; }
        [System.ComponentModel.DisplayName("Region")]
        public RegionEnum Region { get; set; }
        [System.ComponentModel.DisplayName("Společnost (Vlastník)")]
        public string OwnerCompany { get; set; }

        public Garage(string address, RegionEnum region, string ownerCompany)
        {
            Address = address;
            Region = region;
            OwnerCompany = ownerCompany;
        }
    }
}
