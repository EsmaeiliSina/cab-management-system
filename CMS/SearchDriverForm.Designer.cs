namespace CMS
{
    partial class SearchDriverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDriverForm));
            this.dgv_drivers = new System.Windows.Forms.DataGridView();
            this.driveridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverlnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drivercodemelliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drivertelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divercarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbldriverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDBDataSet = new CMS.TaxiDBDataSet();
            this.btn_search = new System.Windows.Forms.Button();
            this.cmb_searchbase = new System.Windows.Forms.ComboBox();
            this.tbx_searchfor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_driverTableAdapter = new CMS.TaxiDBDataSetTableAdapters.tbl_driverTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldriverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_drivers
            // 
            this.dgv_drivers.AllowUserToAddRows = false;
            this.dgv_drivers.AllowUserToDeleteRows = false;
            this.dgv_drivers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_drivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_drivers.AutoGenerateColumns = false;
            this.dgv_drivers.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgv_drivers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_drivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driveridDataGridViewTextBoxColumn,
            this.driverfnameDataGridViewTextBoxColumn,
            this.driverlnameDataGridViewTextBoxColumn,
            this.drivercodemelliDataGridViewTextBoxColumn,
            this.drivertelDataGridViewTextBoxColumn,
            this.driveraddressDataGridViewTextBoxColumn,
            this.divercarDataGridViewTextBoxColumn});
            this.dgv_drivers.DataSource = this.tbldriverBindingSource;
            this.dgv_drivers.Location = new System.Drawing.Point(12, 60);
            this.dgv_drivers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_drivers.Name = "dgv_drivers";
            this.dgv_drivers.ReadOnly = true;
            this.dgv_drivers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_drivers.RowTemplate.Height = 24;
            this.dgv_drivers.Size = new System.Drawing.Size(867, 361);
            this.dgv_drivers.TabIndex = 9;
            // 
            // driveridDataGridViewTextBoxColumn
            // 
            this.driveridDataGridViewTextBoxColumn.DataPropertyName = "driver_id";
            this.driveridDataGridViewTextBoxColumn.HeaderText = "کد";
            this.driveridDataGridViewTextBoxColumn.Name = "driveridDataGridViewTextBoxColumn";
            this.driveridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverfnameDataGridViewTextBoxColumn
            // 
            this.driverfnameDataGridViewTextBoxColumn.DataPropertyName = "driver_fname";
            this.driverfnameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.driverfnameDataGridViewTextBoxColumn.Name = "driverfnameDataGridViewTextBoxColumn";
            this.driverfnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverlnameDataGridViewTextBoxColumn
            // 
            this.driverlnameDataGridViewTextBoxColumn.DataPropertyName = "driver_lname";
            this.driverlnameDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.driverlnameDataGridViewTextBoxColumn.Name = "driverlnameDataGridViewTextBoxColumn";
            this.driverlnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drivercodemelliDataGridViewTextBoxColumn
            // 
            this.drivercodemelliDataGridViewTextBoxColumn.DataPropertyName = "driver_codemelli";
            this.drivercodemelliDataGridViewTextBoxColumn.HeaderText = "کد ملی";
            this.drivercodemelliDataGridViewTextBoxColumn.Name = "drivercodemelliDataGridViewTextBoxColumn";
            this.drivercodemelliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drivertelDataGridViewTextBoxColumn
            // 
            this.drivertelDataGridViewTextBoxColumn.DataPropertyName = "driver_tel";
            this.drivertelDataGridViewTextBoxColumn.HeaderText = "تلفن";
            this.drivertelDataGridViewTextBoxColumn.Name = "drivertelDataGridViewTextBoxColumn";
            this.drivertelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driveraddressDataGridViewTextBoxColumn
            // 
            this.driveraddressDataGridViewTextBoxColumn.DataPropertyName = "driver_address";
            this.driveraddressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.driveraddressDataGridViewTextBoxColumn.Name = "driveraddressDataGridViewTextBoxColumn";
            this.driveraddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // divercarDataGridViewTextBoxColumn
            // 
            this.divercarDataGridViewTextBoxColumn.DataPropertyName = "diver_car";
            this.divercarDataGridViewTextBoxColumn.HeaderText = "ماشین";
            this.divercarDataGridViewTextBoxColumn.Name = "divercarDataGridViewTextBoxColumn";
            this.divercarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbldriverBindingSource
            // 
            this.tbldriverBindingSource.DataMember = "tbl_driver";
            this.tbldriverBindingSource.DataSource = this.taxiDBDataSet;
            // 
            // taxiDBDataSet
            // 
            this.taxiDBDataSet.DataSetName = "TaxiDBDataSet";
            this.taxiDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("B Nazanin", 10.8F);
            this.btn_search.Location = new System.Drawing.Point(13, 15);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(130, 37);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "جستجو";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cmb_searchbase
            // 
            this.cmb_searchbase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_searchbase.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.cmb_searchbase.FormattingEnabled = true;
            this.cmb_searchbase.Items.AddRange(new object[] {
            "کد راننده",
            "نام",
            "نام خانوادگی",
            "شماره تماس",
            "کد ملی",
            "ماشین",
            "تلفن",
            "آدرس"});
            this.cmb_searchbase.Location = new System.Drawing.Point(499, 15);
            this.cmb_searchbase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_searchbase.Name = "cmb_searchbase";
            this.cmb_searchbase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_searchbase.Size = new System.Drawing.Size(236, 37);
            this.cmb_searchbase.TabIndex = 5;
            // 
            // tbx_searchfor
            // 
            this.tbx_searchfor.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_searchfor.Location = new System.Drawing.Point(149, 15);
            this.tbx_searchfor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_searchfor.Name = "tbx_searchfor";
            this.tbx_searchfor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_searchfor.Size = new System.Drawing.Size(344, 37);
            this.tbx_searchfor.TabIndex = 7;
            this.tbx_searchfor.TextChanged += new System.EventHandler(this.tbx_searchfor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.label1.Location = new System.Drawing.Point(734, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "جستجو براساس";
            // 
            // tbl_driverTableAdapter
            // 
            this.tbl_driverTableAdapter.ClearBeforeFill = true;
            // 
            // SearchDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 436);
            this.Controls.Add(this.dgv_drivers);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cmb_searchbase);
            this.Controls.Add(this.tbx_searchfor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchDriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجو رانندگان";
            this.Load += new System.EventHandler(this.SearchDriverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldriverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_drivers;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cmb_searchbase;
        private System.Windows.Forms.TextBox tbx_searchfor;
        private System.Windows.Forms.Label label1;
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
    }
}