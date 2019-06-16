using CMS.TaxiDBDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace CMS
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiDBDataSet.tbl_customers' table. You can move, or remove it, as needed.
            this.tbl_customersTableAdapter.Fill(this.taxiDBDataSet.tbl_customers);
            btn_reload.PerformClick();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            new NewCustomerForm().Visible = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string code = dgv_customer.CurrentRow.Cells[0].Value.ToString();

            string name = dgv_customer.CurrentRow.Cells[1].Value.ToString() + " " +
                          dgv_customer.CurrentRow.Cells[2].Value.ToString();


            CustomMessageBox box = new CustomMessageBox(3, "حذف", name + " حذف شود؟", "بستن");
            var result = box.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbl_customersTableAdapter.Delete1(Convert.ToInt32(code));
            }

            
             
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            tbl_customersTableAdapter adapter = new tbl_customersTableAdapter();
            dgv_customer.DataSource = adapter.GetData();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(dgv_customer.CurrentRow.Cells[0].Value.ToString());
            EditCustomerForm form = new EditCustomerForm(code);
            form.Show();
        }
    }
}
