namespace CMS
{
    partial class AddDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDriver));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_codemelli = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_car = new System.Windows.Forms.Label();
            this.tbx_drivername = new System.Windows.Forms.TextBox();
            this.tbx_drivercar = new System.Windows.Forms.TextBox();
            this.tbx_driverphone = new System.Windows.Forms.TextBox();
            this.tbx_drivercode = new System.Windows.Forms.TextBox();
            this.tbx_driverlastname = new System.Windows.Forms.TextBox();
            this.tbx_driveraddress = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_adddriver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(497, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "مشخصات راننده";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.lbl_name.Location = new System.Drawing.Point(654, 72);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 35);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "نام";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lastname.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.lbl_lastname.Location = new System.Drawing.Point(254, 75);
            this.lbl_lastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(109, 35);
            this.lbl_lastname.TabIndex = 2;
            this.lbl_lastname.Text = "نام خانوادگی";
            this.lbl_lastname.Click += new System.EventHandler(this.lbl_lastname_Click);
            // 
            // lbl_codemelli
            // 
            this.lbl_codemelli.AutoSize = true;
            this.lbl_codemelli.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codemelli.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.lbl_codemelli.Location = new System.Drawing.Point(619, 119);
            this.lbl_codemelli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codemelli.Name = "lbl_codemelli";
            this.lbl_codemelli.Size = new System.Drawing.Size(70, 35);
            this.lbl_codemelli.TabIndex = 3;
            this.lbl_codemelli.Text = "کد ملی";
            this.lbl_codemelli.Click += new System.EventHandler(this.lbl_codemelli_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.label5.Location = new System.Drawing.Point(304, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "آدرس";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tel.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.lbl_tel.Location = new System.Drawing.Point(263, 120);
            this.lbl_tel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(100, 35);
            this.lbl_tel.TabIndex = 5;
            this.lbl_tel.Text = "شماره تلفن";
            this.lbl_tel.Click += new System.EventHandler(this.lbl_tel_Click);
            // 
            // lbl_car
            // 
            this.lbl_car.AutoSize = true;
            this.lbl_car.BackColor = System.Drawing.Color.Transparent;
            this.lbl_car.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.lbl_car.Location = new System.Drawing.Point(626, 166);
            this.lbl_car.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_car.Name = "lbl_car";
            this.lbl_car.Size = new System.Drawing.Size(63, 35);
            this.lbl_car.TabIndex = 6;
            this.lbl_car.Text = "ماشین";
            this.lbl_car.Click += new System.EventHandler(this.lbl_car_Click);
            // 
            // tbx_drivername
            // 
            this.tbx_drivername.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_drivername.Location = new System.Drawing.Point(377, 75);
            this.tbx_drivername.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_drivername.Name = "tbx_drivername";
            this.tbx_drivername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_drivername.Size = new System.Drawing.Size(239, 33);
            this.tbx_drivername.TabIndex = 0;
            this.tbx_drivername.TextChanged += new System.EventHandler(this.tbx_drivername_TextChanged);
            // 
            // tbx_drivercar
            // 
            this.tbx_drivercar.Font = new System.Drawing.Font("B Nazanin", 10.2F);
            this.tbx_drivercar.Location = new System.Drawing.Point(377, 169);
            this.tbx_drivercar.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_drivercar.Name = "tbx_drivercar";
            this.tbx_drivercar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_drivercar.Size = new System.Drawing.Size(239, 33);
            this.tbx_drivercar.TabIndex = 4;
            this.tbx_drivercar.TextChanged += new System.EventHandler(this.tbx_drivercar_TextChanged);
            // 
            // tbx_driverphone
            // 
            this.tbx_driverphone.Font = new System.Drawing.Font("B Nazanin", 10.2F);
            this.tbx_driverphone.Location = new System.Drawing.Point(13, 124);
            this.tbx_driverphone.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_driverphone.MaxLength = 15;
            this.tbx_driverphone.Name = "tbx_driverphone";
            this.tbx_driverphone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_driverphone.Size = new System.Drawing.Size(239, 33);
            this.tbx_driverphone.TabIndex = 3;
            this.tbx_driverphone.TextChanged += new System.EventHandler(this.tbx_driverphone_TextChanged);
            this.tbx_driverphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_driverphone_KeyPress);
            // 
            // tbx_drivercode
            // 
            this.tbx_drivercode.Font = new System.Drawing.Font("B Nazanin", 10.2F);
            this.tbx_drivercode.Location = new System.Drawing.Point(377, 122);
            this.tbx_drivercode.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_drivercode.MaxLength = 11;
            this.tbx_drivercode.Name = "tbx_drivercode";
            this.tbx_drivercode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_drivercode.Size = new System.Drawing.Size(239, 33);
            this.tbx_drivercode.TabIndex = 2;
            this.tbx_drivercode.TextChanged += new System.EventHandler(this.tbx_drivercode_TextChanged);
            this.tbx_drivercode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_drivercode_KeyPress);
            // 
            // tbx_driverlastname
            // 
            this.tbx_driverlastname.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_driverlastname.Location = new System.Drawing.Point(13, 79);
            this.tbx_driverlastname.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_driverlastname.Name = "tbx_driverlastname";
            this.tbx_driverlastname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_driverlastname.Size = new System.Drawing.Size(239, 33);
            this.tbx_driverlastname.TabIndex = 1;
            this.tbx_driverlastname.TextChanged += new System.EventHandler(this.tbx_driverlastname_TextChanged);
            // 
            // tbx_driveraddress
            // 
            this.tbx_driveraddress.Font = new System.Drawing.Font("B Nazanin", 10.2F);
            this.tbx_driveraddress.Location = new System.Drawing.Point(13, 169);
            this.tbx_driveraddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_driveraddress.Multiline = true;
            this.tbx_driveraddress.Name = "tbx_driveraddress";
            this.tbx_driveraddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_driveraddress.Size = new System.Drawing.Size(239, 69);
            this.tbx_driveraddress.TabIndex = 5;
            this.tbx_driveraddress.TextChanged += new System.EventHandler(this.tbx_driveraddress_TextChanged);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_back.Location = new System.Drawing.Point(121, 295);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(151, 37);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "بازگشت";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_reset.Location = new System.Drawing.Point(280, 295);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(145, 37);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "پاک کردن";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_adddriver
            // 
            this.btn_adddriver.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_adddriver.Location = new System.Drawing.Point(433, 295);
            this.btn_adddriver.Margin = new System.Windows.Forms.Padding(4);
            this.btn_adddriver.Name = "btn_adddriver";
            this.btn_adddriver.Size = new System.Drawing.Size(145, 37);
            this.btn_adddriver.TabIndex = 6;
            this.btn_adddriver.Text = "افزودن";
            this.btn_adddriver.UseVisualStyleBackColor = true;
            this.btn_adddriver.Click += new System.EventHandler(this.btn_adddriver_Click);
            // 
            // AddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 342);
            this.Controls.Add(this.btn_adddriver);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه کردن راننده";
            this.Load += new System.EventHandler(this.AddDriver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_codemelli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_car;
        private System.Windows.Forms.TextBox tbx_drivername;
        private System.Windows.Forms.TextBox tbx_drivercar;
        private System.Windows.Forms.TextBox tbx_driverphone;
        private System.Windows.Forms.TextBox tbx_drivercode;
        private System.Windows.Forms.TextBox tbx_driverlastname;
        private System.Windows.Forms.TextBox tbx_driveraddress;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_adddriver;
    }
}