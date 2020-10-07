namespace ticariotomasyon
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
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtekstra = new DevExpress.XtraEditors.TextEdit();
            this.cmbyıl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnksydet = new DevExpress.XtraEditors.SimpleButton();
            this.rchnotlar = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdogalgaz = new DevExpress.XtraEditors.TextEdit();
            this.txtnet = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaas = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtelektrik = new DevExpress.XtraEditors.TextEdit();
            this.txtsu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtekstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbyıl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdogalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtelektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1524, 705);
            this.gridControl1.TabIndex = 28;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btntemizle
            // 
            this.btntemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btntemizle.Appearance.Options.UseFont = true;
            this.btntemizle.Appearance.Options.UseForeColor = true;
            this.btntemizle.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.btntemizle.AppearanceHovered.Options.UseBackColor = true;
            this.btntemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizle.ImageOptions.Image")));
            this.btntemizle.Location = new System.Drawing.Point(128, 583);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(235, 41);
            this.btntemizle.TabIndex = 13;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(28, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 23);
            this.label11.TabIndex = 32;
            this.label11.Text = "Maaşlar :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(45, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Notlar :";
            // 
            // txtekstra
            // 
            this.txtekstra.Location = new System.Drawing.Point(127, 323);
            this.txtekstra.Name = "txtekstra";
            this.txtekstra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtekstra.Properties.Appearance.Options.UseFont = true;
            this.txtekstra.Size = new System.Drawing.Size(235, 28);
            this.txtekstra.TabIndex = 8;
            // 
            // cmbyıl
            // 
            this.cmbyıl.Location = new System.Drawing.Point(128, 114);
            this.cmbyıl.Name = "cmbyıl";
            this.cmbyıl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbyıl.Properties.Appearance.Options.UseFont = true;
            this.cmbyıl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbyıl.Properties.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cmbyıl.Size = new System.Drawing.Size(233, 28);
            this.cmbyıl.TabIndex = 2;
            // 
            // cmbay
            // 
            this.cmbay.Location = new System.Drawing.Point(128, 80);
            this.cmbay.Name = "cmbay";
            this.cmbay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbay.Properties.Appearance.Options.UseFont = true;
            this.cmbay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbay.Properties.Items.AddRange(new object[] {
            "Ocak ",
            "Şubat ",
            "Mart",
            "Nisan ",
            "Mayıs ",
            "Haziran ",
            "Temmuz ",
            "Ağustos ",
            "Eylül ",
            "Ekim ",
            "Kasım ",
            "Aralık"});
            this.cmbay.Size = new System.Drawing.Size(233, 28);
            this.cmbay.TabIndex = 1;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnguncelle.Appearance.Options.UseFont = true;
            this.btnguncelle.Appearance.Options.UseForeColor = true;
            this.btnguncelle.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.btnguncelle.AppearanceHovered.Options.UseBackColor = true;
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(127, 536);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(235, 41);
            this.btnguncelle.TabIndex = 12;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnsil.Appearance.Options.UseFont = true;
            this.btnsil.Appearance.Options.UseForeColor = true;
            this.btnsil.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.btnsil.AppearanceHovered.Options.UseBackColor = true;
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(127, 489);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(235, 41);
            this.btnsil.TabIndex = 11;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnksydet
            // 
            this.btnksydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnksydet.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnksydet.Appearance.Options.UseFont = true;
            this.btnksydet.Appearance.Options.UseForeColor = true;
            this.btnksydet.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.btnksydet.AppearanceHovered.Options.UseBackColor = true;
            this.btnksydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnksydet.ImageOptions.Image")));
            this.btnksydet.Location = new System.Drawing.Point(127, 442);
            this.btnksydet.Name = "btnksydet";
            this.btnksydet.Size = new System.Drawing.Size(233, 41);
            this.btnksydet.TabIndex = 10;
            this.btnksydet.Text = "Kaydet";
            this.btnksydet.Click += new System.EventHandler(this.btnksydet_Click);
            // 
            // rchnotlar
            // 
            this.rchnotlar.Location = new System.Drawing.Point(128, 357);
            this.rchnotlar.Name = "rchnotlar";
            this.rchnotlar.Size = new System.Drawing.Size(235, 79);
            this.rchnotlar.TabIndex = 9;
            this.rchnotlar.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(15, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Doğalgaz :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(72, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Su :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(41, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ekstra :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(24, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "İnternet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Elektrik :";
            // 
            // txtdogalgaz
            // 
            this.txtdogalgaz.Location = new System.Drawing.Point(128, 218);
            this.txtdogalgaz.Name = "txtdogalgaz";
            this.txtdogalgaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdogalgaz.Properties.Appearance.Options.UseFont = true;
            this.txtdogalgaz.Size = new System.Drawing.Size(234, 28);
            this.txtdogalgaz.TabIndex = 5;
            // 
            // txtnet
            // 
            this.txtnet.EditValue = "";
            this.txtnet.Location = new System.Drawing.Point(128, 254);
            this.txtnet.Name = "txtnet";
            this.txtnet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtnet.Properties.Appearance.Options.UseFont = true;
            this.txtnet.Size = new System.Drawing.Size(234, 28);
            this.txtnet.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(78, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ay :";
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(128, 287);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmaas.Properties.Appearance.Options.UseFont = true;
            this.txtmaas.Size = new System.Drawing.Size(234, 28);
            this.txtmaas.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yıl :";
            // 
            // txtid
            // 
            this.txtid.EditValue = "";
            this.txtid.Location = new System.Drawing.Point(127, 46);
            this.txtid.Name = "txtid";
            this.txtid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Properties.Appearance.Options.UseFont = true;
            this.txtid.Size = new System.Drawing.Size(234, 28);
            this.txtid.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtelektrik);
            this.groupControl1.Controls.Add(this.txtsu);
            this.groupControl1.Controls.Add(this.btntemizle);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txtekstra);
            this.groupControl1.Controls.Add(this.cmbyıl);
            this.groupControl1.Controls.Add(this.cmbay);
            this.groupControl1.Controls.Add(this.btnguncelle);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnksydet);
            this.groupControl1.Controls.Add(this.rchnotlar);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtdogalgaz);
            this.groupControl1.Controls.Add(this.txtnet);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtmaas);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(1532, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(391, 705);
            this.groupControl1.TabIndex = 29;
            // 
            // txtelektrik
            // 
            this.txtelektrik.Location = new System.Drawing.Point(128, 148);
            this.txtelektrik.Name = "txtelektrik";
            this.txtelektrik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtelektrik.Properties.Appearance.Options.UseFont = true;
            this.txtelektrik.Size = new System.Drawing.Size(234, 28);
            this.txtelektrik.TabIndex = 3;
            // 
            // txtsu
            // 
            this.txtsu.Location = new System.Drawing.Point(128, 184);
            this.txtsu.Name = "txtsu";
            this.txtsu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsu.Properties.Appearance.Options.UseFont = true;
            this.txtsu.Size = new System.Drawing.Size(234, 28);
            this.txtsu.TabIndex = 4;
            // 
            // frmgiderler
            // 
            this.AcceptButton = this.btnksydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btntemizle;
            this.ClientSize = new System.Drawing.Size(1924, 714);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmgiderler";
            this.Text = "GİDERLER";
            this.Load += new System.EventHandler(this.frmgiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtekstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbyıl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdogalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtelektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtekstra;
        private DevExpress.XtraEditors.ComboBoxEdit cmbyıl;
        private DevExpress.XtraEditors.ComboBoxEdit cmbay;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnksydet;
        private System.Windows.Forms.RichTextBox rchnotlar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtdogalgaz;
        private DevExpress.XtraEditors.TextEdit txtnet;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtmaas;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtid;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtelektrik;
        private DevExpress.XtraEditors.TextEdit txtsu;
    }
}