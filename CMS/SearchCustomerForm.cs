using CMS.TaxiDBDataSetTableAdapters;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CMS
{
    public partial class SearchCustomerForm : Form
    {

        // database connection stuff

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public SearchCustomerForm()
        {
            InitializeComponent();
            cmb_searchbase.SelectedIndex = 0;
        }
        
        

        private void SearchCustomerForm_Load(object sender, EventArgs e)
        {
            


            // fill the table with customer data from database
            this.tbl_customersTableAdapter.Fill(this.taxiDBDataSet.tbl_customers);
            

            // set connection string
            conn.ConnectionString = @"Data Source=.;Initial Catalog=TaxiDB;Integrated Security=True";
            conn.Open();

            // font and alignment and other styles
            dgv_clinets.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_clinets.DefaultCellStyle.Font = new Font("B nazanin",11);
            dgv_clinets.ColumnHeadersDefaultCellStyle.Font = new Font("B nazanin", 11,FontStyle.Bold);
            dgv_clinets.ColumnHeadersHeight = 35;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create an object from database tool
            tbl_customersTableAdapter customersTable = new tbl_customersTableAdapter();


            string searchbase = "", searchfor = "";


            // TODO: search with other information in future
            switch (cmb_searchbase.SelectedIndex)
            {
                case 0:
                    searchbase = "customer_id";
                    break;
                case 1:
                    searchbase = "customer_fname";
                    break;
                case 2:
                    searchbase = "customer_lname";
                    break;
                case 3:
                    searchbase = "customer_tel";
                    break;
                case 4:
                    searchbase = "customer_address";
                    break;
            }

            searchfor = String.Format("N'%{0}%'",tbx_searchfor.Text);

            // select chosen customer
            cmd.CommandText = string.Format("select * from tbl_customers where {0} like {1} ",searchbase,searchfor);
            


            
            // fill data grid view with customer table data
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            ds.Clear();
            da.Fill(ds, "tbl_customers");
            dgv_clinets.DataBindings.Clear();
            dgv_clinets.DataBindings.Add("datasource", ds, "tbl_customers");

        }

        private void tbx_searchfor_TextChanged(object sender, EventArgs e)
        {
            btn_search.PerformClick();
        }

        public string Returncode { get; set; }
        public string returnname { get; set; }
        public string returnlname { get; set; }
        public string returnphone { get; set; }

        private void dgv_clinets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

           CustomMessageBox box = new CustomMessageBox(3, "اشتراک", dgv_clinets.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dgv_clinets.Rows[e.RowIndex].Cells[2].Value.ToString() + " : مشترک انتخاب شده ", "بستن");

           var ok = box.ShowDialog();

           if (ok == DialogResult.OK)
           {
               this.Returncode = dgv_clinets.Rows[e.RowIndex].Cells[0].Value.ToString();
               this.returnname = dgv_clinets.Rows[e.RowIndex].Cells[1].Value.ToString();
               this.returnlname = dgv_clinets.Rows[e.RowIndex].Cells[2].Value.ToString();
               this.returnphone = dgv_clinets.Rows[e.RowIndex].Cells[3].Value.ToString();
               this.Close();
           }
           else
           {
               this.Returncode = " ";
               this.returnname = " ";
               this.returnlname = " ";
               this.returnphone = " ";
           }
        }

        private void SearchCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
            
        }

        private void dgv_clinets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_searchbase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
