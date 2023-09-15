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
    public partial class CompanyListDialog : Form
    {
        SystemControls controls;
        public CompanyListDialog()
        {
            InitializeComponent();
            controls = new SystemControls();
        }

        private void CompanyListDialog_Load(object sender, EventArgs e)
        {
            rewriteGrid();
        }

        public void rewriteGrid()
        {
            controls.LoadCompanyRecords();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = controls.companyDictionary.Values;
            companyGridView.DataSource = bSource;

            for (int i = 0; i < companyGridView.Rows.Count; i++)
            {
                companyGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            AddCompanyDialog addCompany = new AddCompanyDialog(controls);
            addCompany.ShowDialog();

            if (addCompany.DialogResult == DialogResult.OK)
            {
                rewriteGrid();
            }
        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            if (companyGridView.SelectedRows.Count == 1)
            {
                string key = companyGridView.SelectedRows[0].Cells[0].Value.ToString();

                EditCompanyDialog editCompany = new EditCompanyDialog(key, controls);
                editCompany.ShowDialog();

                if (editCompany.DialogResult == DialogResult.OK)
                {
                    rewriteGrid();
                }
            }
        }

        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            if (companyGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in companyGridView.SelectedRows)
                {
                    controls.RemoveCompanyRecord(selectedRow.Cells[0].Value.ToString());
                }
                rewriteGrid();
            }
        }
    }
}
