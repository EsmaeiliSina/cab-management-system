using CMS.TaxiDBDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace CMS
{
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void NewCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TaxiDBDataSet.tbl_bill' table. You can move, or remove it, as needed.
            this.tbl_billTableAdapter.Fill(this.TaxiDBDataSet.tbl_bill);

            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tbx_clintaddress.ResetText();
            tbx_clintlastname.ResetText();
            tbx_clintname.ResetText();
            tbx_clintphone.ResetText();
        }

        private void tbx_clintphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addclint_Click(object sender, EventArgs e)
        {
            tbl_customersTableAdapter customersTable = new tbl_customersTableAdapter();

            if ( tbx_clintaddress.Text.Equals(String.Empty) || tbx_clintlastname.Text.Equals(String.Empty) ||
                tbx_clintlastname.Text.Equals(String.Empty) || tbx_clintphone.Text.Equals(String.Empty))
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

                customersTable.insertCustomer(tbx_clintname.Text,tbx_clintlastname.Text,tbx_clintphone.Text,tbx_clintaddress.Text);


                CustomMessageBox box = new CustomMessageBox(4, "پیام", "مشترک جدید با موفقیت اضافه شد.", "بستن");
                var result = box.ShowDialog();
                if (result == DialogResult.OK)
                {
                    btn_reset.PerformClick();
                }

            }
        }

    }
}
