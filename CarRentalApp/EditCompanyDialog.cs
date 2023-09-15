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
    public partial class EditCompanyDialog : Form
    {
        string objectKey;
        SystemControls controls;
        public EditCompanyDialog(string key, SystemControls controls)
        {
            InitializeComponent();
            this.objectKey = key;
            this.controls = controls;
        }

        private void EditCompanyDialog_Load(object sender, EventArgs e)
        {
            textBoxName.Text = controls.companyDictionary[objectKey].CompanyName;
            textBoxNoEmployees.Text = controls.companyDictionary[objectKey].NumberOfEmployees.ToString();
            textBoxIncome.Text = controls.companyDictionary[objectKey].YearlyIncome.ToString();

            controls.LoadCompanyOwnerRecords();

            foreach (CompanyOwner item in controls.companyOwnerDictionary.Values)
            {
                comboBoxOwners.Items.Add(item.Name.ToString());
                comboBoxOwners.ValueMember = item.Name;
                comboBoxOwners.DisplayMember = item.Name;
            }
            comboBoxOwners.SelectedIndex = comboBoxOwners.Items.IndexOf(controls.companyDictionary[objectKey].OwnerName.Trim());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxName.Text) && !String.IsNullOrWhiteSpace(textBoxNoEmployees.Text) && !String.IsNullOrWhiteSpace(textBoxIncome.Text))
            {
                Company modifiedCompany = new Company(textBoxName.Text, Convert.ToInt32(textBoxNoEmployees.Text), Convert.ToInt32(textBoxIncome.Text), comboBoxOwners.SelectedItem.ToString());
                controls.ModifyCompanyRecord(objectKey, modifiedCompany);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
