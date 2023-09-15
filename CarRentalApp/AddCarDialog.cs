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
    public partial class AddCarDialog : Form
    {
        SystemControls controls;
        public AddCarDialog(SystemControls controls)
        {
            InitializeComponent();
            this.controls = controls;
        }

        private void AddCarDialog_Load(object sender, EventArgs e)
        {
            controls.LoadGarageRecords();

            foreach (Garage item in controls.garageDictionary.Values)
            {
                comboBoxGarages.Items.Add(item.Address);
                comboBoxGarages.ValueMember = item.Address;
                comboBoxGarages.DisplayMember = item.Address;
                comboBoxGarages.SelectedIndex = 0;
            }
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
                Car newCar = new Car(textBoxName.Text, textBoxModel.Text, Convert.ToInt32(textBoxPower.Text), Convert.ToInt32(textBoxMileage.Text),
                    Convert.ToInt32(textBoxPrice.Text), comboBoxGarages.SelectedItem.ToString());
                controls.AddCarRecord(newCar);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Vyplňte všechna pole", "Upozornění");
            }
        }
    }
}
