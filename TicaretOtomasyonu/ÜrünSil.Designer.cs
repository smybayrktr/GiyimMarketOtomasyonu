namespace TicaretOtomasyonu
{
    partial class ÜrünSil
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
            this.lblÜrünAdiSil = new DevExpress.XtraEditors.LabelControl();
            this.txtAdÜrünSil = new DevExpress.XtraEditors.TextEdit();
            this.SilmeTiki = new System.Windows.Forms.CheckBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdÜrünSil.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblÜrünAdiSil
            // 
            this.lblÜrünAdiSil.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.lblÜrünAdiSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÜrünAdiSil.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblÜrünAdiSil.Appearance.Options.UseBackColor = true;
            this.lblÜrünAdiSil.Appearance.Options.UseFont = true;
            this.lblÜrünAdiSil.Appearance.Options.UseForeColor = true;
            this.lblÜrünAdiSil.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblÜrünAdiSil.Location = new System.Drawing.Point(159, 160);
            this.lblÜrünAdiSil.Name = "lblÜrünAdiSil";
            this.lblÜrünAdiSil.Size = new System.Drawing.Size(104, 29);
            this.lblÜrünAdiSil.TabIndex = 20;
            this.lblÜrünAdiSil.Text = "Ürün Adı : ";
            // 
            // txtAdÜrünSil
            // 
            this.txtAdÜrünSil.Location = new System.Drawing.Point(269, 165);
            this.txtAdÜrünSil.Name = "txtAdÜrünSil";
            this.txtAdÜrünSil.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.txtAdÜrünSil.Properties.Appearance.Options.UseBackColor = true;
            this.txtAdÜrünSil.Size = new System.Drawing.Size(206, 22);
            this.txtAdÜrünSil.TabIndex = 21;
            // 
            // SilmeTiki
            // 
            this.SilmeTiki.AutoSize = true;
            this.SilmeTiki.Location = new System.Drawing.Point(412, 216);
            this.SilmeTiki.Name = "SilmeTiki";
            this.SilmeTiki.Size = new System.Drawing.Size(194, 21);
            this.SilmeTiki.TabIndex = 22;
            this.SilmeTiki.Text = "Silmek istediğimden eminim";
            this.SilmeTiki.UseVisualStyleBackColor = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(269, 268);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(154, 51);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "ÜRÜNÜ SİL";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ÜrünSil
            // 
            this.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 502);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.SilmeTiki);
            this.Controls.Add(this.txtAdÜrünSil);
            this.Controls.Add(this.lblÜrünAdiSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ÜrünSil";
            this.Text = "ÜrünSil";
            ((System.ComponentModel.ISupportInitialize)(this.txtAdÜrünSil.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblÜrünAdiSil;
        private DevExpress.XtraEditors.TextEdit txtAdÜrünSil;
        private System.Windows.Forms.CheckBox SilmeTiki;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}