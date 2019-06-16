namespace CMS
{
    partial class EditCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomerForm));
            this.btn_editcustomer = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.tbx_clintaddress = new System.Windows.Forms.TextBox();
            this.tbx_clintlastname = new System.Windows.Forms.TextBox();
            this.tbx_clintphone = new System.Windows.Forms.TextBox();
            this.tbx_clintname = new System.Windows.Forms.TextBox();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_editcustomer
            // 
            this.btn_editcustomer.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_editcustomer.Location = new System.Drawing.Point(428, 277);
            this.btn_editcustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editcustomer.Name = "btn_editcustomer";
            this.btn_editcustomer.Size = new System.Drawing.Size(145, 37);
            this.btn_editcustomer.TabIndex = 4;
            this.btn_editcustomer.Text = "ویرایش";
            this.btn_editcustomer.UseVisualStyleBackColor = true;
            this.btn_editcustomer.Click += new System.EventHandler(this.btn_editcustomer_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_reset.Location = new System.Drawing.Point(276, 277);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(145, 37);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "پاک کردن";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_back.Location = new System.Drawing.Point(116, 277);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(151, 37);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "بازگشت";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tbx_clintaddress
            // 
            this.tbx_clintaddress.Font = new System.Drawing.Font("B Nazanin", 10.2F);
            this.tbx_clintaddress.Location = new System.Drawing.Point(377, 124);
            this.tbx_clintaddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_clintaddress.Multiline = true;
            this.tbx_clintaddress.Name = "tbx_clintaddress";
            this.tbx_clintaddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_clintaddress.Size = new System.Drawing.Size(239, 88);
            this.tbx_clintaddress.TabIndex = 2;
            // 
            // tbx_clintlastname
            // 
            this.tbx_clintlastname.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_clintlastname.Location = new System.Drawing.Point(23, 71);
            this.tbx_clintlastname.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_clintlastname.Name = "tbx_clintlastname";
            this.tbx_clintlastname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_clintlastname.Size = new System.Drawing.Size(239, 33);
            this.tbx_clintlastname.TabIndex = 1;
            // 
            // tbx_clintphone
            // 
            this.tbx_clintphone.Font = new System.Drawing.Font("B Nazanin", 10.2F);
            this.tbx_clintphone.Location = new System.Drawing.Point(23, 123);
            this.tbx_clintphone.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_clintphone.MaxLength = 15;
            this.tbx_clintphone.Name = "tbx_clintphone";
            this.tbx_clintphone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_clintphone.Size = new System.Drawing.Size(239, 33);
            this.tbx_clintphone.TabIndex = 3;
            // 
            // tbx_clintname
            // 
            this.tbx_clintname.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_clintname.Location = new System.Drawing.Point(377, 74);
            this.tbx_clintname.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_clintname.Name = "tbx_clintname";
            this.tbx_clintname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_clintname.Size = new System.Drawing.Size(239, 33);
            this.tbx_clintname.TabIndex = 0;
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tel.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.lbl_tel.Location = new System.Drawing.Point(269, 123);
            this.lbl_tel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(100, 35);
            this.lbl_tel.TabIndex = 1;
            this.lbl_tel.Text = "شماره تلفن";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.label5.Location = new System.Drawing.Point(617, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 35);
            this.label5.TabIndex = 27;
            this.label5.Text = "آدرس";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lastname.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.lbl_lastname.Location = new System.Drawing.Point(269, 71);
            this.lbl_lastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(109, 35);
            this.lbl_lastname.TabIndex = 25;
            this.lbl_lastname.Text = "نام خانوادگی";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.lbl_name.Location = new System.Drawing.Point(633, 74);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 35);
            this.lbl_name.TabIndex = 24;
            this.lbl_name.Text = "نام";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(448, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 47);
            this.label1.TabIndex = 22;
            this.label1.Text = "ویرایش مشترک";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 322);
            this.Controls.Add(this.btn_editcustomer);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tbx_clintaddress);
            this.Controls.Add(this.tbx_clintlastname);
            this.Controls.Add(this.tbx_clintphone);
            this.Controls.Add(this.tbx_clintname);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditCustomerForm";
            this.Text = "ویرایش مشترک";
            this.Load += new System.EventHandler(this.EditCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editcustomer;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox tbx_clintaddress;
        private System.Windows.Forms.TextBox tbx_clintlastname;
        private System.Windows.Forms.TextBox tbx_clintphone;
        private System.Windows.Forms.TextBox tbx_clintname;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
    }
}