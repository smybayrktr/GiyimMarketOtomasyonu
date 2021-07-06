namespace TicaretOtomasyonu
{
    partial class Yelek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yelek));
            this.ımageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.btnYelekSepeteEkle = new DevExpress.XtraEditors.SimpleButton();
            this.bedenYelek = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.lblFiyat = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lblÜrünAd = new DevExpress.XtraEditors.LabelControl();
            this.xtraUserControl2 = new DevExpress.XtraEditors.XtraUserControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.renkYelek = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedenYelek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renkYelek.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageSlider1
            // 
            this.ımageSlider1.CurrentImageIndex = 0;
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images1"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images2"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images3"))));
            this.ımageSlider1.Location = new System.Drawing.Point(57, 37);
            this.ımageSlider1.Name = "ımageSlider1";
            this.ımageSlider1.Size = new System.Drawing.Size(211, 235);
            this.ımageSlider1.TabIndex = 117;
            this.ımageSlider1.Text = "ımageSlider1";
            // 
            // btnYelekSepeteEkle
            // 
            this.btnYelekSepeteEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnYelekSepeteEkle.Location = new System.Drawing.Point(90, 413);
            this.btnYelekSepeteEkle.Name = "btnYelekSepeteEkle";
            this.btnYelekSepeteEkle.Size = new System.Drawing.Size(119, 32);
            this.btnYelekSepeteEkle.TabIndex = 116;
            this.btnYelekSepeteEkle.Text = "Sepete Ekle";
            this.btnYelekSepeteEkle.Click += new System.EventHandler(this.btnYelekSepeteEkle_Click);
            // 
            // bedenYelek
            // 
            this.bedenYelek.Location = new System.Drawing.Point(143, 346);
            this.bedenYelek.Name = "bedenYelek";
            this.bedenYelek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bedenYelek.Properties.Items.AddRange(new object[] {
            "36",
            "38",
            "40",
            "42",
            "44"});
            this.bedenYelek.Size = new System.Drawing.Size(125, 22);
            this.bedenYelek.TabIndex = 115;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.Location = new System.Drawing.Point(43, 340);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(70, 28);
            this.labelControl15.TabIndex = 114;
            this.labelControl15.Text = "Beden :";
            // 
            // lblFiyat
            // 
            this.lblFiyat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Appearance.Options.UseFont = true;
            this.lblFiyat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFiyat.Location = new System.Drawing.Point(143, 307);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(125, 28);
            this.lblFiyat.TabIndex = 113;
            this.lblFiyat.Text = "165";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(43, 306);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(70, 28);
            this.labelControl8.TabIndex = 112;
            this.labelControl8.Text = "Fiyat :";
            // 
            // lblÜrünAd
            // 
            this.lblÜrünAd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÜrünAd.Appearance.Options.UseFont = true;
            this.lblÜrünAd.Location = new System.Drawing.Point(43, 278);
            this.lblÜrünAd.Name = "lblÜrünAd";
            this.lblÜrünAd.Size = new System.Drawing.Size(225, 22);
            this.lblÜrünAd.TabIndex = 111;
            this.lblÜrünAd.Text = "Fermuarlı Çıtçıtlı Şişme Yelek";
            // 
            // xtraUserControl2
            // 
            this.xtraUserControl2.Appearance.BackColor = System.Drawing.SystemColors.Menu;
            this.xtraUserControl2.Appearance.Options.UseBackColor = true;
            this.xtraUserControl2.Location = new System.Drawing.Point(30, 23);
            this.xtraUserControl2.Name = "xtraUserControl2";
            this.xtraUserControl2.Size = new System.Drawing.Size(271, 437);
            this.xtraUserControl2.TabIndex = 110;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(43, 368);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 28);
            this.labelControl1.TabIndex = 118;
            this.labelControl1.Text = "Renk :";
            // 
            // renkYelek
            // 
            this.renkYelek.Location = new System.Drawing.Point(143, 374);
            this.renkYelek.Name = "renkYelek";
            this.renkYelek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.renkYelek.Properties.Items.AddRange(new object[] {
            "Siyah ",
            "Bej"});
            this.renkYelek.Size = new System.Drawing.Size(125, 22);
            this.renkYelek.TabIndex = 119;
            // 
            // Yelek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 700);
            this.Controls.Add(this.renkYelek);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ımageSlider1);
            this.Controls.Add(this.btnYelekSepeteEkle);
            this.Controls.Add(this.bedenYelek);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.lblÜrünAd);
            this.Controls.Add(this.xtraUserControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Yelek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yelek";
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedenYelek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renkYelek.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider1;
        private DevExpress.XtraEditors.SimpleButton btnYelekSepeteEkle;
        private DevExpress.XtraEditors.ComboBoxEdit bedenYelek;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl lblFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl lblÜrünAd;
        private DevExpress.XtraEditors.XtraUserControl xtraUserControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit renkYelek;
    }
}