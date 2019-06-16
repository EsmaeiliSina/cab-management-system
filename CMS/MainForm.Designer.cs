namespace CMS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.سرویسجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعاتاولیهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهکردنرانندهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جستجوToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رانندهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشترکToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آمارروزانهToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.لیستمشترکینToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیسترانندگانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.راهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.راهنماToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهنرمافزارToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.دربارهیماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تماسباماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_drivername = new System.Windows.Forms.Label();
            this.comb_drivers = new System.Windows.Forms.ComboBox();
            this.tbldriverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDBDataSet = new CMS.TaxiDBDataSet();
            this.tbldriverBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rbtn_nashnas = new System.Windows.Forms.RadioButton();
            this.rbtn_eshtrak = new System.Windows.Forms.RadioButton();
            this.gbx_eshtrk = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_codeeshtrak = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_mabda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.tbx_family = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_phoneNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sendservics = new System.Windows.Forms.Button();
            this.btn_sendandprint = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_maghsad = new System.Windows.Forms.TextBox();
            this.tbl_driverTableAdapter = new CMS.TaxiDBDataSetTableAdapters.tbl_driverTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_cost = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.تغییررمزعبورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbldriverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldriverBindingSource1)).BeginInit();
            this.gbx_eshtrk.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.اطلاعاتاولیهToolStripMenuItem,
            this.جستجوToolStripMenuItem,
            this.گزارشاتToolStripMenuItem,
            this.راهنماToolStripMenuItem,
            this.تغییررمزعبورToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.سرویسجدیدToolStripMenuItem,
            this.خروجToolStripMenuItem});
            resources.ApplyResources(this.ToolStripMenuItem, "ToolStripMenuItem");
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // سرویسجدیدToolStripMenuItem
            // 
            this.سرویسجدیدToolStripMenuItem.Name = "سرویسجدیدToolStripMenuItem";
            resources.ApplyResources(this.سرویسجدیدToolStripMenuItem, "سرویسجدیدToolStripMenuItem");
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            resources.ApplyResources(this.خروجToolStripMenuItem, "خروجToolStripMenuItem");
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // اطلاعاتاولیهToolStripMenuItem
            // 
            this.اطلاعاتاولیهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافهکردنرانندهToolStripMenuItem});
            this.اطلاعاتاولیهToolStripMenuItem.Name = "اطلاعاتاولیهToolStripMenuItem";
            resources.ApplyResources(this.اطلاعاتاولیهToolStripMenuItem, "اطلاعاتاولیهToolStripMenuItem");
            // 
            // اضافهکردنرانندهToolStripMenuItem
            // 
            this.اضافهکردنرانندهToolStripMenuItem.Name = "اضافهکردنرانندهToolStripMenuItem";
            resources.ApplyResources(this.اضافهکردنرانندهToolStripMenuItem, "اضافهکردنرانندهToolStripMenuItem");
            this.اضافهکردنرانندهToolStripMenuItem.Click += new System.EventHandler(this.اضافهکردنرانندهToolStripMenuItem_Click);
            // 
            // جستجوToolStripMenuItem
            // 
            this.جستجوToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.رانندهToolStripMenuItem,
            this.مشترکToolStripMenuItem});
            this.جستجوToolStripMenuItem.Name = "جستجوToolStripMenuItem";
            resources.ApplyResources(this.جستجوToolStripMenuItem, "جستجوToolStripMenuItem");
            // 
            // رانندهToolStripMenuItem
            // 
            this.رانندهToolStripMenuItem.Name = "رانندهToolStripMenuItem";
            resources.ApplyResources(this.رانندهToolStripMenuItem, "رانندهToolStripMenuItem");
            this.رانندهToolStripMenuItem.Click += new System.EventHandler(this.رانندهToolStripMenuItem_Click);
            // 
            // مشترکToolStripMenuItem
            // 
            this.مشترکToolStripMenuItem.Name = "مشترکToolStripMenuItem";
            resources.ApplyResources(this.مشترکToolStripMenuItem, "مشترکToolStripMenuItem");
            this.مشترکToolStripMenuItem.Click += new System.EventHandler(this.مشترکToolStripMenuItem_Click);
            // 
            // گزارشاتToolStripMenuItem
            // 
            this.گزارشاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.آمارروزانهToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.لیستمشترکینToolStripMenuItem,
            this.لیسترانندگانToolStripMenuItem});
            this.گزارشاتToolStripMenuItem.Name = "گزارشاتToolStripMenuItem";
            resources.ApplyResources(this.گزارشاتToolStripMenuItem, "گزارشاتToolStripMenuItem");
            // 
            // آمارروزانهToolStripMenuItem1
            // 
            this.آمارروزانهToolStripMenuItem1.Name = "آمارروزانهToolStripMenuItem1";
            resources.ApplyResources(this.آمارروزانهToolStripMenuItem1, "آمارروزانهToolStripMenuItem1");
            this.آمارروزانهToolStripMenuItem1.Click += new System.EventHandler(this.آمارروزانهToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // لیستمشترکینToolStripMenuItem
            // 
            this.لیستمشترکینToolStripMenuItem.Name = "لیستمشترکینToolStripMenuItem";
            resources.ApplyResources(this.لیستمشترکینToolStripMenuItem, "لیستمشترکینToolStripMenuItem");
            this.لیستمشترکینToolStripMenuItem.Click += new System.EventHandler(this.لیستمشترکینToolStripMenuItem_Click);
            // 
            // لیسترانندگانToolStripMenuItem
            // 
            this.لیسترانندگانToolStripMenuItem.Name = "لیسترانندگانToolStripMenuItem";
            resources.ApplyResources(this.لیسترانندگانToolStripMenuItem, "لیسترانندگانToolStripMenuItem");
            this.لیسترانندگانToolStripMenuItem.Click += new System.EventHandler(this.لیسترانندگانToolStripMenuItem_Click);
            // 
            // راهنماToolStripMenuItem
            // 
            this.راهنماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.راهنماToolStripMenuItem1,
            this.دربارهنرمافزارToolStripMenuItem,
            this.دربارهیماToolStripMenuItem,
            this.تماسباماToolStripMenuItem});
            this.راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
            resources.ApplyResources(this.راهنماToolStripMenuItem, "راهنماToolStripMenuItem");
            // 
            // راهنماToolStripMenuItem1
            // 
            this.راهنماToolStripMenuItem1.Name = "راهنماToolStripMenuItem1";
            resources.ApplyResources(this.راهنماToolStripMenuItem1, "راهنماToolStripMenuItem1");
            this.راهنماToolStripMenuItem1.Click += new System.EventHandler(this.راهنماToolStripMenuItem1_Click_1);
            // 
            // دربارهنرمافزارToolStripMenuItem
            // 
            this.دربارهنرمافزارToolStripMenuItem.Name = "دربارهنرمافزارToolStripMenuItem";
            resources.ApplyResources(this.دربارهنرمافزارToolStripMenuItem, "دربارهنرمافزارToolStripMenuItem");
            // 
            // دربارهیماToolStripMenuItem
            // 
            this.دربارهیماToolStripMenuItem.Name = "دربارهیماToolStripMenuItem";
            resources.ApplyResources(this.دربارهیماToolStripMenuItem, "دربارهیماToolStripMenuItem");
            this.دربارهیماToolStripMenuItem.Click += new System.EventHandler(this.دربارهیماToolStripMenuItem_Click);
            // 
            // تماسباماToolStripMenuItem
            // 
            this.تماسباماToolStripMenuItem.Name = "تماسباماToolStripMenuItem";
            resources.ApplyResources(this.تماسباماToolStripMenuItem, "تماسباماToolStripMenuItem");
            this.تماسباماToolStripMenuItem.Click += new System.EventHandler(this.تماسباماToolStripMenuItem_Click);
            // 
            // lbl_drivername
            // 
            resources.ApplyResources(this.lbl_drivername, "lbl_drivername");
            this.lbl_drivername.BackColor = System.Drawing.Color.Transparent;
            this.lbl_drivername.Name = "lbl_drivername";
            // 
            // comb_drivers
            // 
            this.comb_drivers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbldriverBindingSource, "driver_id", true));
            this.comb_drivers.DataSource = this.tbldriverBindingSource1;
            this.comb_drivers.DisplayMember = "driver_lname";
            this.comb_drivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comb_drivers, "comb_drivers");
            this.comb_drivers.FormattingEnabled = true;
            this.comb_drivers.Name = "comb_drivers";
            this.comb_drivers.ValueMember = "driver_id";
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
            // tbldriverBindingSource1
            // 
            this.tbldriverBindingSource1.DataMember = "tbl_driver";
            this.tbldriverBindingSource1.DataSource = this.taxiDBDataSet;
            // 
            // rbtn_nashnas
            // 
            resources.ApplyResources(this.rbtn_nashnas, "rbtn_nashnas");
            this.rbtn_nashnas.Name = "rbtn_nashnas";
            this.rbtn_nashnas.UseVisualStyleBackColor = true;
            this.rbtn_nashnas.CheckedChanged += new System.EventHandler(this.rbtn_nashnas_CheckedChanged);
            // 
            // rbtn_eshtrak
            // 
            resources.ApplyResources(this.rbtn_eshtrak, "rbtn_eshtrak");
            this.rbtn_eshtrak.Checked = true;
            this.rbtn_eshtrak.Name = "rbtn_eshtrak";
            this.rbtn_eshtrak.TabStop = true;
            this.rbtn_eshtrak.UseVisualStyleBackColor = true;
            this.rbtn_eshtrak.CheckedChanged += new System.EventHandler(this.rbtn_eshtrak_CheckedChanged);
            // 
            // gbx_eshtrk
            // 
            this.gbx_eshtrk.BackColor = System.Drawing.Color.Transparent;
            this.gbx_eshtrk.Controls.Add(this.rbtn_eshtrak);
            this.gbx_eshtrk.Controls.Add(this.rbtn_nashnas);
            resources.ApplyResources(this.gbx_eshtrk, "gbx_eshtrk");
            this.gbx_eshtrk.Name = "gbx_eshtrk";
            this.gbx_eshtrk.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // tbx_codeeshtrak
            // 
            resources.ApplyResources(this.tbx_codeeshtrak, "tbx_codeeshtrak");
            this.tbx_codeeshtrak.Name = "tbx_codeeshtrak";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Gold;
            this.btn_search.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btn_search, "btn_search");
            this.btn_search.Name = "btn_search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // tbx_mabda
            // 
            resources.ApplyResources(this.tbx_mabda, "tbx_mabda");
            this.tbx_mabda.Name = "tbx_mabda";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // tbx_name
            // 
            resources.ApplyResources(this.tbx_name, "tbx_name");
            this.tbx_name.Name = "tbx_name";
            // 
            // tbx_family
            // 
            resources.ApplyResources(this.tbx_family, "tbx_family");
            this.tbx_family.Name = "tbx_family";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // tbx_phoneNo
            // 
            resources.ApplyResources(this.tbx_phoneNo, "tbx_phoneNo");
            this.tbx_phoneNo.Name = "tbx_phoneNo";
            this.tbx_phoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_phoneNo_KeyPress);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // btn_sendservics
            // 
            resources.ApplyResources(this.btn_sendservics, "btn_sendservics");
            this.btn_sendservics.Name = "btn_sendservics";
            this.btn_sendservics.UseVisualStyleBackColor = true;
            this.btn_sendservics.Click += new System.EventHandler(this.btn_sendservics_Click);
            // 
            // btn_sendandprint
            // 
            resources.ApplyResources(this.btn_sendandprint, "btn_sendandprint");
            this.btn_sendandprint.Name = "btn_sendandprint";
            this.btn_sendandprint.UseVisualStyleBackColor = true;
            this.btn_sendandprint.Click += new System.EventHandler(this.btn_sendandprint_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btn_reset, "btn_reset");
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // tbx_maghsad
            // 
            resources.ApplyResources(this.tbx_maghsad, "tbx_maghsad");
            this.tbx_maghsad.Name = "tbx_maghsad";
            // 
            // tbl_driverTableAdapter
            // 
            this.tbl_driverTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Name = "label7";
            // 
            // tbx_cost
            // 
            resources.ApplyResources(this.tbx_cost, "tbx_cost");
            this.tbx_cost.Name = "tbx_cost";
            this.tbx_cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_cost_KeyPress);
            // 
            // lbl_username
            // 
            resources.ApplyResources(this.lbl_username, "lbl_username");
            this.lbl_username.BackColor = System.Drawing.Color.Gold;
            this.lbl_username.Name = "lbl_username";
            // 
            // lbl_date
            // 
            resources.ApplyResources(this.lbl_date, "lbl_date");
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.ForeColor = System.Drawing.Color.Gold;
            this.lbl_date.Name = "lbl_date";
            // 
            // تغییررمزعبورToolStripMenuItem
            // 
            this.تغییررمزعبورToolStripMenuItem.Name = "تغییررمزعبورToolStripMenuItem";
            resources.ApplyResources(this.تغییررمزعبورToolStripMenuItem, "تغییررمزعبورToolStripMenuItem");
            this.تغییررمزعبورToolStripMenuItem.Click += new System.EventHandler(this.تغییررمزعبورToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_sendandprint);
            this.Controls.Add(this.btn_sendservics);
            this.Controls.Add(this.tbx_phoneNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_family);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_cost);
            this.Controls.Add(this.tbx_maghsad);
            this.Controls.Add(this.tbx_mabda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tbx_codeeshtrak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbx_eshtrk);
            this.Controls.Add(this.comb_drivers);
            this.Controls.Add(this.lbl_drivername);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbldriverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldriverBindingSource1)).EndInit();
            this.gbx_eshtrk.ResumeLayout(false);
            this.gbx_eshtrk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator سرویسجدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتاولیهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem لیستمشترکینToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیسترانندگانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem راهنماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem راهنماToolStripMenuItem1;
        private System.Windows.Forms.Label lbl_drivername;
        private System.Windows.Forms.ComboBox comb_drivers;
        private System.Windows.Forms.RadioButton rbtn_nashnas;
        private System.Windows.Forms.RadioButton rbtn_eshtrak;
        private System.Windows.Forms.GroupBox gbx_eshtrk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_codeeshtrak;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_mabda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.TextBox tbx_family;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_phoneNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_sendservics;
        private System.Windows.Forms.Button btn_sendandprint;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ToolStripMenuItem اضافهکردنرانندهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_maghsad;
        private System.Windows.Forms.ToolStripMenuItem جستجوToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem رانندهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مشترکToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator دربارهنرمافزارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دربارهیماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تماسباماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private TaxiDBDataSet taxiDBDataSet;
        private System.Windows.Forms.BindingSource tbldriverBindingSource;
        private TaxiDBDataSetTableAdapters.tbl_driverTableAdapter tbl_driverTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_cost;
        private System.Windows.Forms.BindingSource tbldriverBindingSource1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.ToolStripMenuItem آمارروزانهToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem تغییررمزعبورToolStripMenuItem;
    }
}