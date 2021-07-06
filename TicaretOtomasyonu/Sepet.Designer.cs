namespace TicaretOtomasyonu
{
    partial class Sepet
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
            this.dgwSepet = new System.Windows.Forms.DataGridView();
            this.btnSepetiOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.btnSepetiTemizle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSepet
            // 
            this.dgwSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSepet.Location = new System.Drawing.Point(50, 49);
            this.dgwSepet.Name = "dgwSepet";
            this.dgwSepet.RowTemplate.Height = 24;
            this.dgwSepet.Size = new System.Drawing.Size(556, 213);
            this.dgwSepet.TabIndex = 0;
            this.dgwSepet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSepet_CellContentClick);
            // 
            // btnSepetiOnayla
            // 
            this.btnSepetiOnayla.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSepetiOnayla.Location = new System.Drawing.Point(100, 296);
            this.btnSepetiOnayla.Name = "btnSepetiOnayla";
            this.btnSepetiOnayla.Size = new System.Drawing.Size(175, 57);
            this.btnSepetiOnayla.TabIndex = 1;
            this.btnSepetiOnayla.Text = "Sepeti Onayla";
            this.btnSepetiOnayla.Click += new System.EventHandler(this.btnSepetiOnayla_Click);
            // 
            // btnSepetiTemizle
            // 
            this.btnSepetiTemizle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSepetiTemizle.Location = new System.Drawing.Point(367, 296);
            this.btnSepetiTemizle.Name = "btnSepetiTemizle";
            this.btnSepetiTemizle.Size = new System.Drawing.Size(175, 57);
            this.btnSepetiTemizle.TabIndex = 2;
            this.btnSepetiTemizle.Text = "Ürünü Sepetten Çıkart";
            this.btnSepetiTemizle.Click += new System.EventHandler(this.btnSepetiTemizle_Click);
            // 
            // Sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 700);
            this.Controls.Add(this.btnSepetiTemizle);
            this.Controls.Add(this.btnSepetiOnayla);
            this.Controls.Add(this.dgwSepet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sepet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepet";
            ((System.ComponentModel.ISupportInitialize)(this.dgwSepet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSepet;
        private DevExpress.XtraEditors.SimpleButton btnSepetiOnayla;
        private DevExpress.XtraEditors.SimpleButton btnSepetiTemizle;
    }
}