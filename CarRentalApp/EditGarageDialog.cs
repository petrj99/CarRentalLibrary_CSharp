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
    public partial class EditGarageDialog : Form
    {
        string objectKey;
        SystemControls controls;
        public EditGarageDialog(string key, SystemControls controls)
        {
            InitializeComponent();
            this.objectKey = key;
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
                Garage modifiedGarage = new Garage(textBoxAddress.Text, (RegionEnum)Enum.Parse(typeof(RegionEnum), comboBoxRegion.SelectedItem.ToString()), comboBoxOwnerCompany.SelectedItem.ToString());
                controls.ModifyGarageRecord(objectKey, modifiedGarage);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void EditGarageDialog_Load(object sender, EventArgs e)
        {
            textBoxAddress.Text = controls.garageDictionary[objectKey].Address;

            comboBoxRegion.DataSource = Enum.GetValues(typeof(RegionEnum));
            comboBoxRegion.SelectedIndex = comboBoxRegion.Items.IndexOf(controls.garageDictionary[objectKey].Region);

            controls.LoadCompanyRecords();

            foreach (Company item in controls.companyDictionary.Values)
            {
                comboBoxOwnerCompany.Items.Add(item.CompanyName.ToString());
                comboBoxOwnerCompany.ValueMember = item.CompanyName;
                comboBoxOwnerCompany.DisplayMember = item.CompanyName;
            }
            comboBoxOwnerCompany.SelectedIndex = comboBoxOwnerCompany.Items.IndexOf(controls.garageDictionary[objectKey].OwnerCompany.Trim());
        }
    }
}
