using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CMS
{
    public partial class LoginForm : Form
    {

        // connect sql server 
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        private int counter = 0;
        public LoginForm()
        {
            InitializeComponent();

            // set connection string
            con.ConnectionString = @"Data Source=.;Initial Catalog=TaxiDB;Integrated Security=True";
            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomMessageBox box = new CustomMessageBox(3,"خروج","آیا میخواهید از برنامه خارج شوید؟"," ");
            var result = box.ShowDialog();
            if (result == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // reset username and password
            tbx_username.ResetText();
            tbx_password.ResetText();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            // disable btn_confirm and btn_reset when form just loaded
            btn_confirm.Enabled = false;
            btn_reset.Enabled = false;
        }

        private void tbx_username_TextChanged(object sender, EventArgs e)
        {
            // if username text changed enable reset button
            btn_reset.Enabled = true;
        }

        private void tbx_password_TextChanged(object sender, EventArgs e)

        // check if change username equals to "" disable confirm button and vise versa
        {
            if (tbx_username.Text.Equals(""))
            {
                btn_confirm.Enabled = false;
            }
            else
            {
                btn_confirm.Enabled = true;
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                // set counter to prevent more than 5 wrong attempt to login
                // and show apporiate message
                counter++;
                if (counter > 5)
                {
                    CustomMessageBox box = new CustomMessageBox(1, "اخطار",
                        ".تعداد دفعات ورود غیر مجاز بیش از حد مجاز میباشد ", "بستن");
                    var res = box.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }
                // open sql connection
                //con.Open();
                com.Connection = con;

                // raw sql query
                com.CommandText = "select * from tbl_users";

                // read data from database
                //SqlDataReader dr = com.ExecuteReader();


                // if username and password is correct login the user
                // else show correct message

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                bool log = false;

                foreach (DataRow dr in dt.Rows)
                {
                    if (tbx_username.Text.Equals(dr["username"].ToString()) && tbx_password.Text.Equals(dr["password"].ToString()))
                    {
                        if (dr["admin"].Equals(false))
                        {
                            log = true;
                            string name = dr["firstname"].ToString() + " " + dr["lastname"].ToString();
                            MainForm mainform = new MainForm(name,dr["username"].ToString(),dr["password"].ToString(),dr["id"].ToString());
                            mainform.Show();
                            this.Visible = false;
                            return;
                        }
                        else if(dr["admin"].Equals(true))
                        {
                            log = true;
                            ManagerForm form = new ManagerForm();
                            form.Show();
                            this.Visible = false;
                        }
                    }

                    
                    
                }

                if (log == false)
                {
                    CustomMessageBox box = new CustomMessageBox(2, "اخطار",
                        ".نام کاربری یا رمز عبور خود را اشتباه وارد کرده اید ", "بستن");
                    box.ShowDialog();

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }


        // if enter key pressed login the user
        private void tbx_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 )
            {
                this.btn_confirm.PerformClick();
            }
        }

        
    }
}
