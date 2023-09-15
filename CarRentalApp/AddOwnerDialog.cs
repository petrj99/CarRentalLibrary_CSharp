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
    public partial class AddOwnerDialog : Form
    {
        SystemControls controls;
        public AddOwnerDialog(SystemControls controls)
        {
            this.controls = controls;
            InitializeComponent();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxName.Text) && !String.IsNullOrWhiteSpace(textBoxAge.Text)
                && !String.IsNullOrWhiteSpace(textBoxWealth.Text))
            {
                try
                {
                    CompanyOwner newOwner = new CompanyOwner(textBoxName.Text, Convert.ToInt32(textBoxAge.Text),
                                         Convert.ToInt32(textBoxWealth.Text));
                    controls.AddCompanyOwnerRecord(newOwner);
                    DialogResult = DialogResult.OK;
                    Close();
                } catch {
                    MessageBox.Show("Zadejte údaje ve správném formátu", "Upozornění");
                }
            } else
            {
                MessageBox.Show("Vyplňte všechna pole", "Upozornění");
            }
        }
    }
}
