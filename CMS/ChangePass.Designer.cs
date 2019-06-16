namespace CMS
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_newpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_newpass2 = new System.Windows.Forms.TextBox();
            this.btn_sendservics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_username
            // 
            this.tbx_username.Enabled = false;
            this.tbx_username.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.tbx_username.Location = new System.Drawing.Point(377, 13);
            this.tbx_username.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_username.MaxLength = 6;
            this.tbx_username.Multiline = true;
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_username.Size = new System.Drawing.Size(257, 34);
            this.tbx_username.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(675, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "نام کاربری";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(687, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "رمز فعلی";
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.tbx_password.Location = new System.Drawing.Point(377, 61);
            this.tbx_password.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_password.MaxLength = 6;
            this.tbx_password.Multiline = true;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_password.Size = new System.Drawing.Size(257, 34);
            this.tbx_password.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(683, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "رمز جدید";
            // 
            // tbx_newpass
            // 
            this.tbx_newpass.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.tbx_newpass.Location = new System.Drawing.Point(377, 110);
            this.tbx_newpass.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_newpass.MaxLength = 6;
            this.tbx_newpass.Multiline = true;
            this.tbx_newpass.Name = "tbx_newpass";
            this.tbx_newpass.PasswordChar = '*';
            this.tbx_newpass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_newpass.Size = new System.Drawing.Size(257, 34);
            this.tbx_newpass.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(641, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "تکرار رمز جدید";
            // 
            // tbx_newpass2
            // 
            this.tbx_newpass2.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.tbx_newpass2.Location = new System.Drawing.Point(377, 162);
            this.tbx_newpass2.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_newpass2.MaxLength = 6;
            this.tbx_newpass2.Multiline = true;
            this.tbx_newpass2.Name = "tbx_newpass2";
            this.tbx_newpass2.PasswordChar = '*';
            this.tbx_newpass2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_newpass2.Size = new System.Drawing.Size(257, 34);
            this.tbx_newpass2.TabIndex = 2;
            // 
            // btn_sendservics
            // 
            this.btn_sendservics.Font = new System.Drawing.Font("B Nazanin", 10.2F);
            this.btn_sendservics.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_sendservics.Location = new System.Drawing.Point(449, 204);
            this.btn_sendservics.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sendservics.Name = "btn_sendservics";
            this.btn_sendservics.Size = new System.Drawing.Size(120, 34);
            this.btn_sendservics.TabIndex = 3;
            this.btn_sendservics.Text = "اعمال تغییرات";
            this.btn_sendservics.UseVisualStyleBackColor = true;
            this.btn_sendservics.Click += new System.EventHandler(this.btn_sendservics_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 444);
            this.Controls.Add(this.btn_sendservics);
            this.Controls.Add(this.tbx_newpass2);
            this.Controls.Add(this.tbx_newpass);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePass";
            this.Text = "ChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_newpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_newpass2;
        private System.Windows.Forms.Button btn_sendservics;
    }
}