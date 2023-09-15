namespace CarRentalApp
{
    partial class AddCompanyDialog
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
            comboBoxOwners = new ComboBox();
            labelOwner = new Label();
            textBoxIncome = new TextBox();
            labelIncome = new Label();
            textBoxNoEmployees = new TextBox();
            labelNoEmployees = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            btnOk = new Button();
            btnStorno = new Button();
            SuspendLayout();
            // 
            // comboBoxOwners
            // 
            comboBoxOwners.FormattingEnabled = true;
            comboBoxOwners.Location = new Point(12, 272);
            comboBoxOwners.Name = "comboBoxOwners";
            comboBoxOwners.Size = new Size(473, 23);
            comboBoxOwners.TabIndex = 29;
            // 
            // labelOwner
            // 
            labelOwner.AutoSize = true;
            labelOwner.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOwner.Location = new Point(11, 248);
            labelOwner.Name = "labelOwner";
            labelOwner.Size = new Size(65, 21);
            labelOwner.TabIndex = 28;
            labelOwner.Text = "Vlastník";
            // 
            // textBoxIncome
            // 
            textBoxIncome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIncome.Location = new Point(12, 187);
            textBoxIncome.Name = "textBoxIncome";
            textBoxIncome.Size = new Size(473, 29);
            textBoxIncome.TabIndex = 27;
            // 
            // labelIncome
            // 
            labelIncome.AutoSize = true;
            labelIncome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIncome.Location = new Point(12, 163);
            labelIncome.Name = "labelIncome";
            labelIncome.Size = new Size(181, 21);
            labelIncome.TabIndex = 26;
            labelIncome.Text = "Roční příjem (v mil. CZK)";
            // 
            // textBoxNoEmployees
            // 
            textBoxNoEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNoEmployees.Location = new Point(12, 108);
            textBoxNoEmployees.Name = "textBoxNoEmployees";
            textBoxNoEmployees.Size = new Size(473, 29);
            textBoxNoEmployees.TabIndex = 25;
            // 
            // labelNoEmployees
            // 
            labelNoEmployees.AutoSize = true;
            labelNoEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNoEmployees.Location = new Point(12, 84);
            labelNoEmployees.Name = "labelNoEmployees";
            labelNoEmployees.Size = new Size(142, 21);
            labelNoEmployees.TabIndex = 24;
            labelNoEmployees.Text = "Počet zaměstnanců";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(12, 33);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(473, 29);
            textBoxName.TabIndex = 23;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(12, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(94, 21);
            labelName.TabIndex = 22;
            labelName.Text = "Název firmy";
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Green;
            btnOk.FlatAppearance.BorderColor = Color.Black;
            btnOk.FlatAppearance.BorderSize = 2;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.ForeColor = SystemColors.Control;
            btnOk.Location = new Point(351, 421);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(134, 54);
            btnOk.TabIndex = 21;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnStorno
            // 
            btnStorno.BackColor = Color.Firebrick;
            btnStorno.FlatAppearance.BorderColor = Color.Black;
            btnStorno.FlatAppearance.BorderSize = 2;
            btnStorno.FlatStyle = FlatStyle.Flat;
            btnStorno.ForeColor = SystemColors.Control;
            btnStorno.Location = new Point(12, 421);
            btnStorno.Name = "btnStorno";
            btnStorno.Size = new Size(134, 54);
            btnStorno.TabIndex = 20;
            btnStorno.Text = "Storno";
            btnStorno.UseVisualStyleBackColor = false;
            btnStorno.Click += btnStorno_Click;
            // 
            // AddCompanyDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(497, 484);
            Controls.Add(comboBoxOwners);
            Controls.Add(labelOwner);
            Controls.Add(textBoxIncome);
            Controls.Add(labelIncome);
            Controls.Add(textBoxNoEmployees);
            Controls.Add(labelNoEmployees);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(btnOk);
            Controls.Add(btnStorno);
            Name = "AddCompanyDialog";
            Text = "AddCompanyDialog";
            Load += AddCompanyDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxOwners;
        private Label labelOwner;
        private TextBox textBoxIncome;
        private Label labelIncome;
        private TextBox textBoxNoEmployees;
        private Label labelNoEmployees;
        private TextBox textBoxName;
        private Label labelName;
        private Button btnOk;
        private Button btnStorno;
    }
}