using CMS.TaxiDBDataSetTableAdapters;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;

namespace CMS
{
    public partial class MainForm : Form    
    {
         private string u = "";
         private string p = "";
         private string i = "";

        public MainForm(string name,string u,string p,string i)

        {
            InitializeComponent();
            lbl_username.Text = name + ".خوش آمدید";

            this.u = u;
            this.p = p;
            this.i = i;
            PersianCalendar pc = new PersianCalendar();
            string startDateFormat = string.Format("{0}/{1}/{2}", pc.GetYear(DateTime.Today), pc.GetMonth(DateTime.Today), pc.GetDayOfMonth(DateTime.Today));

            lbl_date.Text = startDateFormat;
        }




        // create connection with database and fill combobox
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiDBDataSet.tbl_driver' table. You can move, or remove it, as needed.
            this.tbl_driverTableAdapter.Fill(this.taxiDBDataSet.tbl_driver);
            
            
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        // Adding driver
        private void اضافهکردنرانندهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddDriver().Show();
        }


        // close program
        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginForm().Visible = true;
            this.Visible = false;
        }



        // reset the form for new data
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tbx_codeeshtrak.Text = "";
            tbx_name.Text = "";
            tbx_family.Text = "";
            tbx_mabda.Text = "";
            tbx_maghsad.Text = "";
            tbx_phoneNo.Text = "";
            tbx_cost.Text = "";

            //chek_sendservis.Checked = false;

            comb_drivers.SelectedIndex = -1;

            rbtn_eshtrak.Checked = false;
            rbtn_nashnas.Checked = false;
            
        }



        // clear button
        private void button4_Click(object sender, EventArgs e)
        {
            tbx_codeeshtrak.Text = "";
            tbx_name.Text = "";
            tbx_family.Text = "";
            tbx_mabda.Text = "";
            tbx_maghsad.Text = "";
            tbx_phoneNo.Text = "";
            tbx_cost.Text = "";

           // chek_sendservis.Checked = false;

            comb_drivers.SelectedIndex = -1;

            rbtn_eshtrak.Checked = false;
            rbtn_nashnas.Checked = false;
        }



        // nashenas ya eshtraki
        private void rbtn_nashnas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_nashnas.Checked == true)
            {
                tbx_codeeshtrak.Enabled = false;
                btn_search.Enabled = false;
            }
        }


            // check if eshtrak check changed
        private void rbtn_eshtrak_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_eshtrak.Enabled == true)
            {
                tbx_codeeshtrak.Enabled = true;
                btn_search.Enabled = true;
            }
            
        }






            // send button
        private void btn_sendservics_Click(object sender, EventArgs e)
        {

            // all field should be filled in this where we check that
            if ( tbx_mabda.Text.Equals("") || tbx_name.Text.Equals("") ||
                tbx_family.Text.Equals("") || tbx_cost.Text.Equals("")  || tbx_phoneNo.Text.Equals("") ||
                tbx_maghsad.Text.Equals("") || comb_drivers.SelectedIndex == -1)
            {
               //MessageBox.Show(".لطفا اطلاعات را بصورت کامل وارد کنید","اخطار",MessageBoxButtons.OK,MessageBoxIcon.Error);
                CustomMessageBox box = new CustomMessageBox(1, "اخطار", "لطفا اطلاعات را بصورت کامل وارد کنید", "بستن");
               var result = box.ShowDialog();
               if (result == DialogResult.OK)
               {
                   //System.Windows.Forms.Application.Exit();
               }
               
            }
            else
            {

                // create an object from database interface
                tbl_billTableAdapter billinsert = new tbl_billTableAdapter();


                // getting date and convert it to persian/jalali datetime
                PersianCalendar pc = new PersianCalendar();
                DateTime d = DateTime.Now;

                string dateout = string.Format("{0}/{1}/{2}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));
                string timeout = DateTime.Now.ToString("HH:mm:ss");


                // get code eshtrak and driver id
                if (rbtn_eshtrak.Checked)
                {
                    int code = Convert.ToInt16(tbx_codeeshtrak.Text);
                    int driverid = Convert.ToInt32(comb_drivers.SelectedValue.ToString());


                    // add bill to database 
                    billinsert.InsertBill(driverid,
                        code,
                        timeout,
                        dateout,
                        tbx_cost.Text,
                        tbx_mabda.Text,
                        tbx_maghsad.Text);
                    // show succes message
                    //MessageBox.Show("سرویس ارسال شد", "سرویس", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CustomMessageBox box = new CustomMessageBox(4, "سرویس", "سرویس ارسال شد.", "بستن");
                    var result = box.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        //System.Windows.Forms.Application.Exit();
                    }
                    btn_reset.PerformClick();

                    tbx_codeeshtrak.ReadOnly = false;
                    tbx_name.ReadOnly = false;
                    tbx_family.ReadOnly = false;
                    tbx_phoneNo.ReadOnly = false;

                }
                else
                {
                    int driverid = Convert.ToInt32(comb_drivers.SelectedValue.ToString());


                    // add bill to database 
                    billinsert.InsertBill(driverid,
                        8,
                        timeout,
                        dateout,
                        tbx_cost.Text,
                        tbx_mabda.Text,
                        tbx_maghsad.Text);
                    // show succes message
                    CustomMessageBox box = new CustomMessageBox(4, "سرویس", "سرویس ارسال شد.", "بستن");
                    var result = box.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        //System.Windows.Forms.Application.Exit();
                    }

                    btn_reset.PerformClick();

                    tbx_codeeshtrak.ReadOnly = false;
                    tbx_name.ReadOnly = false;
                    tbx_family.ReadOnly = false;
                    tbx_phoneNo.ReadOnly = false;

                    
                }
                

                
            }
            
        }

        private void tbx_cost_KeyPress(object sender, KeyPressEventArgs e)
        {

            // check that price  all be digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbx_phoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {


            // check that tel number all be digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            try
            {
                 // search customer by code eshtrak
                SearchCustomerForm sfc = new SearchCustomerForm();
                sfc.ShowDialog();


                 // set retrived data to form instance
                tbx_codeeshtrak.Text = sfc.Returncode.ToString();
                tbx_name.Text = sfc.returnname.ToString();
                tbx_family.Text = sfc.returnlname.ToString();
                tbx_phoneNo.Text = sfc.returnphone.ToString();

                tbx_codeeshtrak.ReadOnly = true;
                tbx_name.ReadOnly = true;
                tbx_family.ReadOnly = true;
                tbx_phoneNo.ReadOnly = true;
            }
            catch (Exception exception)
            {
                CustomMessageBox box = new CustomMessageBox(2, "پیام", "اشتراکی انتخاب نشد.", "بستن");
                var result = box.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //System.Windows.Forms.Application.Exit();
                }
            }

            

        }

        private void btn_sendandprint_Click(object sender, EventArgs e)
        {

            if (tbx_mabda.Text.Equals("") || tbx_name.Text.Equals("") ||
                tbx_family.Text.Equals("") || tbx_cost.Text.Equals("") || tbx_phoneNo.Text.Equals("") ||
                tbx_maghsad.Text.Equals("") || comb_drivers.SelectedIndex == -1)
            {
                //MessageBox.Show(".لطفا اطلاعات را بصورت کامل وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CustomMessageBox box = new CustomMessageBox(2, "اخطار", "لطفا اطلاعات را بصورت کامل وارد کنید.", "بستن");
                var result = box.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //System.Windows.Forms.Application.Exit();
                }
            }
            else
            {
                

                PrintDialog printDialog = new PrintDialog();

                PrintDocument printDocument = new PrintDocument();

                //add the document to the dialog box...  
                printDialog.Document = printDocument; 
          
                //add an event handler that will do the printing
                printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); 

                DialogResult result = printDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    printDocument.Print();

                }
                btn_sendservics.PerformClick();
            }

            
        }


        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            

            //this prints the reciept

            Graphics graphic = e.Graphics;

            Font font = new Font("B Titr", 18); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();


            graphic.DrawString(" رسید مشتری", font, new SolidBrush(Color.Black), 380, 10);

            graphic.DrawString("_________________________________________________________", font, new SolidBrush(Color.Black), -10, 30);

            string name = "  نام مشتری : ".PadLeft(30) + this.tbx_name.Text + "  " + this.tbx_family.Text;
            graphic.DrawString(name, new Font("B Zar",14), new SolidBrush(Color.Black), 600, 70);

            string driver = "  نام راننده : ".PadLeft(30) + this.comb_drivers.Text;
            graphic.DrawString(driver, new Font("B Zar", 14), new SolidBrush(Color.Black), 450, 70);

            string mabda = "  مبدأ : ".PadLeft(30) + tbx_mabda.Text;
            graphic.DrawString(mabda, new Font("B Zar", 14), new SolidBrush(Color.Black), 300, 70);

            string maghsad = "  مقصد : ".PadLeft(30) + tbx_maghsad.Text;
            graphic.DrawString(maghsad, new Font("B Zar", 14), new SolidBrush(Color.Black), 150, 70);

            string cost = "  هزینه : ".PadLeft(30) + tbx_cost.Text;
            graphic.DrawString(cost, new Font("B Zar", 14), new SolidBrush(Color.Black), 0, 70);

            string nazar = "................................................................................................................" + " : توضیحات";
            graphic.DrawString(nazar, new Font("B Zar", 14), new SolidBrush(Color.Black), 300, 120);

            string sign =  " امضا مشتری";
            graphic.DrawString(sign, new Font("B Zar", 14), new SolidBrush(Color.Black), 40, 120);

            graphic.DrawString("_________________________________________________________", font, new SolidBrush(Color.Black), -10, 150);

            graphic.DrawString(" سامانه مدیریت آژانس",new Font("B Zar", 10,FontStyle.Italic), new SolidBrush(Color.Black), 380, 190);

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            NewCustomerForm customerForm = new NewCustomerForm();
            customerForm.Visible = true;
        }

        private void دربارهیماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().Visible = true;
        }

        private void تماسباماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactUs us = new ContactUs();
            us.Visible = true;
        }

        private void راهنماToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HelpProvider provider = new System.Windows.Forms.HelpProvider();

            
        }

        private void تعدادخروجیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void لیسترانندگانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverForm driverForm = new DriverForm();
            driverForm.Visible = true;
        }

        private void مشترکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCustomerForm form =new SearchCustomerForm();
            form.Visible = true;
        }

        private void لیستمشترکینToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerForm().Visible = true;
        }

        private void رانندهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDriverForm form =new SearchDriverForm();
            form.Visible = true;
        }

        private void راهنماToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Sina\Documents\Visual Studio 2013\Projects\CMS\help.chm");
        }

        private void آمارروزانهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OutReport report = new OutReport();
            report.Visible = true;
        }

        private void تغییررمزعبورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangePass(this.u, this.p,this.i).Show();
        }

    }
}
