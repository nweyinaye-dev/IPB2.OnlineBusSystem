using IPB2.OnlineBusSystem.WindowFormApp.Featues.Admin;

namespace IPB2.OnlineBusSystem.WindowFormApp
{
    public partial class MainMaster : Form
    {
        public MainMaster()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();
            adminForm.Show();
            this.Hide();
        }
    }
}
