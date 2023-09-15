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
    public partial class AddCompanyDialog : Form
    {
        SystemControls controls;
        public AddCompanyDialog(SystemControls controls)
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
            if (!String.IsNullOrWhiteSpace(textBoxName.Text) && !String.IsNullOrWhiteSpace(textBoxNoEmployees.Text) && !String.IsNullOrWhiteSpace(textBoxIncome.Text))
            {
                Company newCompany = new Company(textBoxName.Text, Convert.ToInt32(textBoxNoEmployees.Text), Convert.ToInt32(textBoxIncome.Text), comboBoxOwners.SelectedItem.ToString());
                controls.AddCompanyRecord(newCompany);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Vyplňte všechna pole", "Upozornění");
            }
        }

        private void AddCompanyDialog_Load(object sender, EventArgs e)
        {
            controls.LoadCompanyOwnerRecords();

            foreach (CompanyOwner item in controls.companyOwnerDictionary.Values)
            {
                comboBoxOwners.Items.Add(item.Name);
                comboBoxOwners.ValueMember = item.Name;
                comboBoxOwners.DisplayMember = item.Name;
                comboBoxOwners.SelectedIndex = 0;
            }
        }
    }
}
