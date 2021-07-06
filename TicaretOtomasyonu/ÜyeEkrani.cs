using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TicaretOtomasyonu.Classes;

namespace TicaretOtomasyonu
{
    public partial class ÜyeEkrani : Form
    {
        private int childFormNumber = 0;

        Dictionary<string, Form> dictionary;
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LSDB34O\\SQLSERVEREXPRESS; " +
           "initial catalog=DbETicaret; integrated security=TRUE");
        
        /*public List <Ürünler> Listele()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from tblÜrünler", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Ürünler> ürünler = new List<Ürünler>();
            while (reader.Read())
            {
                Ürünler ürün = new Ürünler()
                {
                    katagori = reader["Katagori"].ToString(),
                    ürünAdi = reader["ÜrünAdi"].ToString(),
                    beden = reader["Beden"].ToString(),
                    renk = reader["Renk"].ToString(),
                    fiyat = reader["Fiyat"].ToString()
                };
                ürünler.Add(ürün);
            }
            reader.Close();
            connection.Close();
            return ürünler;
        } */
        private void ConnectionControl()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

            }
        }

        public ÜyeEkrani()
        {
            InitializeComponent();
            dictionary = new Dictionary<string, Form>(); 
        }

        public void FormYükle(string isim)
        {
            Form form = null;
            if (dictionary.ContainsKey(isim))
            {
                form = this.dictionary[isim];
                form.WindowState = FormWindowState.Normal;
                form.Activate();
                Sakla();
            }
            else
            {
                switch(isim)
                {
                    case "Yelek":
                        form = new Yelek();
                        break;
                    case "Ayakkabi":
                        form = new Ayakkabi();
                        break;
                    case "Bileklik":
                        form = new Bileklik();
                        break;
                    case "Bluz":
                        form = new Bluz();
                        break;
                    case "Canta":
                        form = new Canta();
                        break;
                    case "Ceket":
                        form = new Ceket();
                        break;
                    case "Etek":
                        form = new Etek();
                        break;
                    case "Gömlek":
                        form = new Gömlek();
                        break;
                    case "Hirka":
                        form = new Hirka();
                        break;
                    case "İndirimSayfasi":
                        form = new İndirimSayfasi();
                        break;
                    case "Kaban":
                        form = new Kaban();
                        break;
                    case "Kap":
                        form = new Kap();
                        break;
                    case "Küpe":
                        form = new Küpe();
                        break;
                    case "Mont":
                        form = new Mont();
                        break;
                    case "Pantolon":
                        form = new Pantolon();
                        break;
                    case "Saat":
                        form = new Saat();
                        break;
                    case "Sepet":
                        form = new Sepet();
                        break;
                    case "SweatShirt":
                        form = new SweatShirt();
                        break;
                    case "Tshirt":
                        form = new Tshirt();
                        break;
                    case "Tunik":
                        form = new Tunik();
                        break;
                    case "ÜyeGüncelle":
                        form = new ÜyeGüncelle();
                        break;
                    case "ÜyeliktenAyril":
                        form = new ÜyeliktenAyril();
                        break;
                    case "DarPaca":
                        form = new DarPaca();
                        break;
                    case "BolPantolon":
                        form = new BolPantolon();
                        break;

                }
                dictionary.Add(isim, form);
                form.MdiParent= this;
                form.Show();
                Sakla();
            }

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Pencere " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void ÜyeEkrani_Load(object sender, EventArgs e)
        {

        }

        private void iNDİRİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("İndirimSayfasi");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void hırkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          FormYükle("Hirka");
           
        }
        public void Sakla()
        {
            xtrÜyeEkrani.Hide();
            Kaydirici.Hide();
            ResimKutusu.Hide();
            ResimKutusu2.Hide();
            btnKesfet1.Hide();
            btnKesfet2.Hide();
        } 
        

        private void yelekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("Yelek");
           
        }

        private void sweatShirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
         FormYükle("SweatShirt");
        }

        private void tunikToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormYükle("Tunik");
        }

        private void gömlekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("Gömlek");
        }

        private void bluzToolStripMenuItem_Click(object sender, EventArgs e)
        {
         FormYükle("Bluz");
        }

        private void tshirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FormYükle("Tshirt");
        }

        private void montToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormYükle("Mont");
        }

        private void kabanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("Kaban");
        }

        private void ceketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("Ceket");
        }

        private void kapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("Kap");
        }

        private void küpeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("Küpe");
        }

        private void bileklikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("Bileklik");
        }

        private void saatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("Saat");
        }

        private void çantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("Canta");
        }

        private void ayakkabıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("Ayakkabi");
        }

        private void üyeBilgileriniGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("ÜyeGüncelle");
        }

        private void sepetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("Sepet");
            
        }

        private void üyeliktenAyrılToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("ÜyeliktenAyril");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarıyla Çıkış Yaptınız. Bizi Tercih Ettiğiniz İçin Teşekkürler.");
            AnaEkran anaEkran = new AnaEkran();
            this.Close();
            anaEkran.Show();
        }

        private void pantolonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("Pantolon");
        }

        private void etekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("Etek");
        }

        private void xtraUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dışGiyimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void darPaçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormYükle("DarPaca");
        }

        private void bolPantolonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYükle("BolPantolon");
        }

        private void btnKesfet1_Click(object sender, EventArgs e)
        {
            FormYükle("İndirimSayfasi");
        }

        private void btnKesfet2_Click(object sender, EventArgs e)
        {
            FormYükle("Hirka");
        }
    }
}
