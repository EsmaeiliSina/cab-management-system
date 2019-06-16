

namespace CMS
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_username.ForeColor = System.Drawing.Color.Black;
            this.lbl_username.Location = new System.Drawing.Point(715, 49);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(93, 35);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "نام کاربری";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_password.Location = new System.Drawing.Point(729, 98);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(78, 35);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "رمز عبور";
            // 
            // tbx_username
            // 
            this.tbx_username.BackColor = System.Drawing.Color.Gainsboro;
            this.tbx_username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbx_username.Location = new System.Drawing.Point(459, 55);
            this.tbx_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_username.MaxLength = 20;
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_username.Size = new System.Drawing.Size(249, 22);
            this.tbx_username.TabIndex = 0;
            this.tbx_username.TextChanged += new System.EventHandler(this.tbx_username_TextChanged);
            // 
            // tbx_password
            // 
            this.tbx_password.BackColor = System.Drawing.Color.Gainsboro;
            this.tbx_password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbx_password.Location = new System.Drawing.Point(459, 112);
            this.tbx_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_password.MaxLength = 16;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_password.Size = new System.Drawing.Size(249, 22);
            this.tbx_password.TabIndex = 1;
            this.tbx_password.UseSystemPasswordChar = true;
            this.tbx_password.TextChanged += new System.EventHandler(this.tbx_password_TextChanged);
            this.tbx_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_password_KeyPress);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Gold;
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_reset.Location = new System.Drawing.Point(533, 154);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(99, 47);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "پاک کردن";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Gold;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_exit.Location = new System.Drawing.Point(459, 154);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(69, 47);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Gold;
            this.btn_confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_confirm.Location = new System.Drawing.Point(637, 154);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(69, 47);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "ورود";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 484);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سامانه مدیریت تاکسی تلفنی";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_confirm;
    }
}

