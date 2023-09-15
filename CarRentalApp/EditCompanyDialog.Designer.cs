namespace CarRentalApp
{
    partial class EditCompanyDialog
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
            btnStorno = new Button();
            btnOk = new Button();
            SuspendLayout();
            // 
            // comboBoxOwners
            // 
            comboBoxOwners.FormattingEnabled = true;
            comboBoxOwners.Location = new Point(11, 271);
            comboBoxOwners.Name = "comboBoxOwners";
            comboBoxOwners.Size = new Size(473, 23);
            comboBoxOwners.TabIndex = 27;
            // 
            // labelOwner
            // 
            labelOwner.AutoSize = true;
            labelOwner.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOwner.Location = new Point(10, 247);
            labelOwner.Name = "labelOwner";
            labelOwner.Size = new Size(65, 21);
            labelOwner.TabIndex = 26;
            labelOwner.Text = "Vlastník";
            // 
            // textBoxIncome
            // 
            textBoxIncome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIncome.Location = new Point(10, 192);
            textBoxIncome.Name = "textBoxIncome";
            textBoxIncome.Size = new Size(473, 29);
            textBoxIncome.TabIndex = 25;
            // 
            // labelIncome
            // 
            labelIncome.AutoSize = true;
            labelIncome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIncome.Location = new Point(10, 168);
            labelIncome.Name = "labelIncome";
            labelIncome.Size = new Size(181, 21);
            labelIncome.TabIndex = 24;
            labelIncome.Text = "Roční příjem (v mil. CZK)";
            // 
            // textBoxNoEmployees
            // 
            textBoxNoEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNoEmployees.Location = new Point(10, 113);
            textBoxNoEmployees.Name = "textBoxNoEmployees";
            textBoxNoEmployees.Size = new Size(473, 29);
            textBoxNoEmployees.TabIndex = 23;
            // 
            // labelNoEmployees
            // 
            labelNoEmployees.AutoSize = true;
            labelNoEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNoEmployees.Location = new Point(10, 89);
            labelNoEmployees.Name = "labelNoEmployees";
            labelNoEmployees.Size = new Size(142, 21);
            labelNoEmployees.TabIndex = 22;
            labelNoEmployees.Text = "Počet zaměstnanců";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(10, 38);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(473, 29);
            textBoxName.TabIndex = 21;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(10, 15);
            labelName.Name = "labelName";
            labelName.Size = new Size(94, 21);
            labelName.TabIndex = 20;
            labelName.Text = "Název firmy";
            // 
            // btnStorno
            // 
            btnStorno.BackColor = Color.Firebrick;
            btnStorno.FlatAppearance.BorderColor = Color.Black;
            btnStorno.FlatAppearance.BorderSize = 2;
            btnStorno.FlatStyle = FlatStyle.Flat;
            btnStorno.ForeColor = SystemColors.Control;
            btnStorno.Location = new Point(12, 400);
            btnStorno.Name = "btnStorno";
            btnStorno.Size = new Size(134, 54);
            btnStorno.TabIndex = 35;
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
            btnOk.Location = new Point(349, 400);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(134, 54);
            btnOk.TabIndex = 36;
            btnOk.Text = "Upravit";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // EditCompanyDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 466);
            Controls.Add(btnOk);
            Controls.Add(btnStorno);
            Controls.Add(comboBoxOwners);
            Controls.Add(labelOwner);
            Controls.Add(textBoxIncome);
            Controls.Add(labelIncome);
            Controls.Add(textBoxNoEmployees);
            Controls.Add(labelNoEmployees);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Name = "EditCompanyDialog";
            Text = "EditCompanyDialog";
            Load += EditCompanyDialog_Load;
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
        private Button btnStorno;
        private Button btnOk;
    }
}