namespace CarRentalApp
{
    public partial class MainDialog : Form
    {
        public MainDialog()
        {
            InitializeComponent();
        }

        private void btnCompanyList_Click(object sender, EventArgs e)
        {
            CompanyListDialog companyListDialog = new CompanyListDialog();
            companyListDialog.ShowDialog();
        }

        private void btnCarList_Click(object sender, EventArgs e)
        {
            CarListDialog carListDialog = new CarListDialog();
            carListDialog.ShowDialog();
        }

        private void btnOwnersList_Click(object sender, EventArgs e)
        {
            OwnerListDialog ownerListDialog = new OwnerListDialog();
            ownerListDialog.ShowDialog();
        }

        private void btnEndApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGarageList_Click(object sender, EventArgs e)
        {
            GarageListDialog garageListDialog = new GarageListDialog();
            garageListDialog.ShowDialog();
        }
    }
}