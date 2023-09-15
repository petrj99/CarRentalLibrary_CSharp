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
    public partial class EditCarDialog : Form
    {
        string objectKey;
        SystemControls controls;
        public EditCarDialog(string key, SystemControls controls)
        {
            InitializeComponent();
            this.objectKey = key;
            this.controls = controls;
        }

        private void EditCarDialog_Load(object sender, EventArgs e)
        {
            textBoxName.Text = controls.carDictionary[objectKey].Manufacturer;
            textBoxModel.Text = controls.carDictionary[objectKey].ModelName;
            textBoxPower.Text = controls.carDictionary[objectKey].Power.ToString();
            textBoxMileage.Text = controls.carDictionary[objectKey].Mileage.ToString();
            textBoxPrice.Text = controls.carDictionary[objectKey].Price.ToString();

            controls.LoadGarageRecords();

            foreach (Garage item in controls.garageDictionary.Values)
            {
                comboBoxGarages.Items.Add(item.Address);
                comboBoxGarages.ValueMember = item.Address;
                comboBoxGarages.DisplayMember = item.Address;
            }
            comboBoxGarages.SelectedIndex = comboBoxGarages.Items.IndexOf(controls.carDictionary[objectKey].CurrentGarage.Trim());
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxName.Text) && !String.IsNullOrWhiteSpace(textBoxModel.Text) && !String.IsNullOrWhiteSpace(textBoxPower.Text)
                && !String.IsNullOrWhiteSpace(textBoxMileage.Text) && !String.IsNullOrWhiteSpace(textBoxPrice.Text) && !String.IsNullOrWhiteSpace(comboBoxGarages.Text))
            {
                Car modifiedCar = new Car(textBoxName.Text, textBoxModel.Text, Convert.ToInt32(textBoxPower.Text), Convert.ToInt32(textBoxMileage.Text),
                    Convert.ToInt32(textBoxPrice.Text), comboBoxGarages.SelectedItem.ToString());
                controls.ModifyCarRecord(objectKey, modifiedCar);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
