namespace Ticari_Otamasyon
{
    partial class frmgiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgiderler));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtsu = new DevExpress.XtraEditors.TextEdit();
            this.txtelektrik = new DevExpress.XtraEditors.TextEdit();
            this.txtnot = new System.Windows.Forms.RichTextBox();
            this.txtektra = new DevExpress.XtraEditors.TextEdit();
            this.txtmaas = new DevExpress.XtraEditors.TextEdit();
            this.txtint = new DevExpress.XtraEditors.TextEdit();
            this.txtyil = new System.Windows.Forms.ComboBox();
            this.txtay = new System.Windows.Forms.ComboBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtdogalgaz = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtelektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtektra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdogalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(5, 4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1031, 506);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btntemizle
            // 
            this.btntemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Appearance.Options.UseFont = true;
            this.btntemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizle.ImageOptions.Image")));
            this.btntemizle.Location = new System.Drawing.Point(130, 467);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(151, 29);
            this.btntemizle.TabIndex = 28;
            this.btntemizle.Text = "TEMİZLE";
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtsu);
            this.groupControl1.Controls.Add(this.txtelektrik);
            this.groupControl1.Controls.Add(this.txtnot);
            this.groupControl1.Controls.Add(this.txtektra);
            this.groupControl1.Controls.Add(this.txtmaas);
            this.groupControl1.Controls.Add(this.txtint);
            this.groupControl1.Controls.Add(this.txtyil);
            this.groupControl1.Controls.Add(this.txtay);
            this.groupControl1.Controls.Add(this.btntemizle);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btnguncelle);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.txtdogalgaz);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1039, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(327, 501);
            this.groupControl1.TabIndex = 6;
            // 
            // txtsu
            // 
            this.txtsu.Location = new System.Drawing.Point(129, 144);
            this.txtsu.Name = "txtsu";
            this.txtsu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsu.Properties.Appearance.Options.UseFont = true;
            this.txtsu.Size = new System.Drawing.Size(151, 24);
            this.txtsu.TabIndex = 4;
            // 
            // txtelektrik
            // 
            this.txtelektrik.Location = new System.Drawing.Point(129, 114);
            this.txtelektrik.Name = "txtelektrik";
            this.txtelektrik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtelektrik.Properties.Appearance.Options.UseFont = true;
            this.txtelektrik.Size = new System.Drawing.Size(151, 24);
            this.txtelektrik.TabIndex = 3;
            // 
            // txtnot
            // 
            this.txtnot.Location = new System.Drawing.Point(130, 306);
            this.txtnot.Name = "txtnot";
            this.txtnot.Size = new System.Drawing.Size(151, 50);
            this.txtnot.TabIndex = 9;
            this.txtnot.Text = "";
            // 
            // txtektra
            // 
            this.txtektra.Location = new System.Drawing.Point(130, 276);
            this.txtektra.Name = "txtektra";
            this.txtektra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtektra.Properties.Appearance.Options.UseFont = true;
            this.txtektra.Size = new System.Drawing.Size(151, 24);
            this.txtektra.TabIndex = 8;
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(131, 238);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmaas.Properties.Appearance.Options.UseFont = true;
            this.txtmaas.Size = new System.Drawing.Size(151, 24);
            this.txtmaas.TabIndex = 7;
            // 
            // txtint
            // 
            this.txtint.Location = new System.Drawing.Point(130, 208);
            this.txtint.Name = "txtint";
            this.txtint.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtint.Properties.Appearance.Options.UseFont = true;
            this.txtint.Size = new System.Drawing.Size(151, 24);
            this.txtint.TabIndex = 6;
            // 
            // txtyil
            // 
            this.txtyil.FormattingEnabled = true;
            this.txtyil.Items.AddRange(new object[] {
            "2017",
            "2018"});
            this.txtyil.Location = new System.Drawing.Point(129, 88);
            this.txtyil.Name = "txtyil";
            this.txtyil.Size = new System.Drawing.Size(151, 21);
            this.txtyil.TabIndex = 2;
            // 
            // txtay
            // 
            this.txtay.FormattingEnabled = true;
            this.txtay.Items.AddRange(new object[] {
            "OCAK",
            "SUBAT",
            "MART",
            "NİSAN",
            "MAYIS",
            "HAZİRAN",
            "TEMMUZ",
            "AGUSTOS",
            "EYLUL ",
            "EKİM",
            "KASIM",
            "ARALIK"});
            this.txtay.Location = new System.Drawing.Point(130, 61);
            this.txtay.Name = "txtay";
            this.txtay.Size = new System.Drawing.Size(151, 21);
            this.txtay.TabIndex = 1;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(47, 279);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(58, 18);
            this.labelControl11.TabIndex = 26;
            this.labelControl11.Text = "EKSTRA:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(37, 241);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(68, 18);
            this.labelControl10.TabIndex = 25;
            this.labelControl10.Text = "MAASLAR:";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Appearance.Options.UseFont = true;
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(130, 434);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(151, 29);
            this.btnguncelle.TabIndex = 20;
            this.btnguncelle.Text = "GUNCELLE";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Appearance.Options.UseFont = true;
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(130, 399);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(151, 29);
            this.btnsil.TabIndex = 19;
            this.btnsil.Text = "SİL";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Appearance.Options.UseFont = true;
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(130, 364);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(151, 29);
            this.btnkaydet.TabIndex = 10;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtdogalgaz
            // 
            this.txtdogalgaz.Location = new System.Drawing.Point(130, 178);
            this.txtdogalgaz.Name = "txtdogalgaz";
            this.txtdogalgaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdogalgaz.Properties.Appearance.Options.UseFont = true;
            this.txtdogalgaz.Size = new System.Drawing.Size(151, 24);
            this.txtdogalgaz.TabIndex = 5;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(47, 321);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(61, 18);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "NOTLAR:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(32, 208);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(76, 18);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "İNTERNET:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(29, 182);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(79, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "DOGALGAZ:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(85, 146);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(23, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "SU:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(37, 114);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "ELEKTRİK:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(80, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "YIL:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(84, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "AY:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(130, 27);
            this.txtid.Name = "txtid";
            this.txtid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Properties.Appearance.Options.UseFont = true;
            this.txtid.Size = new System.Drawing.Size(151, 24);
            this.txtid.TabIndex = 100;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(87, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // frmgiderler
            // 
            this.AcceptButton = this.btnkaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btntemizle;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmgiderler";
            this.Text = "GİDERLER";
            this.Load += new System.EventHandler(this.frmgiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtelektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtektra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdogalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.TextEdit txtdogalgaz;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtektra;
        private DevExpress.XtraEditors.TextEdit txtmaas;
        private DevExpress.XtraEditors.TextEdit txtint;
        private System.Windows.Forms.ComboBox txtyil;
        private System.Windows.Forms.ComboBox txtay;
        private System.Windows.Forms.RichTextBox txtnot;
        private DevExpress.XtraEditors.TextEdit txtsu;
        private DevExpress.XtraEditors.TextEdit txtelektrik;
    }
}