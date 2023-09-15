namespace CarRentalApp
{
    partial class EditGarageDialog
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
            labelOwnerCompany = new Label();
            labelRegion = new Label();
            textBoxAddress = new TextBox();
            labelAddress = new Label();
            btnStorno = new Button();
            btnOk = new Button();
            SuspendLayout();
            // 
            // comboBoxOwnerCompany
            // 
            comboBoxOwnerCompany.FormattingEnabled = true;
            comboBoxOwnerCompany.Location = new Point(10, 189);
            comboBoxOwnerCompany.Name = "comboBoxOwnerCompany";
            comboBoxOwnerCompany.Size = new Size(474, 23);
            comboBoxOwnerCompany.TabIndex = 42;
            // 
            // comboBoxRegion
            // 
            comboBoxRegion.FormattingEnabled = true;
            comboBoxRegion.Location = new Point(10, 110);
            comboBoxRegion.Name = "comboBoxRegion";
            comboBoxRegion.Size = new Size(473, 23);
            comboBoxRegion.TabIndex = 41;
            // 
            // labelOwnerCompany
            // 
            labelOwnerCompany.AutoSize = true;
            labelOwnerCompany.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOwnerCompany.Location = new Point(10, 165);
            labelOwnerCompany.Name = "labelOwnerCompany";
            labelOwnerCompany.Size = new Size(155, 21);
            labelOwnerCompany.TabIndex = 40;
            labelOwnerCompany.Text = "Společnost (Vlastník)";
            // 
            // labelRegion
            // 
            labelRegion.AutoSize = true;
            labelRegion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegion.Location = new Point(10, 86);
            labelRegion.Name = "labelRegion";
            labelRegion.Size = new Size(59, 21);
            labelRegion.TabIndex = 39;
            labelRegion.Text = "Region";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(10, 35);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(473, 29);
            textBoxAddress.TabIndex = 38;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddress.Location = new Point(10, 12);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(108, 21);
            labelAddress.TabIndex = 37;
            labelAddress.Text = "Adresa garáže\r\n";
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
            btnStorno.TabIndex = 43;
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
            btnOk.Location = new Point(349, 267);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(134, 54);
            btnOk.TabIndex = 44;
            btnOk.Text = "Upravit";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // EditGarageDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 333);
            Controls.Add(btnOk);
            Controls.Add(btnStorno);
            Controls.Add(comboBoxOwnerCompany);
            Controls.Add(comboBoxRegion);
            Controls.Add(labelOwnerCompany);
            Controls.Add(labelRegion);
            Controls.Add(textBoxAddress);
            Controls.Add(labelAddress);
            Name = "EditGarageDialog";
            Text = "EditGarageDialog";
            Load += EditGarageDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxOwnerCompany;
        private ComboBox comboBoxRegion;
        private Label labelOwnerCompany;
        private Label labelRegion;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private Button btnStorno;
        private Button btnOk;
    }
}