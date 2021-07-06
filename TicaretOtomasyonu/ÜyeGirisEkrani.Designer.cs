namespace TicaretOtomasyonu
{
    partial class ÜyeGirisEkrani
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
            this.btnGirisYapÜye = new DevExpress.XtraEditors.SimpleButton();
            this.lblKullaniciAdiÜye = new DevExpress.XtraEditors.LabelControl();
            this.lblSifreÜye = new DevExpress.XtraEditors.LabelControl();
            this.isaratleme = new System.Windows.Forms.CheckBox();
            this.txtSifreÜye = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdiÜye = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGirisYapÜye
            // 
            this.btnGirisYapÜye.Appearance.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnGirisYapÜye.Appearance.BackColor2 = System.Drawing.Color.Tan;
            this.btnGirisYapÜye.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYapÜye.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnGirisYapÜye.Appearance.Options.UseBackColor = true;
            this.btnGirisYapÜye.Appearance.Options.UseFont = true;
            this.btnGirisYapÜye.Appearance.Options.UseForeColor = true;
            this.btnGirisYapÜye.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnGirisYapÜye.Location = new System.Drawing.Point(265, 331);
            this.btnGirisYapÜye.Name = "btnGirisYapÜye";
            this.btnGirisYapÜye.Size = new System.Drawing.Size(194, 61);
            this.btnGirisYapÜye.TabIndex = 7;
            this.btnGirisYapÜye.Text = "Giriş Yap";
            this.btnGirisYapÜye.Click += new System.EventHandler(this.btnGirisYapPersonel_Click);
            // 
            // lblKullaniciAdiÜye
            // 
            this.lblKullaniciAdiÜye.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdiÜye.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdiÜye.Appearance.Options.UseBackColor = true;
            this.lblKullaniciAdiÜye.Appearance.Options.UseFont = true;
            this.lblKullaniciAdiÜye.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblKullaniciAdiÜye.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblKullaniciAdiÜye.Location = new System.Drawing.Point(140, 177);
            this.lblKullaniciAdiÜye.Name = "lblKullaniciAdiÜye";
            this.lblKullaniciAdiÜye.Size = new System.Drawing.Size(122, 25);
            this.lblKullaniciAdiÜye.TabIndex = 15;
            this.lblKullaniciAdiÜye.Text = "Kullanıcı Adı :";
            // 
            // lblSifreÜye
            // 
            this.lblSifreÜye.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblSifreÜye.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreÜye.Appearance.Options.UseBackColor = true;
            this.lblSifreÜye.Appearance.Options.UseFont = true;
            this.lblSifreÜye.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSifreÜye.Location = new System.Drawing.Point(180, 254);
            this.lblSifreÜye.Name = "lblSifreÜye";
            this.lblSifreÜye.Size = new System.Drawing.Size(104, 25);
            this.lblSifreÜye.TabIndex = 16;
            this.lblSifreÜye.Text = "Şifre :";
            // 
            // isaratleme
            // 
            this.isaratleme.AutoSize = true;
            this.isaratleme.BackColor = System.Drawing.Color.Transparent;
            this.isaratleme.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isaratleme.Location = new System.Drawing.Point(514, 256);
            this.isaratleme.Name = "isaratleme";
            this.isaratleme.Size = new System.Drawing.Size(81, 25);
            this.isaratleme.TabIndex = 17;
            this.isaratleme.Text = "Göster";
            this.isaratleme.UseVisualStyleBackColor = false;
            this.isaratleme.CheckedChanged += new System.EventHandler(this.isaratleme_CheckedChanged);
            // 
            // txtSifreÜye
            // 
            this.txtSifreÜye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtSifreÜye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifreÜye.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreÜye.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSifreÜye.Location = new System.Drawing.Point(290, 252);
            this.txtSifreÜye.Multiline = true;
            this.txtSifreÜye.Name = "txtSifreÜye";
            this.txtSifreÜye.PasswordChar = '*';
            this.txtSifreÜye.Size = new System.Drawing.Size(202, 31);
            this.txtSifreÜye.TabIndex = 18;
            // 
            // txtKullaniciAdiÜye
            // 
            this.txtKullaniciAdiÜye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtKullaniciAdiÜye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdiÜye.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdiÜye.ForeColor = System.Drawing.SystemColors.Window;
            this.txtKullaniciAdiÜye.Location = new System.Drawing.Point(290, 177);
            this.txtKullaniciAdiÜye.Multiline = true;
            this.txtKullaniciAdiÜye.Name = "txtKullaniciAdiÜye";
            this.txtKullaniciAdiÜye.Size = new System.Drawing.Size(202, 31);
            this.txtKullaniciAdiÜye.TabIndex = 19;
            this.txtKullaniciAdiÜye.TextChanged += new System.EventHandler(this.txtKullaniciAdiÜye_TextChanged);
            // 
            // ÜyeGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::TicaretOtomasyonu.Properties.Resources._3f9e277767715730d50848270fab3662;
            this.ClientSize = new System.Drawing.Size(752, 553);
            this.Controls.Add(this.txtKullaniciAdiÜye);
            this.Controls.Add(this.txtSifreÜye);
            this.Controls.Add(this.isaratleme);
            this.Controls.Add(this.lblSifreÜye);
            this.Controls.Add(this.lblKullaniciAdiÜye);
            this.Controls.Add(this.btnGirisYapÜye);
            this.Name = "ÜyeGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜyeGirisi";
            this.Load += new System.EventHandler(this.ÜyeGirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnGirisYapÜye;
        private DevExpress.XtraEditors.LabelControl lblKullaniciAdiÜye;
        private DevExpress.XtraEditors.LabelControl lblSifreÜye;
        private System.Windows.Forms.CheckBox isaratleme;
        private System.Windows.Forms.TextBox txtSifreÜye;
        private System.Windows.Forms.TextBox txtKullaniciAdiÜye;
    }
}