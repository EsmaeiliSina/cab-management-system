namespace CMS
{
    partial class SearchCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomerForm));
            this.cmb_searchbase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_searchfor = new System.Windows.Forms.TextBox();
            this.tblcustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDBDataSet = new CMS.TaxiDBDataSet();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_clinets = new System.Windows.Forms.DataGridView();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerlnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customertelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_customersTableAdapter = new CMS.TaxiDBDataSetTableAdapters.tbl_customersTableAdapter();
            this.tblcustomersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKtblbilltblcustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_billTableAdapter = new CMS.TaxiDBDataSetTableAdapters.tbl_billTableAdapter();
            this.fKtblbilltblcustomersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clinets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblbilltblcustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblbilltblcustomersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_searchbase
            // 
            this.cmb_searchbase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_searchbase.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.cmb_searchbase.FormattingEnabled = true;
            this.cmb_searchbase.Items.AddRange(new object[] {
            "شماره اشتراک",
            "نام",
            "نام خانوادگی",
            "شماره تماس",
            "آدرس"});
            this.cmb_searchbase.Location = new System.Drawing.Point(498, 17);
            this.cmb_searchbase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_searchbase.Name = "cmb_searchbase";
            this.cmb_searchbase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_searchbase.Size = new System.Drawing.Size(236, 37);
            this.cmb_searchbase.TabIndex = 0;
            this.cmb_searchbase.SelectedIndexChanged += new System.EventHandler(this.cmb_searchbase_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.label1.Location = new System.Drawing.Point(733, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو براساس";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbx_searchfor
            // 
            this.tbx_searchfor.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_searchfor.Location = new System.Drawing.Point(148, 17);
            this.tbx_searchfor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_searchfor.Name = "tbx_searchfor";
            this.tbx_searchfor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_searchfor.Size = new System.Drawing.Size(344, 37);
            this.tbx_searchfor.TabIndex = 1;
            this.tbx_searchfor.TextChanged += new System.EventHandler(this.tbx_searchfor_TextChanged);
            // 
            // tblcustomersBindingSource
            // 
            this.tblcustomersBindingSource.DataMember = "tbl_customers";
            this.tblcustomersBindingSource.DataSource = this.taxiDBDataSet;
            // 
            // taxiDBDataSet
            // 
            this.taxiDBDataSet.DataSetName = "TaxiDBDataSet";
            this.taxiDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("B Nazanin", 10.8F);
            this.btn_search.Location = new System.Drawing.Point(12, 17);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(130, 37);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "جستجو";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_clinets
            // 
            this.dgv_clinets.AllowUserToAddRows = false;
            this.dgv_clinets.AllowUserToDeleteRows = false;
            this.dgv_clinets.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_clinets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_clinets.AutoGenerateColumns = false;
            this.dgv_clinets.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgv_clinets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_clinets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.customerfnameDataGridViewTextBoxColumn,
            this.customerlnameDataGridViewTextBoxColumn,
            this.customertelDataGridViewTextBoxColumn,
            this.customeraddressDataGridViewTextBoxColumn});
            this.dgv_clinets.DataSource = this.tblcustomersBindingSource;
            this.dgv_clinets.Location = new System.Drawing.Point(11, 62);
            this.dgv_clinets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_clinets.Name = "dgv_clinets";
            this.dgv_clinets.ReadOnly = true;
            this.dgv_clinets.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_clinets.RowTemplate.Height = 24;
            this.dgv_clinets.Size = new System.Drawing.Size(867, 361);
            this.dgv_clinets.TabIndex = 4;
            this.dgv_clinets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clinets_CellContentClick);
            this.dgv_clinets.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clinets_CellDoubleClick);
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "شماره اشتراک";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerfnameDataGridViewTextBoxColumn
            // 
            this.customerfnameDataGridViewTextBoxColumn.DataPropertyName = "customer_fname";
            this.customerfnameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.customerfnameDataGridViewTextBoxColumn.Name = "customerfnameDataGridViewTextBoxColumn";
            this.customerfnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerlnameDataGridViewTextBoxColumn
            // 
            this.customerlnameDataGridViewTextBoxColumn.DataPropertyName = "customer_lname";
            this.customerlnameDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.customerlnameDataGridViewTextBoxColumn.Name = "customerlnameDataGridViewTextBoxColumn";
            this.customerlnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customertelDataGridViewTextBoxColumn
            // 
            this.customertelDataGridViewTextBoxColumn.DataPropertyName = "customer_tel";
            this.customertelDataGridViewTextBoxColumn.HeaderText = "تلفن";
            this.customertelDataGridViewTextBoxColumn.Name = "customertelDataGridViewTextBoxColumn";
            this.customertelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customeraddressDataGridViewTextBoxColumn
            // 
            this.customeraddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customeraddressDataGridViewTextBoxColumn.DataPropertyName = "customer_address";
            this.customeraddressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.customeraddressDataGridViewTextBoxColumn.Name = "customeraddressDataGridViewTextBoxColumn";
            this.customeraddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeraddressDataGridViewTextBoxColumn.Width = 64;
            // 
            // tbl_customersTableAdapter
            // 
            this.tbl_customersTableAdapter.ClearBeforeFill = true;
            // 
            // tblcustomersBindingSource1
            // 
            this.tblcustomersBindingSource1.DataMember = "tbl_customers";
            this.tblcustomersBindingSource1.DataSource = this.taxiDBDataSet;
            // 
            // fKtblbilltblcustomersBindingSource
            // 
            this.fKtblbilltblcustomersBindingSource.DataMember = "FK_tbl_bill_tbl_customers";
            this.fKtblbilltblcustomersBindingSource.DataSource = this.tblcustomersBindingSource1;
            // 
            // tbl_billTableAdapter
            // 
            this.tbl_billTableAdapter.ClearBeforeFill = true;
            // 
            // fKtblbilltblcustomersBindingSource1
            // 
            this.fKtblbilltblcustomersBindingSource1.DataMember = "FK_tbl_bill_tbl_customers";
            this.fKtblbilltblcustomersBindingSource1.DataSource = this.tblcustomersBindingSource;
            // 
            // SearchCustomerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 436);
            this.Controls.Add(this.dgv_clinets);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cmb_searchbase);
            this.Controls.Add(this.tbx_searchfor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجوی مشترکین";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchCustomerForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clinets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblbilltblcustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblbilltblcustomersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_searchfor;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_clinets;
        private TaxiDBDataSet taxiDBDataSet;
        private System.Windows.Forms.BindingSource tblcustomersBindingSource;
        private TaxiDBDataSetTableAdapters.tbl_customersTableAdapter tbl_customersTableAdapter;
        private System.Windows.Forms.BindingSource tblcustomersBindingSource1;
        private System.Windows.Forms.BindingSource fKtblbilltblcustomersBindingSource;
        private TaxiDBDataSetTableAdapters.tbl_billTableAdapter tbl_billTableAdapter;
        private System.Windows.Forms.BindingSource fKtblbilltblcustomersBindingSource1;
        private System.Windows.Forms.ComboBox cmb_searchbase;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerlnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customertelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeraddressDataGridViewTextBoxColumn;
    }
}