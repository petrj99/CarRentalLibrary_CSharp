namespace CarRentalApp
{
    partial class CompanyListDialog
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
            companyGridView = new DataGridView();
            btnDeleteCompany = new Button();
            btnEditCompany = new Button();
            btnAddCompany = new Button();
            companyBindingSource = new BindingSource(components);
            companyNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberOfEmployeesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearlyIncomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ownerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)companyGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)companyBindingSource).BeginInit();
            SuspendLayout();
            // 
            // companyGridView
            // 
            companyGridView.AutoGenerateColumns = false;
            companyGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            companyGridView.BackgroundColor = SystemColors.ButtonFace;
            companyGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            companyGridView.Columns.AddRange(new DataGridViewColumn[] { companyNameDataGridViewTextBoxColumn, numberOfEmployeesDataGridViewTextBoxColumn, yearlyIncomeDataGridViewTextBoxColumn, ownerNameDataGridViewTextBoxColumn });
            companyGridView.DataSource = companyBindingSource;
            companyGridView.GridColor = Color.Black;
            companyGridView.Location = new Point(12, 12);
            companyGridView.Name = "companyGridView";
            companyGridView.ReadOnly = true;
            companyGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            companyGridView.RowTemplate.Height = 25;
            companyGridView.Size = new Size(536, 436);
            companyGridView.TabIndex = 1;
            // 
            // btnDeleteCompany
            // 
            btnDeleteCompany.BackColor = Color.Teal;
            btnDeleteCompany.FlatAppearance.BorderColor = Color.Black;
            btnDeleteCompany.FlatAppearance.BorderSize = 2;
            btnDeleteCompany.FlatStyle = FlatStyle.Flat;
            btnDeleteCompany.ForeColor = SystemColors.Control;
            btnDeleteCompany.Location = new Point(555, 110);
            btnDeleteCompany.Name = "btnDeleteCompany";
            btnDeleteCompany.Size = new Size(233, 43);
            btnDeleteCompany.TabIndex = 6;
            btnDeleteCompany.Text = "Smazat firmu";
            btnDeleteCompany.UseVisualStyleBackColor = false;
            btnDeleteCompany.Click += btnDeleteCompany_Click;
            // 
            // btnEditCompany
            // 
            btnEditCompany.BackColor = Color.Teal;
            btnEditCompany.FlatAppearance.BorderColor = Color.Black;
            btnEditCompany.FlatAppearance.BorderSize = 2;
            btnEditCompany.FlatStyle = FlatStyle.Flat;
            btnEditCompany.ForeColor = SystemColors.Control;
            btnEditCompany.Location = new Point(555, 61);
            btnEditCompany.Name = "btnEditCompany";
            btnEditCompany.Size = new Size(233, 43);
            btnEditCompany.TabIndex = 5;
            btnEditCompany.Text = "Upravit firmu";
            btnEditCompany.UseVisualStyleBackColor = false;
            btnEditCompany.Click += btnEditCompany_Click;
            // 
            // btnAddCompany
            // 
            btnAddCompany.BackColor = Color.Teal;
            btnAddCompany.FlatAppearance.BorderColor = Color.Black;
            btnAddCompany.FlatAppearance.BorderSize = 2;
            btnAddCompany.FlatStyle = FlatStyle.Flat;
            btnAddCompany.ForeColor = SystemColors.Control;
            btnAddCompany.Location = new Point(555, 12);
            btnAddCompany.Name = "btnAddCompany";
            btnAddCompany.Size = new Size(233, 43);
            btnAddCompany.TabIndex = 4;
            btnAddCompany.Text = "Přidat firmu";
            btnAddCompany.UseVisualStyleBackColor = false;
            btnAddCompany.Click += btnAddCompany_Click;
            // 
            // companyBindingSource
            // 
            companyBindingSource.DataSource = typeof(CarRentalLibrary.Company);
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            companyNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            companyNameDataGridViewTextBoxColumn.HeaderText = "Název";
            companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfEmployeesDataGridViewTextBoxColumn
            // 
            numberOfEmployeesDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            numberOfEmployeesDataGridViewTextBoxColumn.DataPropertyName = "NumberOfEmployees";
            numberOfEmployeesDataGridViewTextBoxColumn.HeaderText = "Počet zaměstnanců";
            numberOfEmployeesDataGridViewTextBoxColumn.Name = "numberOfEmployeesDataGridViewTextBoxColumn";
            numberOfEmployeesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearlyIncomeDataGridViewTextBoxColumn
            // 
            yearlyIncomeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            yearlyIncomeDataGridViewTextBoxColumn.DataPropertyName = "YearlyIncome";
            yearlyIncomeDataGridViewTextBoxColumn.HeaderText = "Roční příjem (v mil. CZK)";
            yearlyIncomeDataGridViewTextBoxColumn.Name = "yearlyIncomeDataGridViewTextBoxColumn";
            yearlyIncomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerNameDataGridViewTextBoxColumn
            // 
            ownerNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ownerNameDataGridViewTextBoxColumn.DataPropertyName = "OwnerName";
            ownerNameDataGridViewTextBoxColumn.HeaderText = "Vlastník";
            ownerNameDataGridViewTextBoxColumn.Name = "ownerNameDataGridViewTextBoxColumn";
            ownerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CompanyListDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 460);
            Controls.Add(btnDeleteCompany);
            Controls.Add(btnEditCompany);
            Controls.Add(btnAddCompany);
            Controls.Add(companyGridView);
            Name = "CompanyListDialog";
            Text = "CompanyListDialog";
            Load += CompanyListDialog_Load;
            ((System.ComponentModel.ISupportInitialize)companyGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)companyBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView companyGridView;
        private Button btnDeleteCompany;
        private Button btnEditCompany;
        private Button btnAddCompany;
        private DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfEmployeesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearlyIncomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ownerNameDataGridViewTextBoxColumn;
        private BindingSource companyBindingSource;
    }
}