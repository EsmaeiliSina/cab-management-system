using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class CustomMessageBox : Form
    {
        int code = -1;
        public CustomMessageBox(int code, string title, string body, string btn_text)
        {
            InitializeComponent();
            
            /* 
             * 
             * code 1 ==> error 
             * code 2 ==> warning
             * code 3 ==> YesNo
             * code 4 ==> Success
             * 
             */




              
            this.code = code;
            this.Text = title;
            this.lbl_body.Text = body;
            this.btn_close.Text = btn_text;

            this.CenterToScreen();
            if (this.code == 1)
            {
                this.pictureBox1.Image = Properties.Resources.cancel;
                btn_Yes.Visible = false;
                btn_NO.Visible = false;
            }
            else if(this.code == 2)
            {
                this.pictureBox1.Image = Properties.Resources.round_error_symbol;
                btn_Yes.Visible = false;
                btn_NO.Visible = false;
            }
            else if (this.code == 4)
            {
                this.pictureBox1.Image = Properties.Resources.success;
                btn_Yes.Visible = false;
                btn_NO.Visible = false;
            }
            else
            {
                this.pictureBox1.Image = Properties.Resources.manthinking;
                btn_close.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.Visible = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lbl_body_Click(object sender, EventArgs e)
        {

        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
