namespace CarRentalApp
{
    partial class AddGarageDialog
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
            comboBoxOwnerCompany = new ComboBox();
            comboBoxRegion = new ComboBox();
            labelRegion = new Label();
            labelOwnerCompany = new Label();
            textBoxAddress = new TextBox();
            labelName = new Label();
            btnStorno = new Button();
            btnOk = new Button();
            SuspendLayout();
            // 
            // comboBoxOwnerCompany
            // 
            comboBoxOwnerCompany.FormattingEnabled = true;
            comboBoxOwnerCompany.Location = new Point(12, 176);
            comboBoxOwnerCompany.Name = "comboBoxOwnerCompany";
            comboBoxOwnerCompany.Size = new Size(473, 23);
            comboBoxOwnerCompany.TabIndex = 38;
            // 
            // comboBoxRegion
            // 
            comboBoxRegion.FormattingEnabled = true;
            comboBoxRegion.Location = new Point(12, 107);
            comboBoxRegion.Name = "comboBoxRegion";
            comboBoxRegion.Size = new Size(473, 23);
            comboBoxRegion.TabIndex = 37;
            // 
            // labelRegion
            // 
            labelRegion.AutoSize = true;
            labelRegion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegion.Location = new Point(11, 83);
            labelRegion.Name = "labelRegion";
            labelRegion.Size = new Size(59, 21);
            labelRegion.TabIndex = 36;
            labelRegion.Text = "Region";
            // 
            // labelOwnerCompany
            // 
            labelOwnerCompany.AutoSize = true;
            labelOwnerCompany.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOwnerCompany.Location = new Point(12, 152);
            labelOwnerCompany.Name = "labelOwnerCompany";
            labelOwnerCompany.Size = new Size(155, 21);
            labelOwnerCompany.TabIndex = 35;
            labelOwnerCompany.Text = "Společnost (Vlastník)";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(12, 38);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(473, 29);
            textBoxAddress.TabIndex = 34;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(12, 14);
            labelName.Name = "labelName";
            labelName.Size = new Size(108, 21);
            labelName.TabIndex = 33;
            labelName.Text = "Adresa garáže\r\n";
            // 
            // btnStorno
            // 
            btnStorno.BackColor = Color.Firebrick;
            btnStorno.FlatAppearance.BorderColor = Color.Black;
            btnStorno.FlatAppearance.BorderSize = 2;
            btnStorno.FlatStyle = FlatStyle.Flat;
            btnStorno.ForeColor = SystemColors.Control;
            btnStorno.Location = new Point(12, 267);
            btnStorno.Name = "btnStorno";
            btnStorno.Size = new Size(134, 54);
            btnStorno.TabIndex = 39;
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
            btnOk.Location = new Point(351, 267);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(134, 54);
            btnOk.TabIndex = 40;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // AddGarageDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 333);
            Controls.Add(btnOk);
            Controls.Add(btnStorno);
            Controls.Add(comboBoxOwnerCompany);
            Controls.Add(comboBoxRegion);
            Controls.Add(labelRegion);
            Controls.Add(labelOwnerCompany);
            Controls.Add(textBoxAddress);
            Controls.Add(labelName);
            Name = "AddGarageDialog";
            Text = "AddGarageDialog";
            Load += AddGarageDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxOwnerCompany;
        private ComboBox comboBoxRegion;
        private Label labelRegion;
        private Label labelOwnerCompany;
        private TextBox textBoxAddress;
        private Label labelName;
        private Button btnStorno;
        private Button btnOk;
    }
}