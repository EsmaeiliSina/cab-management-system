using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using CMS.TaxiDBDataSetTableAdapters;

namespace CMS
{
    public partial class ChangePass : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        private string u = "";
        private string p = "";
        private string i = "";
        public ChangePass(string u, string p,string i)
        {
            InitializeComponent();
            tbx_username.Text = u;
            this.p = p;
            this.u = u;
            this.i = i;
        }

        private void btn_sendservics_Click(object sender, EventArgs e)
        {
            if (tbx_newpass.Text == tbx_newpass2.Text)
            {
                if (tbx_password.Text == this.p)
                {
                    tbl_usersTableAdapter adapter =new tbl_usersTableAdapter();
                    adapter.UpdateQuery(tbx_newpass.Text.ToString(), Convert.ToInt32(this.i));

                    CustomMessageBox box = new CustomMessageBox(4, "پیام", "رمز عبور با موفقیت تغییر یافت.", "بستن");
                    var result = box.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        //System.Windows.Forms.Application.Exit();
                    }

                }
                else
                {
                    CustomMessageBox box = new CustomMessageBox(1, "اخطار", "رمز عبور فعلی نادرست است.", "بستن");
                    var result = box.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        //System.Windows.Forms.Application.Exit();
                    }
                }
            }
            else
            {
                CustomMessageBox box = new CustomMessageBox(1, "اخطار", "رمز عبور جدید مطابقت ندارد.", "بستن");
                var result = box.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //System.Windows.Forms.Application.Exit();
                }
            }
        }
    }
}
