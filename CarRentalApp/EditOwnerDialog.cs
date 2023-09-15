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
    public partial class EditOwnerDialog : Form
    {
        string objectKey;
        SystemControls controls;
        public EditOwnerDialog(string key, SystemControls controls)
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
            if (!String.IsNullOrWhiteSpace(textBoxName.Text) && !String.IsNullOrWhiteSpace(textBoxAge.Text) && !String.IsNullOrWhiteSpace(textBoxWealth.Text))
            {
                CompanyOwner modifiedOwner = new CompanyOwner(textBoxName.Text, Convert.ToInt32(textBoxAge.Text), Convert.ToInt32(textBoxWealth.Text));
                controls.ModifyCompanyOwnerRecord(objectKey, modifiedOwner);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void EditOwnerDialog_Load(object sender, EventArgs e)
        {
            textBoxName.Text = controls.companyOwnerDictionary[objectKey].Name;
            textBoxAge.Text = controls.companyOwnerDictionary[objectKey].Age.ToString();
            textBoxWealth.Text = controls.companyOwnerDictionary[objectKey].Wealth.ToString();
        }
    }
}
