namespace CarRentalApp
{
    partial class EditOwnerDialog
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
            textBoxWealth = new TextBox();
            labelWealth = new Label();
            textBoxAge = new TextBox();
            labelAge = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            btnStorno = new Button();
            btnOk = new Button();
            SuspendLayout();
            // 
            // textBoxWealth
            // 
            textBoxWealth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWealth.Location = new Point(10, 191);
            textBoxWealth.Name = "textBoxWealth";
            textBoxWealth.Size = new Size(473, 29);
            textBoxWealth.TabIndex = 33;
            // 
            // labelWealth
            // 
            labelWealth.AutoSize = true;
            labelWealth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelWealth.Location = new Point(10, 167);
            labelWealth.Name = "labelWealth";
            labelWealth.Size = new Size(213, 21);
            labelWealth.TabIndex = 32;
            labelWealth.Text = "Hodnota majetku (v mil. CZK)";
            // 
            // textBoxAge
            // 
            textBoxAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAge.Location = new Point(10, 112);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(473, 29);
            textBoxAge.TabIndex = 31;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAge.Location = new Point(10, 88);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(35, 21);
            labelAge.TabIndex = 30;
            labelAge.Text = "Věk";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(10, 37);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(473, 29);
            textBoxName.TabIndex = 29;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(10, 14);
            labelName.Name = "labelName";
            labelName.Size = new Size(56, 21);
            labelName.TabIndex = 28;
            labelName.Text = "Jméno";
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
            btnStorno.TabIndex = 34;
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
            btnOk.TabIndex = 35;
            btnOk.Text = "Upravit";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // EditOwnerDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 333);
            Controls.Add(btnOk);
            Controls.Add(btnStorno);
            Controls.Add(textBoxWealth);
            Controls.Add(labelWealth);
            Controls.Add(textBoxAge);
            Controls.Add(labelAge);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Name = "EditOwnerDialog";
            Text = "EditOwnerDialog";
            Load += EditOwnerDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxWealth;
        private Label labelWealth;
        private TextBox textBoxAge;
        private Label labelAge;
        private TextBox textBoxName;
        private Label labelName;
        private Button btnStorno;
        private Button btnOk;
    }
}