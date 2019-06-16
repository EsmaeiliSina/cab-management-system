namespace CMS
{
    partial class EditDriverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDriverForm));
            this.btn_editdriver = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.tbx_driveraddress = new System.Windows.Forms.TextBox();
            this.tbx_driverlastname = new System.Windows.Forms.TextBox();
            this.tbx_drivercode = new System.Windows.Forms.TextBox();
            this.tbx_driverphone = new System.Windows.Forms.TextBox();
            this.tbx_drivercar = new System.Windows.Forms.TextBox();
            this.tbx_drivername = new System.Windows.Forms.TextBox();
            this.lbl_car = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_codemelli = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_editdriver
            // 
            this.btn_editdriver.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_editdriver.Location = new System.Drawing.Point(325, 243);
            this.btn_editdriver.Name = "btn_editdriver";
            this.btn_editdriver.Size = new System.Drawing.Size(109, 30);
            this.btn_editdriver.TabIndex = 21;
            this.btn_editdriver.Text = "ویرایش";
            this.btn_editdriver.UseVisualStyleBackColor = true;
            this.btn_editdriver.Click += new System.EventHandler(this.btn_editdriver_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_reset.Location = new System.Drawing.Point(210, 243);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(109, 30);
            this.btn_reset.TabIndex = 23;
            this.btn_reset.Text = "پاک کردن";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_back.Location = new System.Drawing.Point(91, 243);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(113, 30);
            this.btn_back.TabIndex = 24;
            this.btn_back.Text = "بازگشت";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tbx_driveraddress
            // 
            this.tbx_driveraddress.Font = new System.Drawing.Font("B Nazanin", 10.2F);
            this.tbx_driveraddress.Location = new System.Drawing.Point(10, 141);
            this.tbx_driveraddress.Multiline = true;
            this.tbx_driveraddress.Name = "tbx_driveraddress";
            this.tbx_driveraddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_driveraddress.Size = new System.Drawing.Size(180, 57);
            this.tbx_driveraddress.TabIndex = 19;
            // 
            // tbx_driverlastname
            // 
            this.tbx_driverlastname.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_driverlastname.Location = new System.Drawing.Point(10, 67);
            this.tbx_driverlastname.Name = "tbx_driverlastname";
            this.tbx_driverlastname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_driverlastname.Size = new System.Drawing.Size(180, 28);
            this.tbx_driverlastname.TabIndex = 11;
            // 
            // tbx_drivercode
            // 
            this.tbx_drivercode.Font = new System.Drawing.Font("B Nazanin", 10.2F);
            this.tbx_drivercode.Location = new System.Drawing.Point(283, 102);
            this.tbx_drivercode.MaxLength = 11;
            this.tbx_drivercode.Name = "tbx_drivercode";
            this.tbx_drivercode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_drivercode.Size = new System.Drawing.Size(180, 28);
            this.tbx_drivercode.TabIndex = 13;
            // 
            // tbx_driverphone
            // 
            this.tbx_driverphone.Font = new System.Drawing.Font("B Nazanin", 10.2F);
            this.tbx_driverphone.Location = new System.Drawing.Point(10, 104);
            this.tbx_driverphone.MaxLength = 15;
            this.tbx_driverphone.Name = "tbx_driverphone";
            this.tbx_driverphone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_driverphone.Size = new System.Drawing.Size(180, 28);
            this.tbx_driverphone.TabIndex = 15;
            // 
            // tbx_drivercar
            // 
            this.tbx_drivercar.Font = new System.Drawing.Font("B Nazanin", 10.2F);
            this.tbx_drivercar.Location = new System.Drawing.Point(283, 141);
            this.tbx_drivercar.Name = "tbx_drivercar";
            this.tbx_drivercar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_drivercar.Size = new System.Drawing.Size(180, 28);
            this.tbx_drivercar.TabIndex = 17;
            // 
            // tbx_drivername
            // 
            this.tbx_drivername.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_drivername.Location = new System.Drawing.Point(283, 64);
            this.tbx_drivername.Name = "tbx_drivername";
            this.tbx_drivername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_drivername.Size = new System.Drawing.Size(180, 28);
            this.tbx_drivername.TabIndex = 9;
            // 
            // lbl_car
            // 
            this.lbl_car.AutoSize = true;
            this.lbl_car.BackColor = System.Drawing.Color.Transparent;
            this.lbl_car.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.lbl_car.Location = new System.Drawing.Point(470, 138);
            this.lbl_car.Name = "lbl_car";
            this.lbl_car.Size = new System.Drawing.Size(50, 28);
            this.lbl_car.TabIndex = 22;
            this.lbl_car.Text = "ماشین";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tel.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.lbl_tel.Location = new System.Drawing.Point(197, 101);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(77, 28);
            this.lbl_tel.TabIndex = 20;
            this.lbl_tel.Text = "شماره تلفن";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.label5.Location = new System.Drawing.Point(228, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "آدرس";
            // 
            // lbl_codemelli
            // 
            this.lbl_codemelli.AutoSize = true;
            this.lbl_codemelli.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codemelli.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.lbl_codemelli.Location = new System.Drawing.Point(464, 100);
            this.lbl_codemelli.Name = "lbl_codemelli";
            this.lbl_codemelli.Size = new System.Drawing.Size(55, 28);
            this.lbl_codemelli.TabIndex = 16;
            this.lbl_codemelli.Text = "کد ملی";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lastname.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.lbl_lastname.Location = new System.Drawing.Point(190, 64);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(85, 28);
            this.lbl_lastname.TabIndex = 14;
            this.lbl_lastname.Text = "نام خانوادگی";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.lbl_name.Location = new System.Drawing.Point(490, 62);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(27, 28);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Text = "نام";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "مشخصات راننده";
            // 
            // EditDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 282);
            this.Controls.Add(this.btn_editdriver);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tbx_driveraddress);
            this.Controls.Add(this.tbx_driverlastname);
            this.Controls.Add(this.tbx_drivercode);
            this.Controls.Add(this.tbx_driverphone);
            this.Controls.Add(this.tbx_drivercar);
            this.Controls.Add(this.tbx_drivername);
            this.Controls.Add(this.lbl_car);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_codemelli);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "EditDriverForm";
            this.Text = "ویرایش راننده";
            this.Load += new System.EventHandler(this.EditDriverForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editdriver;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox tbx_driveraddress;
        private System.Windows.Forms.TextBox tbx_driverlastname;
        private System.Windows.Forms.TextBox tbx_drivercode;
        private System.Windows.Forms.TextBox tbx_driverphone;
        private System.Windows.Forms.TextBox tbx_drivercar;
        private System.Windows.Forms.TextBox tbx_drivername;
        private System.Windows.Forms.Label lbl_car;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_codemelli;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
    }
}