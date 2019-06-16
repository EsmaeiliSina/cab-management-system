using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CMS
{
    public partial class SearchDriverForm : Form
    {

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public SearchDriverForm()
        {
            InitializeComponent();

            conn.ConnectionString = @"Data Source=.;Initial Catalog=TaxiDB;Integrated Security=True";
            conn.Open();

            dgv_drivers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_drivers.DefaultCellStyle.Font = new Font("B nazanin", 11);
            dgv_drivers.ColumnHeadersDefaultCellStyle.Font = new Font("B nazanin", 11, FontStyle.Bold);
            dgv_drivers.ColumnHeadersHeight = 35;

            cmb_searchbase.SelectedIndex = 0;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            

            string searchbase = "", searchfor = "";

            switch (cmb_searchbase.SelectedIndex)
            {
                case 0:
                    searchbase = "driver_id";
                    break;
                case 1:
                    searchbase = "driver_fname";
                    break;
                case 2:
                    searchbase = "driver_lname";
                    break;
                case 3:
                    searchbase = "driver_tel";
                    break;
                case 4:
                    searchbase = "driver_codemelli";
                    break;
                case 5:
                    searchbase = "driver_car";
                    break;
                case 6:
                    searchbase = "driver_tel";
                    break;
                case 7:
                    searchbase = "driver_address";
                    break;
            }

            searchfor = String.Format("N'%{0}%'", tbx_searchfor.Text);


            cmd.CommandText = string.Format("select * from tbl_driver where {0} like {1} ", searchbase, searchfor);


            // fill data grid view with customer table data
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            ds.Clear();
            da.Fill(ds, "tbl_driver");
            dgv_drivers.DataBindings.Clear();
            dgv_drivers.DataBindings.Add("datasource", ds, "tbl_driver");
        }

        private void SearchDriverForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiDBDataSet.tbl_driver' table. You can move, or remove it, as needed.
            this.tbl_driverTableAdapter.Fill(this.taxiDBDataSet.tbl_driver);

        }

        private void tbx_searchfor_TextChanged(object sender, EventArgs e)
        {
            btn_search.PerformClick();
        }
    }
}
