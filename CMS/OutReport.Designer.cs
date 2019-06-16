namespace CMS
{
    partial class OutReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutReport));
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Show = new System.Windows.Forms.Button();
            this.TaxiDBDataSet = new CMS.TaxiDBDataSet();
            this.tbl_billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_billTableAdapter = new CMS.TaxiDBDataSetTableAdapters.tbl_billTableAdapter();
            this.dgv_outreport = new System.Windows.Forms.DataGridView();
            this.شمارهاشتراکDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.مشتریDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.رانندهDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.مبدأDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.مقصدDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.هزینهDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تاریخرفتDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ساعترفتDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report_viewTableAdapter = new CMS.TaxiDBDataSetTableAdapters.report_viewTableAdapter();
            this.tbx_count = new System.Windows.Forms.TextBox();
            this.lbl_drivername = new System.Windows.Forms.Label();
            this.tbx_totalcost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TaxiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outreport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportviewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.CalendarFont = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtp_StartDate.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDate.Location = new System.Drawing.Point(627, 7);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_StartDate.RightToLeftLayout = true;
            this.dtp_StartDate.Size = new System.Drawing.Size(147, 37);
            this.dtp_StartDate.TabIndex = 0;
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.CalendarFont = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtp_EndDate.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndDate.Location = new System.Drawing.Point(400, 7);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_EndDate.RightToLeftLayout = true;
            this.dtp_EndDate.Size = new System.Drawing.Size(147, 37);
            this.dtp_EndDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(780, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = ": از تاریخ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(553, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = ": تا تاریخ";
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Show.Location = new System.Drawing.Point(255, 7);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(114, 37);
            this.btn_Show.TabIndex = 2;
            this.btn_Show.Text = "نمایش";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // TaxiDBDataSet
            // 
            this.TaxiDBDataSet.DataSetName = "TaxiDBDataSet";
            this.TaxiDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_billBindingSource
            // 
            this.tbl_billBindingSource.DataMember = "tbl_bill";
            this.tbl_billBindingSource.DataSource = this.TaxiDBDataSet;
            // 
            // tbl_billTableAdapter
            // 
            this.tbl_billTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_outreport
            // 
            this.dgv_outreport.AllowUserToAddRows = false;
            this.dgv_outreport.AllowUserToDeleteRows = false;
            this.dgv_outreport.AutoGenerateColumns = false;
            this.dgv_outreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_outreport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.شمارهاشتراکDataGridViewTextBoxColumn,
            this.مشتریDataGridViewTextBoxColumn,
            this.رانندهDataGridViewTextBoxColumn,
            this.مبدأDataGridViewTextBoxColumn,
            this.مقصدDataGridViewTextBoxColumn,
            this.هزینهDataGridViewTextBoxColumn,
            this.تاریخرفتDataGridViewTextBoxColumn,
            this.ساعترفتDataGridViewTextBoxColumn});
            this.dgv_outreport.DataSource = this.reportviewBindingSource1;
            this.dgv_outreport.Location = new System.Drawing.Point(10, 50);
            this.dgv_outreport.Name = "dgv_outreport";
            this.dgv_outreport.ReadOnly = true;
            this.dgv_outreport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_outreport.RowTemplate.Height = 24;
            this.dgv_outreport.Size = new System.Drawing.Size(852, 369);
            this.dgv_outreport.TabIndex = 3;
            // 
            // شمارهاشتراکDataGridViewTextBoxColumn
            // 
            this.شمارهاشتراکDataGridViewTextBoxColumn.DataPropertyName = "شماره اشتراک";
            this.شمارهاشتراکDataGridViewTextBoxColumn.HeaderText = "شماره اشتراک";
            this.شمارهاشتراکDataGridViewTextBoxColumn.Name = "شمارهاشتراکDataGridViewTextBoxColumn";
            this.شمارهاشتراکDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // مشتریDataGridViewTextBoxColumn
            // 
            this.مشتریDataGridViewTextBoxColumn.DataPropertyName = "مشتری";
            this.مشتریDataGridViewTextBoxColumn.HeaderText = "مشتری";
            this.مشتریDataGridViewTextBoxColumn.Name = "مشتریDataGridViewTextBoxColumn";
            this.مشتریDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // رانندهDataGridViewTextBoxColumn
            // 
            this.رانندهDataGridViewTextBoxColumn.DataPropertyName = "راننده";
            this.رانندهDataGridViewTextBoxColumn.HeaderText = "راننده";
            this.رانندهDataGridViewTextBoxColumn.Name = "رانندهDataGridViewTextBoxColumn";
            this.رانندهDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // مبدأDataGridViewTextBoxColumn
            // 
            this.مبدأDataGridViewTextBoxColumn.DataPropertyName = "مبدأ";
            this.مبدأDataGridViewTextBoxColumn.HeaderText = "مبدأ";
            this.مبدأDataGridViewTextBoxColumn.Name = "مبدأDataGridViewTextBoxColumn";
            this.مبدأDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // مقصدDataGridViewTextBoxColumn
            // 
            this.مقصدDataGridViewTextBoxColumn.DataPropertyName = "مقصد";
            this.مقصدDataGridViewTextBoxColumn.HeaderText = "مقصد";
            this.مقصدDataGridViewTextBoxColumn.Name = "مقصدDataGridViewTextBoxColumn";
            this.مقصدDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // هزینهDataGridViewTextBoxColumn
            // 
            this.هزینهDataGridViewTextBoxColumn.DataPropertyName = "هزینه";
            this.هزینهDataGridViewTextBoxColumn.HeaderText = "هزینه";
            this.هزینهDataGridViewTextBoxColumn.Name = "هزینهDataGridViewTextBoxColumn";
            this.هزینهDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // تاریخرفتDataGridViewTextBoxColumn
            // 
            this.تاریخرفتDataGridViewTextBoxColumn.DataPropertyName = "تاریخ رفت";
            this.تاریخرفتDataGridViewTextBoxColumn.HeaderText = "تاریخ رفت";
            this.تاریخرفتDataGridViewTextBoxColumn.Name = "تاریخرفتDataGridViewTextBoxColumn";
            this.تاریخرفتDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ساعترفتDataGridViewTextBoxColumn
            // 
            this.ساعترفتDataGridViewTextBoxColumn.DataPropertyName = "ساعت رفت";
            this.ساعترفتDataGridViewTextBoxColumn.HeaderText = "ساعت رفت";
            this.ساعترفتDataGridViewTextBoxColumn.Name = "ساعترفتDataGridViewTextBoxColumn";
            this.ساعترفتDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportviewBindingSource1
            // 
            this.reportviewBindingSource1.DataMember = "report_view";
            this.reportviewBindingSource1.DataSource = this.TaxiDBDataSet;
            // 
            // reportviewBindingSource
            // 
            this.reportviewBindingSource.DataMember = "report_view";
            this.reportviewBindingSource.DataSource = this.TaxiDBDataSet;
            // 
            // report_viewTableAdapter
            // 
            this.report_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tbx_count
            // 
            this.tbx_count.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.tbx_count.Location = new System.Drawing.Point(666, 423);
            this.tbx_count.Name = "tbx_count";
            this.tbx_count.ReadOnly = true;
            this.tbx_count.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_count.Size = new System.Drawing.Size(136, 37);
            this.tbx_count.TabIndex = 4;
            // 
            // lbl_drivername
            // 
            this.lbl_drivername.AutoSize = true;
            this.lbl_drivername.BackColor = System.Drawing.Color.Transparent;
            this.lbl_drivername.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.lbl_drivername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_drivername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_drivername.Location = new System.Drawing.Point(809, 423);
            this.lbl_drivername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_drivername.Name = "lbl_drivername";
            this.lbl_drivername.Size = new System.Drawing.Size(52, 35);
            this.lbl_drivername.TabIndex = 5;
            this.lbl_drivername.Text = "تعداد";
            // 
            // tbx_totalcost
            // 
            this.tbx_totalcost.Enabled = false;
            this.tbx_totalcost.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.tbx_totalcost.Location = new System.Drawing.Point(395, 423);
            this.tbx_totalcost.Name = "tbx_totalcost";
            this.tbx_totalcost.Size = new System.Drawing.Size(136, 37);
            this.tbx_totalcost.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 13.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(538, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "جمع هزینه ها";
            // 
            // OutReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_drivername);
            this.Controls.Add(this.tbx_totalcost);
            this.Controls.Add(this.tbx_count);
            this.Controls.Add(this.dgv_outreport);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.dtp_StartDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OutReport";
            this.Text = "گزارش روزانه";
            this.Load += new System.EventHandler(this.OutReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaxiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outreport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportviewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportviewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.BindingSource tbl_billBindingSource;
        private TaxiDBDataSet TaxiDBDataSet;
        private TaxiDBDataSetTableAdapters.tbl_billTableAdapter tbl_billTableAdapter;
        private System.Windows.Forms.DataGridView dgv_outreport;
        private System.Windows.Forms.BindingSource reportviewBindingSource;
        private TaxiDBDataSetTableAdapters.report_viewTableAdapter report_viewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn شمارهاشتراکDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn مشتریDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn رانندهDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn مبدأDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn مقصدDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn هزینهDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn تاریخرفتDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ساعترفتDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reportviewBindingSource1;
        private System.Windows.Forms.TextBox tbx_count;
        private System.Windows.Forms.Label lbl_drivername;
        private System.Windows.Forms.TextBox tbx_totalcost;
        private System.Windows.Forms.Label label3;
    }
}