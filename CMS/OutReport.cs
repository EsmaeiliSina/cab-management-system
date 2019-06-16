using CMS.TaxiDBDataSetTableAdapters;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace CMS
{
    public partial class OutReport : Form
    {
        public OutReport()
        {
            InitializeComponent();
        }

        private void OutReport_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();

            DateTime startDate = dtp_StartDate.Value.Date;
            DateTime endDate = dtp_EndDate.Value.Date;

            string startDateFormat = string.Format("{0}/{1}/{2}", pc.GetYear(startDate), pc.GetMonth(startDate), pc.GetDayOfMonth(startDate));
            string endDateFormat   = string.Format("{0}/{1}/{2}", pc.GetYear(endDate), pc.GetMonth(endDate), pc.GetDayOfMonth(endDate));

            report_viewTableAdapter adapter = new report_viewTableAdapter();



            dgv_outreport.DataSource = adapter.GetDataBy(startDateFormat, endDateFormat);

            tbx_count.Text = dgv_outreport.Rows.Count.ToString();

            double sum = 0;

            for (int i = 0; i < dgv_outreport.RowCount; i++)
            {
                sum += Convert.ToDouble(dgv_outreport.Rows[i].Cells[5].Value.ToString());
            }

            tbx_totalcost.Text = sum.ToString();

        }

        
    }
}
