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
    public partial class AddGarageDialog : Form
    {
        SystemControls controls;
        public AddGarageDialog(SystemControls controls)
        {
            InitializeComponent();
            this.controls = controls;
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxAddress.Text) && !String.IsNullOrWhiteSpace(comboBoxRegion.Text) && !String.IsNullOrWhiteSpace(comboBoxOwnerCompany.Text))
            {
                Garage newGarage = new Garage(textBoxAddress.Text, (RegionEnum)Enum.Parse(typeof(RegionEnum), comboBoxRegion.SelectedItem.ToString()), comboBoxOwnerCompany.SelectedItem.ToString());
                controls.AddGarageRecord(newGarage);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Vyplňte všechna pole", "Upozornění");
            }
        }

        private void AddGarageDialog_Load(object sender, EventArgs e)
        {
            comboBoxRegion.DataSource = Enum.GetValues(typeof(RegionEnum));

            controls.LoadCompanyRecords();

            foreach (Company item in controls.companyDictionary.Values)
            {
                comboBoxOwnerCompany.Items.Add(item.CompanyName);
                comboBoxOwnerCompany.ValueMember = item.CompanyName;
                comboBoxOwnerCompany.DisplayMember = item.CompanyName;
                comboBoxOwnerCompany.SelectedIndex = 0;
            }
        }
    }
}
