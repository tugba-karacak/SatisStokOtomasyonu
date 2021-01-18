using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugbaProjesi.UrunIslemleri
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        private const string ConnectionString = @"Data Source = DESKTOP-LCEGS46; Initial Catalog = TProje; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(ConnectionString);
        string resimPath;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resimPath = openFileDialog1.FileName.ToString();
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image!=null && textBox1.Text!="" && textBox2.Text!="" && textBox4.Text!="")
            {
                FileStream fileStream = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
                binaryReader.Close();
                fileStream.Close();

                
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string kayit = "insert into products(urunAdi,urunFiyati,urunAdedi,urunBilgisi,urunResmi, urunRenkSiyah,urunRenkMavi,urunRenkKirmizi,urunRenkYesil,urunBedenXS,urunBedenS,urunBedenM,urunBedenL,urunBedenXL,urunBedenXXL,urunBedenXXXL) values (@urunAdi,@urunFiyati,@urunAdedi,@urunBilgisi,@urunResmi,@urunRenkSiyah,@urunRenkMavi,@urunRenkKirmizi,@urunRenkYesil,@urunBedenXS,@urunBedenS,@urunBedenM,@urunBedenL,@urunBedenXL,@urunBedenXXL,@urunBedenXXXL)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.Add("@urunResmi", SqlDbType.Image, resim.Length).Value = resim;
                    komut.Parameters.AddWithValue("@urunAdi", textBox1.Text);
                    komut.Parameters.AddWithValue("@urunFiyati", textBox2.Text);
                    komut.Parameters.AddWithValue("@urunAdedi", numericUpDown12.Value);
                    komut.Parameters.AddWithValue("@urunBilgisi", textBox4.Text);
                    komut.Parameters.AddWithValue("@urunRenkSiyah", numericUpDown1.Value);
                    komut.Parameters.AddWithValue("@urunRenkMavi", numericUpDown2.Value);
                    komut.Parameters.AddWithValue("@urunRenkKirmizi", numericUpDown3.Value);
                    komut.Parameters.AddWithValue("@urunRenkYesil", numericUpDown4.Value);
                    komut.Parameters.AddWithValue("@urunBedenXS", numericUpDown5.Value);
                    komut.Parameters.AddWithValue("@urunBedenS", numericUpDown6.Value);
                    komut.Parameters.AddWithValue("@urunBedenM", numericUpDown7.Value);
                    komut.Parameters.AddWithValue("@urunBedenL", numericUpDown8.Value);
                    komut.Parameters.AddWithValue("@urunBedenXL", numericUpDown9.Value);
                    komut.Parameters.AddWithValue("@urunBedenXXL", numericUpDown10.Value);
                    komut.Parameters.AddWithValue("@urunBedenXXXL", numericUpDown11.Value);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti.");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Yukarıdaki alanlar boş bırakılamaz.");
            }

        }
    }
}
