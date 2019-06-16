using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMS
{
    public partial class EditCustomerForm : Form
    {

        int code = 0;

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();


        public EditCustomerForm(int code)
        {
            InitializeComponent();
            this.code = code;
            con.ConnectionString = @"Data Source=.;Initial Catalog=TaxiDB;Integrated Security=True";


            com.CommandText = "SELECT * FROM dbo.tbl_customers where customer_id=" + this.code.ToString();
            con.Open();
            com.Connection = con;
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();

            tbx_clintname.Text = dr["customer_fname"].ToString();
            tbx_clintlastname.Text = dr["customer_lname"].ToString();
            tbx_clintphone.Text = dr["customer_tel"].ToString();
            tbx_clintaddress.Text = dr["customer_address"].ToString();

            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tbx_clintaddress.ResetText();
            tbx_clintlastname.ResetText();
            tbx_clintname.ResetText();
            tbx_clintphone.ResetText();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editcustomer_Click(object sender, EventArgs e)
        {

            string name = tbx_clintname.Text + " " + tbx_clintlastname.Text;


            CustomMessageBox box = new CustomMessageBox(3, "ویرایش", name + " ویرایش شود؟", "بستن");
            var result = box.ShowDialog();
            if (result == DialogResult.OK)
            {
                com.CommandText = "UPDATE dbo.tbl_customers SET customer_fname=N'" + tbx_clintname.Text
                                                                                   + "', customer_lname=N'" + tbx_clintlastname.Text + "', customer_address=N'" + tbx_clintaddress.Text
                                                                                   + "', customer_tel=N'" + tbx_clintphone.Text + "' WHERE customer_id=" + this.code.ToString();
                con.Open();
                com.Connection = con;
                com.ExecuteNonQuery();
                con.Close();
            }

        }
    }
}
