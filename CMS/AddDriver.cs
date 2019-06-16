using CMS.TaxiDBDataSetTableAdapters;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CMS
{
    public partial class AddDriver : Form
    {


        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public AddDriver()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=.;Initial Catalog=TaxiDB;Integrated Security=True";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tbx_driveraddress.Text = "";
            tbx_drivercar.Text = "";
            tbx_drivercode.Text = "";
            tbx_driverlastname.Text = "";
            tbx_drivername.Text = "";
            tbx_driverphone.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_adddriver_Click(object sender, EventArgs e)
        {
            tbl_driverTableAdapter driverTable = new tbl_driverTableAdapter();

            if (tbx_drivername.TextLength == 0 || tbx_driverlastname.TextLength == 0 ||
                tbx_driverphone.TextLength == 0 || tbx_drivercar.TextLength == 0 ||
                tbx_driveraddress.TextLength == 0 || tbx_drivercode.TextLength == 0)
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

                driverTable.InsertDriver(tbx_drivername.Text, tbx_driverlastname.Text, Convert.ToInt64(tbx_drivercode.Text),
                    tbx_driverphone.Text, tbx_driveraddress.Text, tbx_drivercar.Text);

                CustomMessageBox box = new CustomMessageBox(4, "پیام", "راننده جدید با موفقیت اضافه شد.", "بستن");
                var result = box.ShowDialog();
                if (result == DialogResult.OK)
                {
                    btn_reset.PerformClick();
                }
            }
        }

        private void AddDriver_Load(object sender, EventArgs e)
        {

        }

        private void tbx_drivercode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbx_driverphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_lastname_Click(object sender, EventArgs e)
        {

        }

        private void lbl_codemelli_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tel_Click(object sender, EventArgs e)
        {

        }

        private void lbl_car_Click(object sender, EventArgs e)
        {

        }

        private void tbx_drivername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_drivercar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_driverphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_drivercode_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_driverlastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_driveraddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
