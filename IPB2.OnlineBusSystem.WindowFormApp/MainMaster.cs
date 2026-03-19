using IPB2.OnlineBusSystem.WindowFormApp.Featues.Admin;
using IPB2.OnlineBusSystem.WindowFormApp.Featues.User;

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
        private void btnUser_Click(object sender, EventArgs e)
        {
            User userForm = new User();
            userForm.Show();
            this.Hide();
        }
    }
}
