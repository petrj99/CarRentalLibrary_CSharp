namespace CarRentalApp
{
    partial class AddCarDialog
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
            comboBoxGarages = new ComboBox();
            labelCurrentGarage = new Label();
            textBoxPower = new TextBox();
            labelPower = new Label();
            textBoxModel = new TextBox();
            labelModel = new Label();
            textBoxName = new TextBox();
            labelManufacturer = new Label();
            textBoxMileage = new TextBox();
            labelMileage = new Label();
            textBoxPrice = new TextBox();
            labelPrice = new Label();
            btnStorno = new Button();
            btnOk = new Button();
            SuspendLayout();
            // 
            // comboBoxGarages
            // 
            comboBoxGarages.FormattingEnabled = true;
            comboBoxGarages.Location = new Point(13, 441);
            comboBoxGarages.Name = "comboBoxGarages";
            comboBoxGarages.Size = new Size(473, 23);
            comboBoxGarages.TabIndex = 39;
            // 
            // labelCurrentGarage
            // 
            labelCurrentGarage.AutoSize = true;
            labelCurrentGarage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCurrentGarage.Location = new Point(12, 417);
            labelCurrentGarage.Name = "labelCurrentGarage";
            labelCurrentGarage.Size = new Size(167, 21);
            labelCurrentGarage.TabIndex = 38;
            labelCurrentGarage.Text = "Adresa aktuální garáže";
            // 
            // textBoxPower
            // 
            textBoxPower.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPower.Location = new Point(12, 195);
            textBoxPower.Name = "textBoxPower";
            textBoxPower.Size = new Size(473, 29);
            textBoxPower.TabIndex = 37;
            // 
            // labelPower
            // 
            labelPower.AutoSize = true;
            labelPower.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPower.Location = new Point(12, 171);
            labelPower.Name = "labelPower";
            labelPower.Size = new Size(94, 21);
            labelPower.TabIndex = 36;
            labelPower.Text = "Výkon v KW";
            // 
            // textBoxModel
            // 
            textBoxModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxModel.Location = new Point(12, 116);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(473, 29);
            textBoxModel.TabIndex = 35;
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelModel.Location = new Point(12, 92);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(54, 21);
            labelModel.TabIndex = 34;
            labelModel.Text = "Model";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(12, 41);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(473, 29);
            textBoxName.TabIndex = 33;
            // 
            // labelManufacturer
            // 
            labelManufacturer.AutoSize = true;
            labelManufacturer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelManufacturer.Location = new Point(12, 17);
            labelManufacturer.Name = "labelManufacturer";
            labelManufacturer.Size = new Size(112, 21);
            labelManufacturer.TabIndex = 32;
            labelManufacturer.Text = "Název výrobce\r\n";
            // 
            // textBoxMileage
            // 
            textBoxMileage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMileage.Location = new Point(13, 274);
            textBoxMileage.Name = "textBoxMileage";
            textBoxMileage.Size = new Size(473, 29);
            textBoxMileage.TabIndex = 41;
            // 
            // labelMileage
            // 
            labelMileage.AutoSize = true;
            labelMileage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMileage.Location = new Point(13, 250);
            labelMileage.Name = "labelMileage";
            labelMileage.Size = new Size(87, 21);
            labelMileage.TabIndex = 40;
            labelMileage.Text = "Najeto tkm";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.Location = new Point(11, 359);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(473, 29);
            textBoxPrice.TabIndex = 43;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.Location = new Point(11, 335);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(124, 21);
            labelPrice.TabIndex = 42;
            labelPrice.Text = "Cena za den (Kč)\r\n";
            // 
            // btnStorno
            // 
            btnStorno.BackColor = Color.Firebrick;
            btnStorno.FlatAppearance.BorderColor = Color.Black;
            btnStorno.FlatAppearance.BorderSize = 2;
            btnStorno.FlatStyle = FlatStyle.Flat;
            btnStorno.ForeColor = SystemColors.Control;
            btnStorno.Location = new Point(12, 512);
            btnStorno.Name = "btnStorno";
            btnStorno.Size = new Size(134, 54);
            btnStorno.TabIndex = 44;
            btnStorno.Text = "Storno";
            btnStorno.UseVisualStyleBackColor = false;
            btnStorno.Click += btnStorno_Click;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Green;
            btnOk.FlatAppearance.BorderColor = Color.Black;
            btnOk.FlatAppearance.BorderSize = 2;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.ForeColor = SystemColors.Control;
            btnOk.Location = new Point(351, 512);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(134, 54);
            btnOk.TabIndex = 45;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // AddCarDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 578);
            Controls.Add(btnOk);
            Controls.Add(btnStorno);
            Controls.Add(textBoxPrice);
            Controls.Add(labelPrice);
            Controls.Add(textBoxMileage);
            Controls.Add(labelMileage);
            Controls.Add(comboBoxGarages);
            Controls.Add(labelCurrentGarage);
            Controls.Add(textBoxPower);
            Controls.Add(labelPower);
            Controls.Add(textBoxModel);
            Controls.Add(labelModel);
            Controls.Add(textBoxName);
            Controls.Add(labelManufacturer);
            Name = "AddCarDialog";
            Text = "AddCarDialog";
            Load += AddCarDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGarages;
        private Label labelCurrentGarage;
        private TextBox textBoxPower;
        private Label labelPower;
        private TextBox textBoxModel;
        private Label labelModel;
        private TextBox textBoxName;
        private Label labelManufacturer;
        private TextBox textBoxMileage;
        private Label labelMileage;
        private TextBox textBoxPrice;
        private Label labelPrice;
        private Button btnStorno;
        private Button btnOk;
    }
}