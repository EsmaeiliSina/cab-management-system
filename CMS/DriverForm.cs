using CMS.TaxiDBDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace CMS
{
    public partial class DriverForm : Form
    {
        public DriverForm()
        {
            InitializeComponent();
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiDBDataSet1.tbl_driver' table. You can move, or remove it, as needed.
            this.tbl_driverTableAdapter.Fill(this.taxiDBDataSet1.tbl_driver);
            // TODO: This line of code loads data into the 'taxiDBDataSet.tbl_driver' table. You can move, or remove it, as needed.
            this.tbl_driverTableAdapter.Fill(this.taxiDBDataSet.tbl_driver);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDriver addDriver = new AddDriver();
            addDriver.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string code = dgv_Driver.CurrentRow.Cells[0].Value.ToString();

            string name = dgv_Driver.CurrentRow.Cells[1].Value.ToString() + " " +
                          dgv_Driver.CurrentRow.Cells[2].Value.ToString();


            CustomMessageBox box = new CustomMessageBox(3, "حذف", name + " حذف شود؟", "بستن");
            var result = box.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbl_driverTableAdapter.Delete1(Convert.ToInt32(code));
            }
            
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            tbl_driverTableAdapter adapter = new tbl_driverTableAdapter();
            dgv_Driver.DataSource = adapter.GetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(dgv_Driver.CurrentRow.Cells[0].Value.ToString());
            EditDriverForm form = new EditDriverForm(code);
            form.Show();
        }
    }
}
