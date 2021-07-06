namespace TicaretOtomasyonu
{
    partial class ÜrünEkle
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
            this.xtrPersonelEkrani = new DevExpress.XtraEditors.XtraUserControl();
            this.btnResim = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdÜrün = new DevExpress.XtraEditors.TextEdit();
            this.txtRenkÜrün = new DevExpress.XtraEditors.TextEdit();
            this.cbKatagoriÜrün = new System.Windows.Forms.ComboBox();
            this.cbBedenÜrün = new System.Windows.Forms.ComboBox();
            this.cbKDVÜrün = new System.Windows.Forms.ComboBox();
            this.txtFiyatÜrün = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydetÜrün = new DevExpress.XtraEditors.SimpleButton();
            this.resimEkraniÜye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdÜrün.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenkÜrün.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyatÜrün.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimEkraniÜye)).BeginInit();
            this.SuspendLayout();
            // 
            // xtrPersonelEkrani
            // 
            this.xtrPersonelEkrani.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.xtrPersonelEkrani.Appearance.Options.UseBackColor = true;
            this.xtrPersonelEkrani.Location = new System.Drawing.Point(-4, 0);
            this.xtrPersonelEkrani.Name = "xtrPersonelEkrani";
            this.xtrPersonelEkrani.Size = new System.Drawing.Size(706, 502);
            this.xtrPersonelEkrani.TabIndex = 6;
            this.xtrPersonelEkrani.Load += new System.EventHandler(this.xtrPersonelEkrani_Load);
            // 
            // btnResim
            // 
            this.btnResim.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResim.Appearance.Options.UseFont = true;
            this.btnResim.Location = new System.Drawing.Point(83, 261);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(130, 48);
            this.btnResim.TabIndex = 8;
            this.btnResim.Text = "Resim Seç";
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Options.UseBackColor = true;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(298, 54);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(104, 29);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Katagori : ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.Appearance.Options.UseBackColor = true;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(317, 237);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(104, 29);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Fiyat :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl9.Appearance.Options.UseBackColor = true;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(317, 192);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(71, 28);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Renk : ";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl10.Appearance.Options.UseBackColor = true;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.Location = new System.Drawing.Point(317, 144);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(71, 29);
            this.labelControl10.TabIndex = 12;
            this.labelControl10.Text = "Beden : ";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl11.Appearance.Options.UseBackColor = true;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.Location = new System.Drawing.Point(298, 99);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(104, 29);
            this.labelControl11.TabIndex = 13;
            this.labelControl11.Text = "Ürün Adı : ";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl12.Appearance.Options.UseBackColor = true;
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.Location = new System.Drawing.Point(317, 280);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(104, 29);
            this.labelControl12.TabIndex = 14;
            this.labelControl12.Text = "KDV :";
            // 
            // txtAdÜrün
            // 
            this.txtAdÜrün.Location = new System.Drawing.Point(392, 104);
            this.txtAdÜrün.Name = "txtAdÜrün";
            this.txtAdÜrün.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.txtAdÜrün.Properties.Appearance.Options.UseBackColor = true;
            this.txtAdÜrün.Size = new System.Drawing.Size(206, 22);
            this.txtAdÜrün.TabIndex = 15;
            // 
            // txtRenkÜrün
            // 
            this.txtRenkÜrün.Location = new System.Drawing.Point(392, 197);
            this.txtRenkÜrün.Name = "txtRenkÜrün";
            this.txtRenkÜrün.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.txtRenkÜrün.Properties.Appearance.Options.UseBackColor = true;
            this.txtRenkÜrün.Size = new System.Drawing.Size(206, 22);
            this.txtRenkÜrün.TabIndex = 16;
            // 
            // cbKatagoriÜrün
            // 
            this.cbKatagoriÜrün.BackColor = System.Drawing.Color.Silver;
            this.cbKatagoriÜrün.FormattingEnabled = true;
            this.cbKatagoriÜrün.Items.AddRange(new object[] {
            "Hırka",
            "Yelek",
            "SweatShirt",
            "Tunik",
            "Gömlek",
            "Bluz",
            "Tshirt",
            "Pantolon",
            "Bol Pantolon",
            "Dar Paça",
            "Etek",
            "Mont",
            "Kaban",
            "Ceket",
            "Kap",
            "Küpe",
            "Bileklik",
            "Saat",
            "Çanta",
            "Ayakkabı",
            "İndirim"});
            this.cbKatagoriÜrün.Location = new System.Drawing.Point(392, 59);
            this.cbKatagoriÜrün.Name = "cbKatagoriÜrün";
            this.cbKatagoriÜrün.Size = new System.Drawing.Size(206, 24);
            this.cbKatagoriÜrün.TabIndex = 17;
            // 
            // cbBedenÜrün
            // 
            this.cbBedenÜrün.BackColor = System.Drawing.Color.Silver;
            this.cbBedenÜrün.FormattingEnabled = true;
            this.cbBedenÜrün.Items.AddRange(new object[] {
            "XXS",
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXL",
            "34",
            "36",
            "38",
            "40",
            "42",
            "44",
            "Standart"});
            this.cbBedenÜrün.Location = new System.Drawing.Point(392, 149);
            this.cbBedenÜrün.Name = "cbBedenÜrün";
            this.cbBedenÜrün.Size = new System.Drawing.Size(206, 24);
            this.cbBedenÜrün.TabIndex = 18;
            // 
            // cbKDVÜrün
            // 
            this.cbKDVÜrün.BackColor = System.Drawing.Color.Silver;
            this.cbKDVÜrün.FormattingEnabled = true;
            this.cbKDVÜrün.Items.AddRange(new object[] {
            "1",
            "8",
            "18"});
            this.cbKDVÜrün.Location = new System.Drawing.Point(392, 276);
            this.cbKDVÜrün.Name = "cbKDVÜrün";
            this.cbKDVÜrün.Size = new System.Drawing.Size(206, 24);
            this.cbKDVÜrün.TabIndex = 19;
            // 
            // txtFiyatÜrün
            // 
            this.txtFiyatÜrün.Location = new System.Drawing.Point(392, 242);
            this.txtFiyatÜrün.Name = "txtFiyatÜrün";
            this.txtFiyatÜrün.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.txtFiyatÜrün.Properties.Appearance.Options.UseBackColor = true;
            this.txtFiyatÜrün.Size = new System.Drawing.Size(206, 22);
            this.txtFiyatÜrün.TabIndex = 20;
            // 
            // btnKaydetÜrün
            // 
            this.btnKaydetÜrün.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydetÜrün.Appearance.Options.UseFont = true;
            this.btnKaydetÜrün.Location = new System.Drawing.Point(354, 341);
            this.btnKaydetÜrün.Name = "btnKaydetÜrün";
            this.btnKaydetÜrün.Size = new System.Drawing.Size(155, 50);
            this.btnKaydetÜrün.TabIndex = 21;
            this.btnKaydetÜrün.Text = "KAYDET";
            this.btnKaydetÜrün.Click += new System.EventHandler(this.btnKaydetÜrün_Click);
            // 
            // resimEkraniÜye
            // 
            this.resimEkraniÜye.Location = new System.Drawing.Point(39, 54);
            this.resimEkraniÜye.Name = "resimEkraniÜye";
            this.resimEkraniÜye.Size = new System.Drawing.Size(225, 189);
            this.resimEkraniÜye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimEkraniÜye.TabIndex = 7;
            this.resimEkraniÜye.TabStop = false;
            // 
            // ÜrünEkle
            // 
            this.ClientSize = new System.Drawing.Size(701, 502);
            this.Controls.Add(this.btnKaydetÜrün);
            this.Controls.Add(this.txtFiyatÜrün);
            this.Controls.Add(this.cbKDVÜrün);
            this.Controls.Add(this.cbBedenÜrün);
            this.Controls.Add(this.cbKatagoriÜrün);
            this.Controls.Add(this.txtRenkÜrün);
            this.Controls.Add(this.txtAdÜrün);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.resimEkraniÜye);
            this.Controls.Add(this.xtrPersonelEkrani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ÜrünEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtAdÜrün.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenkÜrün.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyatÜrün.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimEkraniÜye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private DevExpress.XtraEditors.XtraUserControl xtrPersonelEkrani;
        private System.Windows.Forms.PictureBox resimEkraniÜye;
        private DevExpress.XtraEditors.SimpleButton btnResim;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtAdÜrün;
        private DevExpress.XtraEditors.TextEdit txtRenkÜrün;
        private System.Windows.Forms.ComboBox cbKatagoriÜrün;
        private System.Windows.Forms.ComboBox cbBedenÜrün;
        private System.Windows.Forms.ComboBox cbKDVÜrün;
        private DevExpress.XtraEditors.TextEdit txtFiyatÜrün;
        private DevExpress.XtraEditors.SimpleButton btnKaydetÜrün;
    }
}