namespace CarRentalApp
{
    partial class CarListDialog
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
            carGridView = new DataGridView();
            manufacturerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            powerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mileageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carBindingSource = new BindingSource(components);
            btnDeleteCar = new Button();
            btnEditCar = new Button();
            btnAddCar = new Button();
            comboBoxCompanies = new ComboBox();
            labelFilter2 = new Label();
            btnReset = new Button();
            btnFilter = new Button();
            comboBoxGarages = new ComboBox();
            labelFilter = new Label();
            comboBoxManufacturer = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            labelValue = new Label();
            labelAverageMileage = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxSortBy = new ComboBox();
            comboBoxAscDesc = new ComboBox();
            btnSort = new Button();
            ((System.ComponentModel.ISupportInitialize)carGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            SuspendLayout();
            // 
            // carGridView
            // 
            carGridView.AutoGenerateColumns = false;
            carGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            carGridView.BackgroundColor = SystemColors.Control;
            carGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carGridView.Columns.AddRange(new DataGridViewColumn[] { manufacturerDataGridViewTextBoxColumn, modelNameDataGridViewTextBoxColumn, powerDataGridViewTextBoxColumn, mileageDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            carGridView.DataSource = carBindingSource;
            carGridView.Location = new Point(12, 18);
            carGridView.Name = "carGridView";
            carGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            carGridView.RowTemplate.Height = 25;
            carGridView.Size = new Size(537, 426);
            carGridView.TabIndex = 18;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            manufacturerDataGridViewTextBoxColumn.HeaderText = "Výrobce";
            manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            modelNameDataGridViewTextBoxColumn.HeaderText = "Model";
            modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // powerDataGridViewTextBoxColumn
            // 
            powerDataGridViewTextBoxColumn.DataPropertyName = "Power";
            powerDataGridViewTextBoxColumn.HeaderText = "Výkon (v kW)";
            powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
            // 
            // mileageDataGridViewTextBoxColumn
            // 
            mileageDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mileageDataGridViewTextBoxColumn.DataPropertyName = "Mileage";
            mileageDataGridViewTextBoxColumn.HeaderText = "Najeto (v tkm)";
            mileageDataGridViewTextBoxColumn.Name = "mileageDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Cena za den v kč";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(CarRentalLibrary.Car);
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.BackColor = Color.Teal;
            btnDeleteCar.FlatAppearance.BorderColor = Color.Black;
            btnDeleteCar.FlatAppearance.BorderSize = 2;
            btnDeleteCar.FlatStyle = FlatStyle.Flat;
            btnDeleteCar.ForeColor = SystemColors.Control;
            btnDeleteCar.Location = new Point(556, 116);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(233, 43);
            btnDeleteCar.TabIndex = 17;
            btnDeleteCar.Text = "Smazat auto\r\n";
            btnDeleteCar.UseVisualStyleBackColor = false;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // btnEditCar
            // 
            btnEditCar.BackColor = Color.Teal;
            btnEditCar.FlatAppearance.BorderColor = Color.Black;
            btnEditCar.FlatAppearance.BorderSize = 2;
            btnEditCar.FlatStyle = FlatStyle.Flat;
            btnEditCar.ForeColor = SystemColors.Control;
            btnEditCar.Location = new Point(556, 67);
            btnEditCar.Name = "btnEditCar";
            btnEditCar.Size = new Size(233, 43);
            btnEditCar.TabIndex = 16;
            btnEditCar.Text = "Upravit auto";
            btnEditCar.UseVisualStyleBackColor = false;
            btnEditCar.Click += btnEditCar_Click;
            // 
            // btnAddCar
            // 
            btnAddCar.BackColor = Color.Teal;
            btnAddCar.FlatAppearance.BorderColor = Color.Black;
            btnAddCar.FlatAppearance.BorderSize = 2;
            btnAddCar.FlatStyle = FlatStyle.Flat;
            btnAddCar.ForeColor = SystemColors.Control;
            btnAddCar.Location = new Point(556, 18);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(233, 43);
            btnAddCar.TabIndex = 15;
            btnAddCar.Text = "Přidat auto";
            btnAddCar.UseVisualStyleBackColor = false;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // comboBoxCompanies
            // 
            comboBoxCompanies.FormattingEnabled = true;
            comboBoxCompanies.Location = new Point(554, 189);
            comboBoxCompanies.Name = "comboBoxCompanies";
            comboBoxCompanies.Size = new Size(233, 23);
            comboBoxCompanies.TabIndex = 24;
            // 
            // labelFilter2
            // 
            labelFilter2.AutoSize = true;
            labelFilter2.Location = new Point(554, 171);
            labelFilter2.Name = "labelFilter2";
            labelFilter2.Size = new Size(109, 15);
            labelFilter2.TabIndex = 23;
            labelFilter2.Text = "Filtrace podle firem";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(556, 359);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(233, 43);
            btnReset.TabIndex = 22;
            btnReset.Text = "Odebrat filtry";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(554, 310);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(233, 43);
            btnFilter.TabIndex = 21;
            btnFilter.Text = "Filtrovat";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // comboBoxGarages
            // 
            comboBoxGarages.FormattingEnabled = true;
            comboBoxGarages.Location = new Point(554, 233);
            comboBoxGarages.Name = "comboBoxGarages";
            comboBoxGarages.Size = new Size(233, 23);
            comboBoxGarages.TabIndex = 20;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(554, 215);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(112, 15);
            labelFilter.TabIndex = 19;
            labelFilter.Text = "Filtrace podle garáží";
            // 
            // comboBoxManufacturer
            // 
            comboBoxManufacturer.FormattingEnabled = true;
            comboBoxManufacturer.Location = new Point(555, 277);
            comboBoxManufacturer.Name = "comboBoxManufacturer";
            comboBoxManufacturer.Size = new Size(233, 23);
            comboBoxManufacturer.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(555, 259);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 25;
            label1.Text = "Filtrace podle značek";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(555, 405);
            label2.Name = "label2";
            label2.Size = new Size(153, 30);
            label2.TabIndex = 27;
            label2.Text = "Cena pronájmu všech vozů:\r\n:";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(712, 405);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(13, 15);
            labelValue.TabIndex = 28;
            labelValue.Text = "0";
            // 
            // labelAverageMileage
            // 
            labelAverageMileage.AutoSize = true;
            labelAverageMileage.Location = new Point(712, 427);
            labelAverageMileage.Name = "labelAverageMileage";
            labelAverageMileage.Size = new Size(13, 15);
            labelAverageMileage.TabIndex = 30;
            labelAverageMileage.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(556, 426);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 29;
            label4.Text = "Průměrný nájezd:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(753, 405);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 31;
            label3.Text = "Kč\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(753, 427);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 32;
            label5.Text = "tkm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 473);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 33;
            label6.Text = "Řazení podle:";
            // 
            // comboBoxSortBy
            // 
            comboBoxSortBy.FormattingEnabled = true;
            comboBoxSortBy.Location = new Point(95, 470);
            comboBoxSortBy.Name = "comboBoxSortBy";
            comboBoxSortBy.Size = new Size(121, 23);
            comboBoxSortBy.TabIndex = 34;
            // 
            // comboBoxAscDesc
            // 
            comboBoxAscDesc.FormattingEnabled = true;
            comboBoxAscDesc.Location = new Point(222, 470);
            comboBoxAscDesc.Name = "comboBoxAscDesc";
            comboBoxAscDesc.Size = new Size(121, 23);
            comboBoxAscDesc.TabIndex = 35;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(349, 470);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 36;
            btnSort.Text = "Seřadit";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // CarListDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 528);
            Controls.Add(btnSort);
            Controls.Add(comboBoxAscDesc);
            Controls.Add(comboBoxSortBy);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(labelAverageMileage);
            Controls.Add(label4);
            Controls.Add(labelValue);
            Controls.Add(label2);
            Controls.Add(comboBoxManufacturer);
            Controls.Add(label1);
            Controls.Add(comboBoxCompanies);
            Controls.Add(labelFilter2);
            Controls.Add(btnReset);
            Controls.Add(btnFilter);
            Controls.Add(comboBoxGarages);
            Controls.Add(labelFilter);
            Controls.Add(carGridView);
            Controls.Add(btnDeleteCar);
            Controls.Add(btnEditCar);
            Controls.Add(btnAddCar);
            Name = "CarListDialog";
            Text = "CarListDialog";
            Load += CarListDialog_Load;
            ((System.ComponentModel.ISupportInitialize)carGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView carGridView;
        private Button btnDeleteCar;
        private Button btnEditCar;
        private Button btnAddCar;
        private BindingSource carBindingSource;
        private ComboBox comboBoxCompanies;
        private Label labelFilter2;
        private Button btnReset;
        private Button btnFilter;
        private ComboBox comboBoxGarages;
        private Label labelFilter;
        private ComboBox comboBoxManufacturer;
        private Label label1;
        private Label label2;
        private Label labelValue;
        private Label labelAverageMileage;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxSortBy;
        private ComboBox comboBoxAscDesc;
        private Button btnSort;
        private DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mileageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}