using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalLibrary
{
    [Serializable]
    public class Car
    {
        [System.ComponentModel.DisplayName("Výrobce")]
        public string Manufacturer { get; set; }
        [System.ComponentModel.DisplayName("Model")]
        public string ModelName { get; set; }
        [System.ComponentModel.DisplayName("Výkon (v kW)")]
        public int Power { get; set; }
        [System.ComponentModel.DisplayName("Najeto (v tkm)")]
        public int Mileage { get; set; }
        [System.ComponentModel.DisplayName("Cena za den v kč")]
        public int Price { get; set; }
        [System.ComponentModel.DisplayName("Adresa garáže")]
        public string CurrentGarage { get; set; }

        public Car(string manufacturer, string modelName, int power, int mileage, int price, string currentGarage)
        {
            Manufacturer = manufacturer;
            ModelName = modelName;
            Power = power;
            Mileage = mileage;
            Price = price;
            CurrentGarage = currentGarage;
        }
    }
}
