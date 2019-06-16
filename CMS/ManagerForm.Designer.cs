namespace CMS
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.btn_newsecretry = new System.Windows.Forms.Button();
            this.btn_customerlist = new System.Windows.Forms.Button();
            this.btn_driverlist = new System.Windows.Forms.Button();
            this.Btn_report = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_newsecretry
            // 
            this.btn_newsecretry.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_newsecretry.Location = new System.Drawing.Point(507, 12);
            this.btn_newsecretry.Name = "btn_newsecretry";
            this.btn_newsecretry.Size = new System.Drawing.Size(123, 42);
            this.btn_newsecretry.TabIndex = 1;
            this.btn_newsecretry.Text = "افزودن منشی";
            this.btn_newsecretry.UseVisualStyleBackColor = true;
            this.btn_newsecretry.Click += new System.EventHandler(this.btn_newsecretry_Click);
            // 
            // btn_customerlist
            // 
            this.btn_customerlist.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_customerlist.Location = new System.Drawing.Point(507, 60);
            this.btn_customerlist.Name = "btn_customerlist";
            this.btn_customerlist.Size = new System.Drawing.Size(123, 42);
            this.btn_customerlist.TabIndex = 2;
            this.btn_customerlist.Text = "لیست مشترکین";
            this.btn_customerlist.UseVisualStyleBackColor = true;
            this.btn_customerlist.Click += new System.EventHandler(this.btn_customerlist_Click);
            // 
            // btn_driverlist
            // 
            this.btn_driverlist.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_driverlist.Location = new System.Drawing.Point(507, 108);
            this.btn_driverlist.Name = "btn_driverlist";
            this.btn_driverlist.Size = new System.Drawing.Size(123, 42);
            this.btn_driverlist.TabIndex = 3;
            this.btn_driverlist.Text = "لیست رانندگان";
            this.btn_driverlist.UseVisualStyleBackColor = true;
            this.btn_driverlist.Click += new System.EventHandler(this.btn_driverlist_Click);
            // 
            // Btn_report
            // 
            this.Btn_report.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_report.Location = new System.Drawing.Point(507, 156);
            this.Btn_report.Name = "Btn_report";
            this.Btn_report.Size = new System.Drawing.Size(123, 42);
            this.Btn_report.TabIndex = 4;
            this.Btn_report.Text = "گزارش گیری";
            this.Btn_report.UseVisualStyleBackColor = true;
            this.Btn_report.Click += new System.EventHandler(this.Btn_report_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_back.Location = new System.Drawing.Point(507, 204);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(123, 42);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "بازگشت";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 452);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.Btn_report);
            this.Controls.Add(this.btn_driverlist);
            this.Controls.Add(this.btn_customerlist);
            this.Controls.Add(this.btn_newsecretry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_newsecretry;
        private System.Windows.Forms.Button btn_customerlist;
        private System.Windows.Forms.Button btn_driverlist;
        private System.Windows.Forms.Button Btn_report;
        private System.Windows.Forms.Button btn_back;
    }
}