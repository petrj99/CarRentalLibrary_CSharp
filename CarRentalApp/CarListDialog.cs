using CarRentalLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class CarListDialog : Form
    {
        SystemControls controls;
        public CarListDialog()
        {
            InitializeComponent();
            controls = new SystemControls();
        }

        private void CarListDialog_Load(object sender, EventArgs e)
        {
            rewriteGrid();
            calculateValuesOfCars();

            comboBoxSortBy.Items.Add("Výkonu");
            comboBoxSortBy.Items.Add("Ceny za den");
            comboBoxSortBy.SelectedIndex = 0;

            comboBoxAscDesc.Items.Add("Vzestupně");
            comboBoxAscDesc.Items.Add("Sestupně");
            comboBoxAscDesc.SelectedIndex = 0;

            comboBoxManufacturer.Items.Add("Default");
            foreach (Car item in controls.carDictionary.Values)
            {
                if (!comboBoxManufacturer.Items.Contains(item.Manufacturer))
                {
                    comboBoxManufacturer.Items.Add(item.Manufacturer);
                    comboBoxManufacturer.ValueMember = item.Manufacturer;
                    comboBoxManufacturer.DisplayMember = item.Manufacturer;
                    comboBoxManufacturer.SelectedIndex = 0;
                }
            }

            controls.LoadCompanyRecords();

            comboBoxCompanies.Items.Add("Default");
            foreach (Company item in controls.companyDictionary.Values)
            {
                comboBoxCompanies.Items.Add(item.CompanyName);
                comboBoxCompanies.ValueMember = item.CompanyName;
                comboBoxCompanies.DisplayMember = item.CompanyName;
                comboBoxCompanies.SelectedIndex = 0;
            }

            controls.LoadGarageRecords();

            comboBoxGarages.Items.Add("Default");
            foreach (Garage item in controls.garageDictionary.Values)
            {
                comboBoxGarages.Items.Add(item.Address);
                comboBoxGarages.ValueMember = item.Address;
                comboBoxGarages.DisplayMember = item.Address;
                comboBoxGarages.SelectedIndex = 0;
            }
        }

        public void rewriteGrid()
        {
            controls.LoadCarRecords();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = controls.carDictionary.Values;
            carGridView.DataSource = bSource;

            for (int i = 0; i < carGridView.Rows.Count; i++)
            {
                carGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        public void rewriteSortedGrid(IOrderedEnumerable<KeyValuePair<string, Car>> sorted)
        {
            BindingSource bSource = new BindingSource();
            bSource.DataSource = sorted.ToDictionary(pair => pair.Key, pair => pair.Value).Values;
            carGridView.DataSource = bSource;

            for (int i = 0; i < carGridView.Rows.Count; i++)
            {
                carGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        public void calculateValuesOfCars()
        {
            int allcarsValue = 0;
            int allCarsMileage = 0;
            foreach (Car item in controls.carDictionary.Values)
            {
                allcarsValue += item.Price;
                allCarsMileage += item.Mileage;
            }
            int averageMileage = allCarsMileage / controls.carDictionary.Count;

            labelValue.Text = allcarsValue.ToString();
            labelAverageMileage.Text = averageMileage.ToString();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddCarDialog addCar = new AddCarDialog(controls);
            addCar.ShowDialog();

            if (addCar.DialogResult == DialogResult.OK)
            {
                rewriteGrid();
            }
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            if (carGridView.SelectedRows.Count == 1)
            {
                string key = carGridView.SelectedRows[0].Cells[1].Value.ToString();

                EditCarDialog editCar = new EditCarDialog(key, controls);
                editCar.ShowDialog();

                if (editCar.DialogResult == DialogResult.OK)
                {
                    rewriteGrid();
                }
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (carGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in carGridView.SelectedRows)
                {
                    controls.RemoveCarRecord(selectedRow.Cells[1].Value.ToString());
                }
                rewriteGrid();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (String.Equals(comboBoxSortBy.SelectedItem.ToString(), "Výkonu"))
            {
                if (String.Equals(comboBoxAscDesc.SelectedItem.ToString(), "Vzestupně"))
                {
                    var sortedPowerAsc = controls.carDictionary.OrderBy(car => car.Value.Power);
                    rewriteSortedGrid(sortedPowerAsc);
                }
                else
                {
                    var sortedPowerDesc = controls.carDictionary.OrderByDescending(car => car.Value.Power);
                    rewriteSortedGrid(sortedPowerDesc);
                }
            }
            else if (String.Equals(comboBoxSortBy.SelectedItem.ToString(), "Ceny za den"))
            {
                if (String.Equals(comboBoxAscDesc.SelectedItem.ToString(), "Vzestupně"))
                {
                    var sortedPriceAsc = controls.carDictionary.OrderBy(car => car.Value.Price);
                    rewriteSortedGrid(sortedPriceAsc);
                }
                else
                {
                    var sortedPriceDesc = controls.carDictionary.OrderByDescending(car => car.Value.Price);
                    rewriteSortedGrid(sortedPriceDesc);
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[carGridView.DataSource];
            currencyManager.SuspendBinding();

            int averageMileage = 0;
            int priceSum = 0;
            int numberOfCars = 0;

            if (!comboBoxCompanies.SelectedItem.Equals("Default"))
            {
                controls.LoadCompanyCars(comboBoxCompanies.SelectedItem.ToString());
                for (int i = 0; i < carGridView.RowCount; i++)
                {
                    if (controls.companyCarsDictionary.ContainsKey(carGridView.Rows[i].Cells[1].Value.ToString().Trim()))
                    {
                        carGridView.Rows[i].Visible = true;
                        numberOfCars++;
                        averageMileage += Convert.ToInt32(carGridView.Rows[i].Cells[3].Value.ToString());
                        priceSum += Convert.ToInt32(carGridView.Rows[i].Cells[4].Value.ToString());
                    }
                    else
                    {
                        carGridView.Rows[i].Visible = false;
                    }
                }
                averageMileage /= numberOfCars;

                labelAverageMileage.Text = averageMileage.ToString();
                labelValue.Text = priceSum.ToString();
            }

            if (!comboBoxGarages.SelectedItem.Equals("Default"))
            {
                controls.LoadCarGarages(comboBoxGarages.SelectedItem.ToString());
                for (int i = 0; i < carGridView.RowCount; i++)
                {
                    if (controls.carGaragesDictionary.ContainsKey(carGridView.Rows[i].Cells[1].Value.ToString().Trim()))
                    {
                        carGridView.Rows[i].Visible = true;
                        numberOfCars++;
                        averageMileage += Convert.ToInt32(carGridView.Rows[i].Cells[3].Value.ToString());
                        priceSum += Convert.ToInt32(carGridView.Rows[i].Cells[4].Value.ToString());
                    }
                    else
                    {
                        carGridView.Rows[i].Visible = false;
                    }
                }
                averageMileage /= numberOfCars;

                labelAverageMileage.Text = averageMileage.ToString();
                labelValue.Text = priceSum.ToString();
            }

            if (!comboBoxManufacturer.SelectedItem.Equals("Default"))
            {
                for (int i = 0; i < carGridView.RowCount; i++)
                {
                    if (carGridView.Rows[i].Cells[0].Value.ToString().Trim() == comboBoxManufacturer.SelectedItem.ToString().Trim())
                    {
                        carGridView.Rows[i].Visible = true;
                        numberOfCars++;
                        averageMileage += Convert.ToInt32(carGridView.Rows[i].Cells[3].Value.ToString());
                        priceSum += Convert.ToInt32(carGridView.Rows[i].Cells[4].Value.ToString());
                    }
                    else
                    {
                        carGridView.Rows[i].Visible = false;
                    }
                }
                averageMileage /= numberOfCars;

                labelAverageMileage.Text = averageMileage.ToString();
                labelValue.Text = priceSum.ToString();
            }

            currencyManager.ResumeBinding();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rewriteGrid();
            calculateValuesOfCars();
            comboBoxCompanies.SelectedIndex = 0;
            comboBoxGarages.SelectedIndex = 0;
            comboBoxManufacturer.SelectedIndex = 0;
        }
    }
}
