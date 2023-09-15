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
    public partial class GarageListDialog : Form
    {
        SystemControls controls;
        public GarageListDialog()
        {
            InitializeComponent();
            controls = new SystemControls();
        }

        private void GarageListDialog_Load(object sender, EventArgs e)
        {
            rewriteGrid();
        }

        public void rewriteGrid()
        {
            controls.LoadGarageRecords();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = controls.garageDictionary.Values;
            garageGridView.DataSource = bSource;

            for (int i = 0; i < garageGridView.Rows.Count; i++)
            {
                garageGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void btnAddGarage_Click(object sender, EventArgs e)
        {
            AddGarageDialog addWarehouse = new AddGarageDialog(controls);
            addWarehouse.ShowDialog();

            if (addWarehouse.DialogResult == DialogResult.OK)
            {
                rewriteGrid();
            }
        }

        private void btnEditGarage_Click(object sender, EventArgs e)
        {
            if (garageGridView.SelectedRows.Count == 1)
            {
                string key = garageGridView.SelectedRows[0].Cells[0].Value.ToString();

                EditGarageDialog editWarehouse = new EditGarageDialog(key, controls);
                editWarehouse.ShowDialog();

                if (editWarehouse.DialogResult == DialogResult.OK)
                {
                    rewriteGrid();
                }
            }
        }

        private void btnDeleteGarage_Click(object sender, EventArgs e)
        {
            if (garageGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in garageGridView.SelectedRows)
                {
                    controls.RemoveGarageRecord(selectedRow.Cells[0].Value.ToString());
                }
                rewriteGrid();
            }
        }
    }
}
