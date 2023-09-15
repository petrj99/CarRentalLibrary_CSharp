namespace CarRentalApp
{
    partial class GarageListDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            garageGridView = new DataGridView();
            btnDeleteGarage = new Button();
            btnEditGarage = new Button();
            btnAddGarage = new Button();
            garageBindingSource = new BindingSource(components);
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ownerCompanyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)garageGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)garageBindingSource).BeginInit();
            SuspendLayout();
            // 
            // garageGridView
            // 
            garageGridView.AutoGenerateColumns = false;
            garageGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            garageGridView.BackgroundColor = SystemColors.Control;
            garageGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            garageGridView.Columns.AddRange(new DataGridViewColumn[] { addressDataGridViewTextBoxColumn, regionDataGridViewTextBoxColumn, ownerCompanyDataGridViewTextBoxColumn });
            garageGridView.DataSource = garageBindingSource;
            garageGridView.Location = new Point(12, 18);
            garageGridView.Name = "garageGridView";
            garageGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            garageGridView.RowTemplate.Height = 25;
            garageGridView.Size = new Size(537, 426);
            garageGridView.TabIndex = 19;
            // 
            // btnDeleteGarage
            // 
            btnDeleteGarage.BackColor = Color.Teal;
            btnDeleteGarage.FlatAppearance.BorderColor = Color.Black;
            btnDeleteGarage.FlatAppearance.BorderSize = 2;
            btnDeleteGarage.FlatStyle = FlatStyle.Flat;
            btnDeleteGarage.ForeColor = SystemColors.Control;
            btnDeleteGarage.Location = new Point(556, 116);
            btnDeleteGarage.Name = "btnDeleteGarage";
            btnDeleteGarage.Size = new Size(233, 43);
            btnDeleteGarage.TabIndex = 18;
            btnDeleteGarage.Text = "Smazat garáž";
            btnDeleteGarage.UseVisualStyleBackColor = false;
            btnDeleteGarage.Click += btnDeleteGarage_Click;
            // 
            // btnEditGarage
            // 
            btnEditGarage.BackColor = Color.Teal;
            btnEditGarage.FlatAppearance.BorderColor = Color.Black;
            btnEditGarage.FlatAppearance.BorderSize = 2;
            btnEditGarage.FlatStyle = FlatStyle.Flat;
            btnEditGarage.ForeColor = SystemColors.Control;
            btnEditGarage.Location = new Point(556, 67);
            btnEditGarage.Name = "btnEditGarage";
            btnEditGarage.Size = new Size(233, 43);
            btnEditGarage.TabIndex = 17;
            btnEditGarage.Text = "Upravit garáž";
            btnEditGarage.UseVisualStyleBackColor = false;
            btnEditGarage.Click += btnEditGarage_Click;
            // 
            // btnAddGarage
            // 
            btnAddGarage.BackColor = Color.Teal;
            btnAddGarage.FlatAppearance.BorderColor = Color.Black;
            btnAddGarage.FlatAppearance.BorderSize = 2;
            btnAddGarage.FlatStyle = FlatStyle.Flat;
            btnAddGarage.ForeColor = SystemColors.Control;
            btnAddGarage.Location = new Point(556, 18);
            btnAddGarage.Name = "btnAddGarage";
            btnAddGarage.Size = new Size(233, 43);
            btnAddGarage.TabIndex = 16;
            btnAddGarage.Text = "Přidat garáž";
            btnAddGarage.UseVisualStyleBackColor = false;
            btnAddGarage.Click += btnAddGarage_Click;
            // 
            // garageBindingSource
            // 
            garageBindingSource.DataSource = typeof(CarRentalLibrary.Garage);
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Adresa garáže";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            regionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            regionDataGridViewTextBoxColumn.HeaderText = "Region";
            regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // ownerCompanyDataGridViewTextBoxColumn
            // 
            ownerCompanyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ownerCompanyDataGridViewTextBoxColumn.DataPropertyName = "OwnerCompany";
            ownerCompanyDataGridViewTextBoxColumn.HeaderText = "Společnost (Vlastník)";
            ownerCompanyDataGridViewTextBoxColumn.Name = "ownerCompanyDataGridViewTextBoxColumn";
            // 
            // GarageListDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 463);
            Controls.Add(garageGridView);
            Controls.Add(btnDeleteGarage);
            Controls.Add(btnEditGarage);
            Controls.Add(btnAddGarage);
            Name = "GarageListDialog";
            Text = "GarageListDialog";
            Load += GarageListDialog_Load;
            ((System.ComponentModel.ISupportInitialize)garageGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)garageBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView garageGridView;
        private Button btnDeleteGarage;
        private Button btnEditGarage;
        private Button btnAddGarage;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ownerCompanyDataGridViewTextBoxColumn;
        private BindingSource garageBindingSource;
    }
}