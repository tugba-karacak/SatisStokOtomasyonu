using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TugbaProjesi.Classlar;

namespace TugbaProjesi.UrunIslemleri
{
    public partial class Urunler : Form
    {
        List<Urun> urunler;
        public Urunler()
        {
            InitializeComponent();
            urunler = new List<Urun>();
            urunOlustur();
            
        }
        private const string ConnectionString = @"Data Source = DESKTOP-LCEGS46; Initial Catalog = TProje; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(ConnectionString);
        private void urunOlustur()
        {
            byte[] bosByte = new byte[]{};
            string urunSayisiSorgusu = "SELECT * FROM products";
            SqlCommand komutUrunSayisi= new SqlCommand(urunSayisiSorgusu, baglanti);
            baglanti.Open();
            SqlDataReader reader= komutUrunSayisi.ExecuteReader();
            while (reader.Read())
            {
                Urun tmp = new Urun();
                tmp.UrunId = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                tmp.UrunAdi = (string)reader[1];
                tmp.UrunFiyati = (string)reader[2];
                tmp.UrunBilgisi = (string)reader[3];
                tmp.Resim = (byte[])reader[4];

                urunler.Add(tmp);
            }
            reader.Close();
            baglanti.Close();
            
            int panelSayisi =10;
            int baslaX = 25;
            int baslaY = 10;
            int boyutBol;
            boyutBol = Convert.ToInt32(Math.Ceiling(Math.Sqrt(panelSayisi)));
            foreach (var urun in urunler)
            {
                Panel pnl = new Panel();
               
                pnl.Name = "panel_" + urun.UrunId.ToString();
                pnl.Size = new Size(this.Width / boyutBol, this.Height  / (boyutBol/2)); 
                pnl.AutoSize = false;
                pnl.BackColor = Color.Black;
                pnl.TabIndex = 1;
                pnl.Location = new Point(baslaX,baslaY);

                Label lblFiyat = new Label();
                lblFiyat.AutoSize = false;
                lblFiyat.Dock = DockStyle.Bottom;
                lblFiyat.TabIndex = 3;
                lblFiyat.Size = new Size(229,20);
                lblFiyat.Name = "label_" + urun.UrunId.ToString();
                lblFiyat.Text = "Fiyat : " + urun.UrunFiyati.ToString() + " TL";
                lblFiyat.TextAlign = ContentAlignment.MiddleCenter;
                lblFiyat.BackColor = Color.Transparent;
                lblFiyat.ForeColor = Color.White;
                lblFiyat.Font = new Font(lblFiyat.Font.FontFamily.Name, 10);

                Label lblIsim = new Label();
                lblIsim.AutoSize = false;
                lblIsim.Dock = DockStyle.Top;
                lblIsim.TabIndex = 3;
                lblIsim.Size = new Size(229, 20);
                lblIsim.Name = "label_" + urun.UrunId.ToString();
                lblIsim.Text = urun.UrunAdi.ToString();
                lblIsim.TextAlign = ContentAlignment.MiddleCenter;
                lblIsim.BackColor = Color.Transparent;
                lblIsim.ForeColor = Color.White;
                lblIsim.Font = new Font(lblIsim.Font.FontFamily.Name, 10);

                PictureBox pbox = new PictureBox();
                pbox.Name = "pictureBox_" + urun.UrunId.ToString();
                pbox.Dock = DockStyle.Fill;
                pbox.BackColor = Color.Black;
                pbox.TabIndex = 2;
                pbox.TabStop = false;
                pbox.Tag = urun;
                pbox.Click += Pbox_Click;
                MemoryStream ms = new MemoryStream(urun.Resim);
                Image image = Image.FromStream(ms);
                ms.Close();
                pbox.Image = image;
                pbox.SizeMode = PictureBoxSizeMode.StretchImage;

                pnl.Controls.Add(lblIsim);
                pnl.Controls.Add(pbox);
                pnl.Controls.Add(lblFiyat);
                panel_.Controls.Add(pnl);
                baslaX += pnl.Width + 20;
                if (baslaX+this.Width/boyutBol>this.Width)
                {
                    baslaX = 25;
                    baslaY += this.Height/2+25;
                }
                
            }
        }

        private void Pbox_Click(object sender, EventArgs e)
        {
            PictureBox yakalanPbox = (PictureBox)sender;
            Urun yakalanUrun = (Urun)yakalanPbox.Tag;
            IlgiliUrun ilgiliUrun = new IlgiliUrun(yakalanUrun.UrunId);
            ilgiliUrun.Show();
        }
        
    }
}
