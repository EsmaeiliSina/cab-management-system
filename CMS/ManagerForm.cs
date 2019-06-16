using System;
using System.Windows.Forms;

namespace CMS
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void btn_customerlist_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.Show();
        }

        private void btn_driverlist_Click(object sender, EventArgs e)
        {
            DriverForm form = new DriverForm();
            form.Show();
        }

        private void Btn_report_Click(object sender, EventArgs e)
        {
            OutReport report =new OutReport();
            report.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new LoginForm().Show();
        }

        private void btn_newsecretry_Click(object sender, EventArgs e)
        {
            new AddSecretry().Show();
        }
    }
}
