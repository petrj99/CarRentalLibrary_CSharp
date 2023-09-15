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
    public partial class OwnerListDialog : Form
    {
        SystemControls controls;
        public OwnerListDialog()
        {
            InitializeComponent();
            controls = new SystemControls();
        }

        private void OwnerListDialog_Load(object sender, EventArgs e)
        {
            rewriteGrid();
        }

        public void rewriteGrid()
        {
            controls.LoadCompanyOwnerRecords();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = controls.companyOwnerDictionary.Values;
            ownerGridView.DataSource = bSource;

            for (int i = 0; i < ownerGridView.Rows.Count; i++)
            {
                ownerGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            AddOwnerDialog addOwner = new AddOwnerDialog(controls);
            addOwner.ShowDialog();

            if (addOwner.DialogResult == DialogResult.OK)
            {
                rewriteGrid();
            }
        }

        private void btnEditOwner_Click(object sender, EventArgs e)
        {
            if (ownerGridView.SelectedRows.Count == 1)
            {
                string key = ownerGridView.SelectedRows[0].Cells[0].Value.ToString();

                EditOwnerDialog editOwner = new EditOwnerDialog(key, controls);
                editOwner.ShowDialog();

                if (editOwner.DialogResult == DialogResult.OK)
                {
                    rewriteGrid();
                }
            }
        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            if (ownerGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in ownerGridView.SelectedRows)
                {
                    controls.RemoveCompanyOwnerRecord(selectedRow.Cells[0].Value.ToString());
                }
                rewriteGrid();
            }
        }
    }
}
