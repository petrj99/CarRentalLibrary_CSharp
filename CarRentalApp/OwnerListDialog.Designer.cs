namespace CarRentalApp
{
    partial class OwnerListDialog
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
            btnDeleteOwner = new Button();
            btnEditOwner = new Button();
            btnAddOwner = new Button();
            ownerGridView = new DataGridView();
            companyOwnerBindingSource = new BindingSource(components);
            wealthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ownerGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)companyOwnerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteOwner
            // 
            btnDeleteOwner.BackColor = Color.Teal;
            btnDeleteOwner.FlatAppearance.BorderColor = Color.Black;
            btnDeleteOwner.FlatAppearance.BorderSize = 2;
            btnDeleteOwner.FlatStyle = FlatStyle.Flat;
            btnDeleteOwner.ForeColor = SystemColors.Control;
            btnDeleteOwner.Location = new Point(555, 105);
            btnDeleteOwner.Name = "btnDeleteOwner";
            btnDeleteOwner.Size = new Size(233, 43);
            btnDeleteOwner.TabIndex = 10;
            btnDeleteOwner.Text = "Smazat vlastníka";
            btnDeleteOwner.UseVisualStyleBackColor = false;
            btnDeleteOwner.Click += btnDeleteOwner_Click;
            // 
            // btnEditOwner
            // 
            btnEditOwner.BackColor = Color.Teal;
            btnEditOwner.FlatAppearance.BorderColor = Color.Black;
            btnEditOwner.FlatAppearance.BorderSize = 2;
            btnEditOwner.FlatStyle = FlatStyle.Flat;
            btnEditOwner.ForeColor = SystemColors.Control;
            btnEditOwner.Location = new Point(555, 56);
            btnEditOwner.Name = "btnEditOwner";
            btnEditOwner.Size = new Size(233, 43);
            btnEditOwner.TabIndex = 9;
            btnEditOwner.Text = "Upravit vlastníka";
            btnEditOwner.UseVisualStyleBackColor = false;
            btnEditOwner.Click += btnEditOwner_Click;
            // 
            // btnAddOwner
            // 
            btnAddOwner.BackColor = Color.Teal;
            btnAddOwner.FlatAppearance.BorderColor = Color.Black;
            btnAddOwner.FlatAppearance.BorderSize = 2;
            btnAddOwner.FlatStyle = FlatStyle.Flat;
            btnAddOwner.ForeColor = SystemColors.Control;
            btnAddOwner.Location = new Point(555, 7);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(233, 43);
            btnAddOwner.TabIndex = 8;
            btnAddOwner.Text = "Přidat vlastníka";
            btnAddOwner.UseVisualStyleBackColor = false;
            btnAddOwner.Click += btnAddOwner_Click;
            // 
            // ownerGridView
            // 
            ownerGridView.AutoGenerateColumns = false;
            ownerGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            ownerGridView.BackgroundColor = SystemColors.Control;
            ownerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ownerGridView.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, wealthDataGridViewTextBoxColumn });
            ownerGridView.DataSource = companyOwnerBindingSource;
            ownerGridView.Location = new Point(12, 7);
            ownerGridView.Name = "ownerGridView";
            ownerGridView.ReadOnly = true;
            ownerGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ownerGridView.RowTemplate.Height = 25;
            ownerGridView.Size = new Size(537, 426);
            ownerGridView.TabIndex = 11;
            // 
            // companyOwnerBindingSource
            // 
            companyOwnerBindingSource.DataSource = typeof(CarRentalLibrary.CompanyOwner);
            // 
            // wealthDataGridViewTextBoxColumn
            // 
            wealthDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            wealthDataGridViewTextBoxColumn.DataPropertyName = "Wealth";
            wealthDataGridViewTextBoxColumn.HeaderText = "Hodnota majetku (v mil. CZK)";
            wealthDataGridViewTextBoxColumn.Name = "wealthDataGridViewTextBoxColumn";
            wealthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Věk";
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Jméno";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OwnerListDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(ownerGridView);
            Controls.Add(btnDeleteOwner);
            Controls.Add(btnEditOwner);
            Controls.Add(btnAddOwner);
            Name = "OwnerListDialog";
            Text = "OwnerListDialog";
            Load += OwnerListDialog_Load;
            ((System.ComponentModel.ISupportInitialize)ownerGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)companyOwnerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDeleteOwner;
        private Button btnEditOwner;
        private Button btnAddOwner;
        private DataGridView ownerGridView;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wealthDataGridViewTextBoxColumn;
        private BindingSource companyOwnerBindingSource;
    }
}