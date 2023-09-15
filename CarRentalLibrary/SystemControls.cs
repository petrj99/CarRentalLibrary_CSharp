using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalLibrary
{
    public class SystemControls
    {
        public Dictionary<string, Company> companyDictionary { get; set; }
        public Dictionary<string, CompanyOwner> companyOwnerDictionary { get; set; }
        public Dictionary<string, Garage> garageDictionary { get; set; }
        public Dictionary<string, Car> carDictionary { get; set; }
        public Dictionary<string, string> carGaragesDictionary { get; set; }
        public Dictionary<string, string> companyCarsDictionary { get; set; }
        private const string companyFileName = "companyRecords.txt";
        private const string companyOwnerFileName = "companyOwnerRecords.txt";
        private const string garageFileName = "garageRecords.txt";
        private const string carFileName = "carRecords.txt";
        private string line;

        public SystemControls()
        {
            this.companyDictionary = new Dictionary<string, Company>();
            this.companyOwnerDictionary = new Dictionary<string, CompanyOwner>();
            this.garageDictionary = new Dictionary<string, Garage>();
            this.carDictionary = new Dictionary<string, Car>();
            this.carGaragesDictionary = new Dictionary<string, string>();
            this.companyCarsDictionary = new Dictionary<string, string>();
        }

        public void LoadCarGarages(string garage)
        {
            carGaragesDictionary.Clear();
            LoadCarRecords();
            LoadGarageRecords();

            foreach (var car in carDictionary.Values)
            {
                if (garage.Equals(car.CurrentGarage.Trim()))
                {
                    carGaragesDictionary.Add(car.ModelName.Trim(), car.CurrentGarage.Trim());
                }
            }
        }

        public void LoadCompanyCars(string companyName)
        {
            companyCarsDictionary.Clear();

            foreach (var garage in garageDictionary.Values)
            {
                if (companyName.Equals(garage.OwnerCompany.Trim()))
                {
                    foreach (var car in carDictionary.Values)
                    {
                        if (car.CurrentGarage.Trim().Equals(garage.Address.Trim()))
                        {
                            companyCarsDictionary.Add(car.ModelName.Trim(), garage.Address.Trim());
                        }
                    }
                }
            }
        }

        //blok pro načtení společností

        public void LoadCompanyRecords()
        {
            this.companyDictionary.Clear();
            using (var stream = new StreamReader(companyFileName))
            {
                while ((line = stream.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    companyDictionary.Add(words[0], new Company(words[0], Convert.ToInt32(words[1]), Convert.ToInt32(words[2]), words[3]));
                }
                stream.Close();
            }
        }

        public void AddCompanyRecord(Company newCompany)
        {
            using (StreamWriter writer = new StreamWriter(companyFileName, true))
            {
                writer.WriteLine(String.Format("{0}, {1}, {2}, {3}", newCompany.CompanyName, newCompany.NumberOfEmployees.ToString(),
                    newCompany.YearlyIncome.ToString(), newCompany.OwnerName, Environment.NewLine));
                writer.Close();
            }
        }

        public void RemoveCompanyRecord(string key)
        {
            companyDictionary.Remove(key);

            using (StreamWriter writer = new StreamWriter(companyFileName, false))
            {
                foreach (Company item in companyDictionary.Values)
                {
                    writer.WriteLine(String.Format("{0}, {1}, {2}, {3}", item.CompanyName, item.NumberOfEmployees.ToString(), item.YearlyIncome.ToString(), item.OwnerName.Trim(), Environment.NewLine));
                }
                writer.Close();
            }
        }

        public void ModifyCompanyRecord(string key, Company modifiedCompany)
        {
            companyDictionary[key] = modifiedCompany;

            using (StreamWriter writer = new StreamWriter(companyFileName, false))
            {
                foreach (Company item in companyDictionary.Values)
                {
                    writer.WriteLine(String.Format("{0}, {1}, {2}, {3}", item.CompanyName, item.NumberOfEmployees.ToString(),
                        item.YearlyIncome.ToString(), item.OwnerName.Trim(), Environment.NewLine));
                }
            }
        }

        //Blok pro práci s CompanyOwner objekty

        public void LoadCompanyOwnerRecords()
        {
            companyOwnerDictionary.Clear();
            using (var stream = new StreamReader(companyOwnerFileName))
            {
                while ((line = stream.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    companyOwnerDictionary.Add(words[0], new CompanyOwner(words[0], Convert.ToInt32(words[1]), Convert.ToInt32(words[2])));
                }
                stream.Close();
            }
        }

        public void AddCompanyOwnerRecord(CompanyOwner newOwner)
        {
            using (StreamWriter writer = new StreamWriter(companyOwnerFileName, true))
            {
                writer.WriteLine(String.Format("{0}, {1}, {2}", newOwner.Name, newOwner.Age.ToString(), newOwner.Wealth.ToString(), Environment.NewLine));
                writer.Close();
            }
        }

        public void RemoveCompanyOwnerRecord(string key)
        {
            companyOwnerDictionary.Remove(key);

            using (StreamWriter writer = new StreamWriter(companyOwnerFileName, false))
            {
                foreach (CompanyOwner item in companyOwnerDictionary.Values)
                {
                    writer.WriteLine(String.Format("{0}, {1}, {2}", item.Name, item.Age.ToString(), item.Wealth.ToString(), Environment.NewLine));
                }
                writer.Close();
            }
        }

        public void ModifyCompanyOwnerRecord(string key, CompanyOwner modifiedOwner)
        {
            companyOwnerDictionary[key] = modifiedOwner;

            using (StreamWriter writer = new StreamWriter(companyOwnerFileName, false))
            {
                foreach (CompanyOwner item in companyOwnerDictionary.Values)
                {
                    writer.WriteLine(String.Format("{0}, {1}, {2}", item.Name, item.Age.ToString(), item.Wealth.ToString(), Environment.NewLine));
                }
                writer.Close();
            }
        }

        //Blok pro práci s Garage objekty
        public void LoadGarageRecords()
        {
            garageDictionary.Clear();
            using (var stream = new StreamReader(garageFileName))
            {
                while ((line = stream.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    garageDictionary.Add(words[0], new Garage(words[0], (RegionEnum)Enum.Parse(typeof(RegionEnum), words[1]), words[2]));
                }
                stream.Close();
            }
        }

        public void AddGarageRecord(Garage newGarage)
        {
            using (StreamWriter writer = new StreamWriter(garageFileName, true))
            {
                writer.WriteLine(String.Format("{0}, {1}, {2}", newGarage.Address, newGarage.Region.ToString(), newGarage.OwnerCompany, Environment.NewLine));
                writer.Close();
            }
        }

        public void RemoveGarageRecord(string key)
        {
            garageDictionary.Remove(key);

            using (StreamWriter writer = new StreamWriter(garageFileName, false))
            {
                foreach (Garage item in garageDictionary.Values)
                {
                    writer.WriteLine(String.Format("{0}, {1}, {2}", item.Address, item.Region.ToString(), item.OwnerCompany.Trim(), Environment.NewLine));
                }
                writer.Close();
            }
        }

        public void ModifyGarageRecord(string key, Garage modifiedGarage)
        {
            garageDictionary[key] = modifiedGarage;

            using (StreamWriter writer = new StreamWriter(garageFileName, false))
            {
                foreach (Garage item in garageDictionary.Values)
                {
                    writer.WriteLine(String.Format("{0}, {1}, {2}", item.Address, item.Region.ToString(), item.OwnerCompany.Trim(), Environment.NewLine));
                }
                writer.Close();
            }
        }

        //Blok pro práci s Car objekty

        public void LoadCarRecords()
        {
            carDictionary.Clear();
            using (var stream = new StreamReader(carFileName))
            {
                while ((line = stream.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    carDictionary.Add(words[1], new Car(words[0], words[1], Convert.ToInt32(words[2]), Convert.ToInt32(words[3]),
                        Convert.ToInt32(words[4]), words[5]));
                }
                stream.Close();
            }
        }

        public void AddCarRecord(Car newCar)
        {
            using (StreamWriter writer = new StreamWriter(carFileName, true))
            {
                writer.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}", newCar.Manufacturer, newCar.ModelName,
                    newCar.Power.ToString(), newCar.Mileage.ToString(), newCar.Price.ToString(), newCar.CurrentGarage, Environment.NewLine));
                writer.Close();
            }
        }

        public void RemoveCarRecord(string key)
        {
            carDictionary.Remove(key);

            using (StreamWriter writer = new StreamWriter(carFileName, false))
            {
                foreach (Car item in carDictionary.Values)
                {
                    writer.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}", item.Manufacturer, item.ModelName.Trim(), item.Power.ToString(),
                        item.Mileage.ToString(), item.Price.ToString(), item.CurrentGarage, Environment.NewLine));
                }
                writer.Close();
            }
        }

        public void ModifyCarRecord(string key, Car modifiedCar)
        {
            carDictionary[key] = modifiedCar;

            using (StreamWriter writer = new StreamWriter(carFileName, false))
            {
                foreach (Car item in carDictionary.Values)
                {
                    writer.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}", item.Manufacturer, item.ModelName.Trim(), item.Power.ToString(),
                        item.Mileage.ToString(), item.Price.ToString(), item.CurrentGarage, Environment.NewLine));
                }
                writer.Close();
            }
        }
    }
}
