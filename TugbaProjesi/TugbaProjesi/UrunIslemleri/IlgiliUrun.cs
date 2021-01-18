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
using TugbaProjesi.Classlar;

namespace TugbaProjesi.UrunIslemleri
{
    public partial class IlgiliUrun : Form
    {
        int urunId;
        List<Urun> urunler;
        public IlgiliUrun(int _urunId)
        {
            InitializeComponent();
            urunler = new List<Urun>();
            urunId = _urunId;
        }
        private const string ConnectionString = @"Data Source = DESKTOP-LCEGS46; Initial Catalog = TProje; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(ConnectionString);

        private void IlgiliUrun_Load(object sender, EventArgs e)
        {
            labelGetir(urunId);
            resimGetir(urunId);
            bedenGetir(urunId);
        }
        private void resimGetir(int id)
        {
            string urunResmiSorgusu ="select urunResmi from products where urunId="+id;
            SqlCommand komutUrunResmiSorgusu = new SqlCommand(urunResmiSorgusu, baglanti);
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komutUrunResmiSorgusu);
            da.Fill(dataTable);
            byte[] img = (byte[])dataTable.Rows[0][0];
            MemoryStream memoryStream = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(memoryStream);
            da.Dispose();
        }
        private void labelGetir(int id)
        {
            string urunAdiSorgusu = "Select urunAdi from products where urunId="+id;
            string urunFiyatiSorgusu = "Select urunFiyati from products where urunId="+id;
            string urunBilgisiSorgusu = "Select urunBilgisi from products where urunId="+id;
            string urunAdi = "";
            string urunFiyati = "";
            string urunBilgisi = "";
            SqlCommand komutUrunAdi = new SqlCommand(urunAdiSorgusu, baglanti);
            SqlCommand komutUrunFiyati = new SqlCommand(urunFiyatiSorgusu, baglanti);
            SqlCommand komutUrunBilgisi = new SqlCommand(urunBilgisiSorgusu, baglanti);
            baglanti.Open();
            urunAdi = (string)komutUrunAdi.ExecuteScalar();
            urunFiyati = (string)komutUrunFiyati.ExecuteScalar();
            urunBilgisi = (string)komutUrunBilgisi.ExecuteScalar();
            baglanti.Close();
            label3.Text = urunAdi;
            label4.Text = urunFiyati ;
            label5.Text = "Ürünün bilgisi : " + urunBilgisi;
        }
        private void bedenGetir(int id)
        {
           
            string urunBedenXS= "Select urunBedenXS from products where urunId="+id;
            string urunBedenS = "Select urunBedenS from products where urunId="+id;
            string urunBedenM = "Select urunBedenM from products where urunId="+id;
            string urunBedenL = "Select urunBedenL from products where urunId="+id;
            string urunBedenXL = "Select urunBedenXL from products where urunId="+id;
            string urunBedenXXL = "Select urunBedenXXL from products where urunId="+id;
            string urunBedenXXXL = "Select urunBedenXXXL from products where urunId="+id;
            string urunRenkSiyah= "Select urunRenkSiyah from products where urunId=" + id;
            string urunRenkMavi= "Select urunRenkMavi from products where urunId=" + id;
            string urunRenkKirmizi= "Select urunRenkKirmizi from products where urunId=" + id;
            string urunRenkYesil= "Select urunRenkYesil from products where urunId=" + id;
            SqlCommand komutUrunBedenXS = new SqlCommand(urunBedenXS, baglanti);
            SqlCommand komuturunBedenS = new SqlCommand(urunBedenS, baglanti);
            SqlCommand komutUrunBedenM = new SqlCommand(urunBedenM, baglanti);
            SqlCommand komutUrunBedenL = new SqlCommand(urunBedenL, baglanti);
            SqlCommand komutUrunBedenXL = new SqlCommand(urunBedenXL, baglanti);
            SqlCommand komutUrunBedenXXL = new SqlCommand(urunBedenXXL, baglanti);
            SqlCommand komutUrunBedenXXXL = new SqlCommand(urunBedenXXXL, baglanti);
            SqlCommand komutRenkSiyah = new SqlCommand(urunRenkSiyah, baglanti);
            SqlCommand komutRenkMavi = new SqlCommand(urunRenkMavi, baglanti);
            SqlCommand komutRenkKirmizi = new SqlCommand(urunRenkKirmizi, baglanti);
            SqlCommand komutRenkYesil = new SqlCommand(urunRenkYesil, baglanti);
            string bedenXS ="";
            string bedenS = "";
            string bedenM = "";
            string bedenL = "";
            string bedenXL = "";
            string bedenXXL = "";
            string bedenXXXL = "";
            string renkSiyah = "";
            string renkMavi = "";
            string renkKirmizi = "";
            string renkYesil = "";
            baglanti.Open();
            bedenXS = (string) komutUrunBedenXS.ExecuteScalar();
            bedenS = (string)komuturunBedenS.ExecuteScalar();
            bedenM = (string)komutUrunBedenM.ExecuteScalar();
            bedenL = (string)komutUrunBedenL.ExecuteScalar();
            bedenXL = (string)komutUrunBedenXL.ExecuteScalar();
            bedenXXL = (string)komutUrunBedenXXL.ExecuteScalar();
            bedenXXXL = (string)komutUrunBedenXXXL.ExecuteScalar();
            renkSiyah = (string)komutRenkSiyah.ExecuteScalar();
            renkMavi = (string)komutRenkMavi.ExecuteScalar();
            renkKirmizi = (string)komutRenkKirmizi.ExecuteScalar();
            renkYesil = (string)komutRenkYesil.ExecuteScalar();
            baglanti.Close();
            int xs = Convert.ToInt32(bedenXS);
            if (xs==0)
            {
                radioButton1.Enabled = false;
            }
            else
            {
                radioButton1.Enabled = true;
            }
            int s = Convert.ToInt32(bedenS);
            if (s == 0)
            {
                radioButton2.Enabled = false;
            }
            else
            {
                radioButton2.Enabled = true;
            }
            int m = Convert.ToInt32(bedenM);
            if (m == 0)
            {
                radioButton3.Enabled = false;
            }
            else
            {
                radioButton3.Enabled = true;
            }
            int l = Convert.ToInt32(bedenL);
            if (l == 0)
            {
                radioButton4.Enabled = false;
            }
            else
            {
                radioButton4.Enabled = true;
            }
            int xl = Convert.ToInt32(bedenXL);
            if (xl == 0)
            {
                radioButton5.Enabled = false;
            }
            else
            {
                radioButton5.Enabled = true;
            }
            int xxl = Convert.ToInt32(bedenXXL);
            if (xxl == 0)
            {
                radioButton6.Enabled = false;
            }
            else
            {
                radioButton6.Enabled = true;
            }
            int xxxl = Convert.ToInt32(bedenXXXL);
            if (xxxl == 0)
            {
                radioButton7.Enabled = false;
            }
            else
            {
                radioButton7.Enabled = true;
            }
            int siyah = Convert.ToInt32(renkSiyah);
            if (siyah == 0)
            {
                radioButton8.Enabled = false;
            }
            else
            {
                radioButton8.Enabled = true;
            }
            int mavi = Convert.ToInt32(renkMavi);
            if (mavi == 0)
            {
                radioButton9.Enabled = false;
            }
            else
            {
                radioButton9.Enabled = true;
            }
            int kirmizi = Convert.ToInt32(renkKirmizi);
            if (kirmizi == 0)
            {
                radioButton10.Enabled = false;
            }
            else
            {
                radioButton10.Enabled = true;
            }
            int yesil = Convert.ToInt32(renkYesil);
            if (yesil == 0)
            {
                radioButton11.Enabled = false;
            }
            else
            {
                radioButton11.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SqlCommand komut = new SqlCommand("Update products set urunBedenXS=urunBedenXS-1 where urunId=@urunId", baglanti);
                komut.Parameters.AddWithValue("@urunId", urunId);
                SqlCommand komut1 = new SqlCommand("insert into cart(SepettekiUrunAdi,SepettekiUrunFiyati) values (@SepettekiUrunAdi,@SepettekiUrunFiyati)", baglanti);
                komut1.Parameters.AddWithValue("@SepettekiUrunAdi", label3.Text);
                komut1.Parameters.AddWithValue("@SepettekiUrunFiyati", label4.Text);
                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut1.ExecuteNonQuery();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }

                finally
                {
                    MessageBox.Show("Sepete eklendi.");
                    baglanti.Close();
                    this.Close();
                }
            }
            if (radioButton2.Checked)
            {
                SqlCommand komut = new SqlCommand("Update products set urunBedenS=urunBedenS-1 where urunId=@urunId", baglanti);
                komut.Parameters.AddWithValue("@urunId", urunId);
                SqlCommand komut1 = new SqlCommand("insert into cart(SepettekiUrunAdi,SepettekiUrunFiyati) values (@SepettekiUrunAdi,@SepettekiUrunFiyati)", baglanti);
                komut1.Parameters.AddWithValue("@SepettekiUrunAdi", label3.Text);
                komut1.Parameters.AddWithValue("@SepettekiUrunFiyati", label4.Text);
                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut1.ExecuteNonQuery();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }

                finally
                {
                    MessageBox.Show("Sepete eklendi.");
                    baglanti.Close();
                    this.Close();
                }
            }
            if (radioButton3.Checked)
            {
                SqlCommand komut = new SqlCommand("Update products set urunBedenM=urunBedenM-1 where urunId=@urunId", baglanti);
                komut.Parameters.AddWithValue("@urunId", urunId);
                SqlCommand komut1 = new SqlCommand("insert into cart(SepettekiUrunAdi,SepettekiUrunFiyati) values (@SepettekiUrunAdi,@SepettekiUrunFiyati)", baglanti);
                komut1.Parameters.AddWithValue("@SepettekiUrunAdi", label3.Text);
                komut1.Parameters.AddWithValue("@SepettekiUrunFiyati", label4.Text);
                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut1.ExecuteNonQuery();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }

                finally
                {
                    MessageBox.Show("Sepete eklendi.");
                    baglanti.Close();
                    this.Close();
                }
            }
            if (radioButton4.Checked)
            {
                SqlCommand komut = new SqlCommand("Update products set urunBedenL=urunBedenL-1 where urunId=@urunId", baglanti);
                komut.Parameters.AddWithValue("@urunId", urunId);
                SqlCommand komut1 = new SqlCommand("insert into cart(SepettekiUrunAdi,SepettekiUrunFiyati) values (@SepettekiUrunAdi,@SepettekiUrunFiyati)", baglanti);
                komut1.Parameters.AddWithValue("@SepettekiUrunAdi", label3.Text);
                komut1.Parameters.AddWithValue("@SepettekiUrunFiyati", label4.Text);
                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut1.ExecuteNonQuery();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }

                finally
                {
                    MessageBox.Show("Sepete eklendi.");
                    baglanti.Close();
                    this.Close();
                }
            }
            if (radioButton5.Checked)
            {
                SqlCommand komut = new SqlCommand("Update products set urunBedenXL=urunBedenXL-1 where urunId=@urunId", baglanti);
                komut.Parameters.AddWithValue("@urunId", urunId);
                SqlCommand komut1 = new SqlCommand("insert into cart(SepettekiUrunAdi,SepettekiUrunFiyati) values (@SepettekiUrunAdi,@SepettekiUrunFiyati)", baglanti);
                komut1.Parameters.AddWithValue("@SepettekiUrunAdi", label3.Text);
                komut1.Parameters.AddWithValue("@SepettekiUrunFiyati", label4.Text);
                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut1.ExecuteNonQuery();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }

                finally
                {
                    MessageBox.Show("Sepete eklendi.");
                    baglanti.Close();
                    this.Close();
                }
            }
            if (radioButton6.Checked)
            {
                SqlCommand komut = new SqlCommand("Update products set urunBedenXXL=urunBedenXXL-1 where urunId=@urunId", baglanti);
                komut.Parameters.AddWithValue("@urunId", urunId);
                SqlCommand komut1 = new SqlCommand("insert into cart(SepettekiUrunAdi,SepettekiUrunFiyati) values (@SepettekiUrunAdi,@SepettekiUrunFiyati)", baglanti);
                komut1.Parameters.AddWithValue("@SepettekiUrunAdi", label3.Text);
                komut1.Parameters.AddWithValue("@SepettekiUrunFiyati", label4.Text);
                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut1.ExecuteNonQuery();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }

                finally
                {
                    MessageBox.Show("Sepete eklendi.");
                    baglanti.Close();
                    this.Close();
                }
            }
            if (radioButton7.Checked)
            {
                SqlCommand komut = new SqlCommand("Update products set urunBedenXXXL=urunBedenXXXL-1 where urunId=@urunId", baglanti);
                komut.Parameters.AddWithValue("@urunId", urunId);
                SqlCommand komut1 = new SqlCommand("insert into cart(SepettekiUrunAdi,SepettekiUrunFiyati) values (@SepettekiUrunAdi,@SepettekiUrunFiyati)", baglanti);
                komut1.Parameters.AddWithValue("@SepettekiUrunAdi", label3.Text);
                komut1.Parameters.AddWithValue("@SepettekiUrunFiyati", label4.Text);
                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut1.ExecuteNonQuery();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }

                finally
                {
                    MessageBox.Show("Sepete eklendi.");
                    baglanti.Close();
                    this.Close();
                }
            }
            if (radioButton8.Checked)
            {
                SqlCommand komut = new SqlCommand("Update products set urunRenkSiyah=urunRenkSiyah-1 where urunId=@urunId", baglanti);
                komut.Parameters.AddWithValue("@urunId", urunId);
                SqlCommand komut1 = new SqlCommand("insert into cart(SepettekiUrunAdi,SepettekiUrunFiyati) values (@SepettekiUrunAdi,@SepettekiUrunFiyati)", baglanti);
                komut1.Parameters.AddWithValue("@SepettekiUrunAdi", label3.Text);
                komut1.Parameters.AddWithValue("@SepettekiUrunFiyati", label4.Text);
                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut1.ExecuteNonQuery();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }

                finally
                {
                    baglanti.Close();
                    this.Close();
                }
            }
            if (radioButton9.Checked)
            {
                SqlCommand komut = new SqlCommand("Update products set urunRenkMavi=urunRenkMavi-1 where urunId=@urunId", baglanti);
                komut.Parameters.AddWithValue("@urunId", urunId);
                SqlCommand komut1 = new SqlCommand("insert into cart(SepettekiUrunAdi,SepettekiUrunFiyati) values (@SepettekiUrunAdi,@SepettekiUrunFiyati)", baglanti);
                komut1.Parameters.AddWithValue("@SepettekiUrunAdi", label3.Text);
                komut1.Parameters.AddWithValue("@SepettekiUrunFiyati", label4.Text);
                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut1.ExecuteNonQuery();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }

                finally
                {
                    baglanti.Close();
                    this.Close();
                }
            }
            if (radioButton10.Checked)
            {
                SqlCommand komut = new SqlCommand("Update products set urunRenkKirmizi=urunRenkKirmizi-1 where urunId=@urunId", baglanti);
                komut.Parameters.AddWithValue("@urunId", urunId);
                SqlCommand komut1 = new SqlCommand("insert into cart(SepettekiUrunAdi,SepettekiUrunFiyati) values (@SepettekiUrunAdi,@SepettekiUrunFiyati)", baglanti);
                komut1.Parameters.AddWithValue("@SepettekiUrunAdi", label3.Text);
                komut1.Parameters.AddWithValue("@SepettekiUrunFiyati", label4.Text);
                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut1.ExecuteNonQuery();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }

                finally
                {
                    baglanti.Close();
                    this.Close();
                }
            }
            if (radioButton11.Checked)
            {
                SqlCommand komut = new SqlCommand("Update products set urunRenkYesil=urunRenkYesil-1 where urunId=@urunId", baglanti);
                komut.Parameters.AddWithValue("@urunId", urunId);
                SqlCommand komut1 = new SqlCommand("insert into cart(SepettekiUrunAdi,SepettekiUrunFiyati) values (@SepettekiUrunAdi,@SepettekiUrunFiyati)", baglanti);
                komut1.Parameters.AddWithValue("@SepettekiUrunAdi", label3.Text);
                komut1.Parameters.AddWithValue("@SepettekiUrunFiyati", label4.Text);
                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut1.ExecuteNonQuery();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }

                finally
                {
                    baglanti.Close();
                    this.Close();
                }
            }
        }
    }
}
