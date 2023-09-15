namespace CarRentalApp
{
    partial class MainDialog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDialog));
            labelMain = new Label();
            btnCompanyList = new Button();
            btnGarageList = new Button();
            btnCarList = new Button();
            btnOwnersList = new Button();
            btnEndApp = new Button();
            SuspendLayout();
            // 
            // labelMain
            // 
            labelMain.BackColor = Color.Teal;
            labelMain.Dock = DockStyle.Top;
            labelMain.FlatStyle = FlatStyle.Flat;
            labelMain.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMain.ForeColor = SystemColors.Control;
            labelMain.Location = new Point(0, 0);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(621, 79);
            labelMain.TabIndex = 1;
            labelMain.Text = "Informační systém půjčovny aut";
            labelMain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCompanyList
            // 
            btnCompanyList.BackColor = Color.Teal;
            btnCompanyList.Cursor = Cursors.Hand;
            btnCompanyList.FlatAppearance.BorderColor = Color.Black;
            btnCompanyList.FlatAppearance.BorderSize = 2;
            btnCompanyList.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnCompanyList.FlatStyle = FlatStyle.Flat;
            btnCompanyList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompanyList.ForeColor = SystemColors.Control;
            btnCompanyList.Location = new Point(85, 132);
            btnCompanyList.Name = "btnCompanyList";
            btnCompanyList.Size = new Size(466, 55);
            btnCompanyList.TabIndex = 2;
            btnCompanyList.Text = "Seznam firem";
            btnCompanyList.UseVisualStyleBackColor = false;
            btnCompanyList.Click += btnCompanyList_Click;
            // 
            // btnGarageList
            // 
            btnGarageList.BackColor = Color.Teal;
            btnGarageList.Cursor = Cursors.Hand;
            btnGarageList.FlatAppearance.BorderColor = Color.Black;
            btnGarageList.FlatAppearance.BorderSize = 2;
            btnGarageList.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnGarageList.FlatStyle = FlatStyle.Flat;
            btnGarageList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGarageList.ForeColor = SystemColors.Control;
            btnGarageList.Location = new Point(85, 202);
            btnGarageList.Name = "btnGarageList";
            btnGarageList.Size = new Size(466, 55);
            btnGarageList.TabIndex = 3;
            btnGarageList.Text = "Seznam garáží";
            btnGarageList.UseVisualStyleBackColor = false;
            btnGarageList.Click += btnGarageList_Click;
            // 
            // btnCarList
            // 
            btnCarList.BackColor = Color.Teal;
            btnCarList.Cursor = Cursors.Hand;
            btnCarList.FlatAppearance.BorderColor = Color.Black;
            btnCarList.FlatAppearance.BorderSize = 2;
            btnCarList.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnCarList.FlatStyle = FlatStyle.Flat;
            btnCarList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCarList.ForeColor = SystemColors.Control;
            btnCarList.Location = new Point(85, 272);
            btnCarList.Name = "btnCarList";
            btnCarList.Size = new Size(466, 55);
            btnCarList.TabIndex = 4;
            btnCarList.Text = "Seznam automobilů";
            btnCarList.UseVisualStyleBackColor = false;
            btnCarList.Click += btnCarList_Click;
            // 
            // btnOwnersList
            // 
            btnOwnersList.BackColor = Color.Teal;
            btnOwnersList.Cursor = Cursors.Hand;
            btnOwnersList.FlatAppearance.BorderColor = Color.Black;
            btnOwnersList.FlatAppearance.BorderSize = 2;
            btnOwnersList.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnOwnersList.FlatStyle = FlatStyle.Flat;
            btnOwnersList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOwnersList.ForeColor = SystemColors.Control;
            btnOwnersList.Location = new Point(85, 342);
            btnOwnersList.Name = "btnOwnersList";
            btnOwnersList.Size = new Size(466, 55);
            btnOwnersList.TabIndex = 5;
            btnOwnersList.Text = "Seznam vlastníků";
            btnOwnersList.UseVisualStyleBackColor = false;
            btnOwnersList.Click += btnOwnersList_Click;
            // 
            // btnEndApp
            // 
            btnEndApp.BackColor = Color.Teal;
            btnEndApp.Cursor = Cursors.Hand;
            btnEndApp.FlatAppearance.BorderColor = Color.Black;
            btnEndApp.FlatAppearance.BorderSize = 2;
            btnEndApp.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnEndApp.FlatStyle = FlatStyle.Flat;
            btnEndApp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEndApp.ForeColor = SystemColors.Control;
            btnEndApp.Location = new Point(85, 412);
            btnEndApp.Name = "btnEndApp";
            btnEndApp.Size = new Size(466, 55);
            btnEndApp.TabIndex = 6;
            btnEndApp.Text = "Ukončit";
            btnEndApp.UseVisualStyleBackColor = false;
            btnEndApp.Click += btnEndApp_Click;
            // 
            // MainDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(621, 537);
            Controls.Add(btnEndApp);
            Controls.Add(btnOwnersList);
            Controls.Add(btnCarList);
            Controls.Add(btnGarageList);
            Controls.Add(btnCompanyList);
            Controls.Add(labelMain);
            MaximizeBox = false;
            Name = "MainDialog";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label labelMain;
        private Button btnCompanyList;
        private Button btnGarageList;
        private Button btnCarList;
        private Button btnOwnersList;
        private Button btnEndApp;
    }
}