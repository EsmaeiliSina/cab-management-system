namespace CMS
{
    partial class DriverForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverForm));
            this.dgv_Driver = new System.Windows.Forms.DataGridView();
            this.driveridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverlnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drivercodemelliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drivertelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divercarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbldriverBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDBDataSet1 = new CMS.TaxiDBDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reload = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.taxiDBDataSet = new CMS.TaxiDBDataSet();
            this.tbldriverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_driverTableAdapter = new CMS.TaxiDBDataSetTableAdapters.tbl_driverTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Driver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldriverBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDBDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldriverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Driver
            // 
            this.dgv_Driver.AllowUserToAddRows = false;
            this.dgv_Driver.AllowUserToDeleteRows = false;
            this.dgv_Driver.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Zar", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Driver.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Driver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Driver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driveridDataGridViewTextBoxColumn,
            this.driverfnameDataGridViewTextBoxColumn,
            this.driverlnameDataGridViewTextBoxColumn,
            this.drivercodemelliDataGridViewTextBoxColumn,
            this.drivertelDataGridViewTextBoxColumn,
            this.driveraddressDataGridViewTextBoxColumn,
            this.divercarDataGridViewTextBoxColumn});
            this.dgv_Driver.DataSource = this.tbldriverBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Driver.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Driver.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Driver.Location = new System.Drawing.Point(12, 12);
            this.dgv_Driver.Name = "dgv_Driver";
            this.dgv_Driver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_Driver.RowTemplate.Height = 24;
            this.dgv_Driver.Size = new System.Drawing.Size(957, 453);
            this.dgv_Driver.TabIndex = 0;
            // 
            // driveridDataGridViewTextBoxColumn
            // 
            this.driveridDataGridViewTextBoxColumn.DataPropertyName = "driver_id";
            this.driveridDataGridViewTextBoxColumn.HeaderText = "کد راننده";
            this.driveridDataGridViewTextBoxColumn.Name = "driveridDataGridViewTextBoxColumn";
            // 
            // driverfnameDataGridViewTextBoxColumn
            // 
            this.driverfnameDataGridViewTextBoxColumn.DataPropertyName = "driver_fname";
            this.driverfnameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.driverfnameDataGridViewTextBoxColumn.Name = "driverfnameDataGridViewTextBoxColumn";
            // 
            // driverlnameDataGridViewTextBoxColumn
            // 
            this.driverlnameDataGridViewTextBoxColumn.DataPropertyName = "driver_lname";
            this.driverlnameDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.driverlnameDataGridViewTextBoxColumn.Name = "driverlnameDataGridViewTextBoxColumn";
            // 
            // drivercodemelliDataGridViewTextBoxColumn
            // 
            this.drivercodemelliDataGridViewTextBoxColumn.DataPropertyName = "driver_codemelli";
            this.drivercodemelliDataGridViewTextBoxColumn.HeaderText = "کد ملی";
            this.drivercodemelliDataGridViewTextBoxColumn.Name = "drivercodemelliDataGridViewTextBoxColumn";
            // 
            // drivertelDataGridViewTextBoxColumn
            // 
            this.drivertelDataGridViewTextBoxColumn.DataPropertyName = "driver_tel";
            this.drivertelDataGridViewTextBoxColumn.HeaderText = "تلفن";
            this.drivertelDataGridViewTextBoxColumn.Name = "drivertelDataGridViewTextBoxColumn";
            // 
            // driveraddressDataGridViewTextBoxColumn
            // 
            this.driveraddressDataGridViewTextBoxColumn.DataPropertyName = "driver_address";
            this.driveraddressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.driveraddressDataGridViewTextBoxColumn.Name = "driveraddressDataGridViewTextBoxColumn";
            // 
            // divercarDataGridViewTextBoxColumn
            // 
            this.divercarDataGridViewTextBoxColumn.DataPropertyName = "diver_car";
            this.divercarDataGridViewTextBoxColumn.HeaderText = "ماشین";
            this.divercarDataGridViewTextBoxColumn.Name = "divercarDataGridViewTextBoxColumn";
            // 
            // tbldriverBindingSource1
            // 
            this.tbldriverBindingSource1.DataMember = "tbl_driver";
            this.tbldriverBindingSource1.DataSource = this.taxiDBDataSet1;
            // 
            // taxiDBDataSet1
            // 
            this.taxiDBDataSet1.DataSetName = "TaxiDBDataSet";
            this.taxiDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_reload);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(975, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 453);
            this.panel1.TabIndex = 1;
            // 
            // btn_reload
            // 
            this.btn_reload.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_reload.Location = new System.Drawing.Point(3, 147);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(123, 45);
            this.btn_reload.TabIndex = 1;
            this.btn_reload.Text = "بارگذاری مجدد";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.Location = new System.Drawing.Point(3, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 42);
            this.button4.TabIndex = 0;
            this.button4.Text = "بازگشت";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Location = new System.Drawing.Point(3, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 42);
            this.button3.TabIndex = 0;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(3, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "ویرایش";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "جدید";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // taxiDBDataSet
            // 
            this.taxiDBDataSet.DataSetName = "TaxiDBDataSet";
            this.taxiDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbldriverBindingSource
            // 
            this.tbldriverBindingSource.DataMember = "tbl_driver";
            this.tbldriverBindingSource.DataSource = this.taxiDBDataSet;
            // 
            // tbl_driverTableAdapter
            // 
            this.tbl_driverTableAdapter.ClearBeforeFill = true;
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Driver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DriverForm";
            this.Text = "رانندگان";
            this.Load += new System.EventHandler(this.DriverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Driver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldriverBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDBDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taxiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldriverBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Driver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private TaxiDBDataSet taxiDBDataSet;
        private System.Windows.Forms.BindingSource tbldriverBindingSource;
        private TaxiDBDataSetTableAdapters.tbl_driverTableAdapter tbl_driverTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverlnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drivercodemelliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drivertelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divercarDataGridViewTextBoxColumn;
        private TaxiDBDataSet taxiDBDataSet1;
        private System.Windows.Forms.BindingSource tbldriverBindingSource1;
        private System.Windows.Forms.Button btn_reload;
    }
}