using CMS.TaxiDBDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace CMS
{
    public partial class AddSecretry : Form
    {
        public AddSecretry()
        {
            InitializeComponent();
            rbtn_secretry.Checked = true;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tbx_username.ResetText();
            tbx_password.ResetText();
            tbx_secretrylastname.ResetText();
            tbx_secretryname.ResetText();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addclint_Click(object sender, EventArgs e)
        {
            tbl_usersTableAdapter adapter = new tbl_usersTableAdapter();

            bool admin = true;

            if (rbtn_admin.Checked)
            {
                admin = true;
            }
            else
            {
                admin = false;
            }
    

            if ( tbx_secretryname.Text.Equals(String.Empty) || tbx_secretrylastname.Text.Equals(String.Empty) ||
                 tbx_username.Text.Equals(String.Empty) || tbx_password.Text.Equals(String.Empty))
            {
                CustomMessageBox box = new CustomMessageBox(1, "اخطار", "لطفا اطلاعات را بصورت کامل وارد کنید", "بستن");
                var result = box.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //System.Windows.Forms.Application.Exit();
                }
            }
            else
            {

                adapter.Insert(tbx_username.Text,
                    tbx_password.Text,
                    tbx_secretryname.Text,
                    tbx_secretrylastname.Text,
                    admin);

                CustomMessageBox box = new CustomMessageBox(4, "پیام", "کارمند جدید با موفقیت اضافه شد.", "بستن");
                var result = box.ShowDialog();
                if (result == DialogResult.OK)
                {
                    btn_reset.PerformClick();
                }
            }
        }
    }
}
