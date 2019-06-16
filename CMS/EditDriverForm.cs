using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMS
{
    public partial class EditDriverForm : Form
    {
        int code = 0;

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();


        public EditDriverForm(int code)
        {
            InitializeComponent();
            this.code = code;
            con.ConnectionString = @"Data Source=.;Initial Catalog=TaxiDB;Integrated Security=True";
            

            com.CommandText = "SELECT * FROM dbo.tbl_driver where driver_id=" + this.code.ToString();
            con.Open();
            com.Connection = con;
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();


            tbx_drivercode.Text = dr["driver_codemelli"].ToString();
            tbx_drivercar.Text = dr["diver_car"].ToString();
            tbx_driveraddress.Text = dr["driver_address"].ToString();
            tbx_driverlastname.Text = dr["driver_lname"].ToString();
            tbx_drivername.Text = dr["driver_fname"].ToString();
            tbx_driverphone.Text = dr["driver_tel"].ToString();

            con.Close();
        }

        private void btn_editdriver_Click(object sender, EventArgs e)
        {



            string name = tbx_drivername.Text + " " + tbx_driverlastname.Text;

            CustomMessageBox box = new CustomMessageBox(3, "ویرایش", name + " ویرایش شود؟", "بستن");
            var result = box.ShowDialog();
            if (result == DialogResult.OK)
            {
                com.CommandText = "UPDATE dbo.tbl_driver SET driver_codemelli=N'" + tbx_drivercode.Text
                                                                                  + "', diver_car=N'" + tbx_drivercar.Text + "', driver_address=N'" + tbx_driveraddress.Text
                                                                                  + "', driver_lname=N'" + tbx_driverlastname.Text + "', driver_fname=N'" + tbx_drivername.Text
                                                                                  + "', driver_tel=N'" + tbx_driverphone.Text + "' WHERE driver_id=" + this.code.ToString();
                con.Open();
                com.Connection = con;
                com.ExecuteNonQuery();
                con.Close();
            }

            
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

        private void EditDriverForm_Load(object sender, EventArgs e)
        {

        }
    }
}
