using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugbaProjesi
{
    public partial class KullaniciSifreDegis : Form
    {
        public KullaniciSifreDegis()
        {
            InitializeComponent();
        }
        private const string ConnectionString = @"Data Source = DESKTOP-LCEGS46; Initial Catalog = TProje; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(ConnectionString);

        private void veriler()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from users", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["kullaniciAdi"].ToString());
                ekle.SubItems.Add(oku["kullaniciSifre"].ToString());
            }
            baglanti.Close();
        }
        int id = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text!="" && textBox3.Text!="" )
            {
                if (textBox2.Text == textBox3.Text)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update users set kullaniciAdi=@kullaniciAdi,kullaniciSifre=@kullaniciSifre where id=" + id + "", baglanti);
                    komut.Parameters.AddWithValue("@kullaniciAdi", textBox1.Text);
                    komut.Parameters.AddWithValue("@kullaniciSifre", textBox2.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    veriler();
                    MessageBox.Show("Şifre başarıyla değiştirildi.");
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor!!!");
                }
            }
            else
            {
                MessageBox.Show("Yukardaki alanlar boş bırakılamaz.");
            }
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SifreDegis_Load(object sender, EventArgs e)
        {
            veriler();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox2.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                textBox3.UseSystemPasswordChar = false;
                checkBox2.Text = "Gizle";
            }
            else if (checkBox2.CheckState == CheckState.Unchecked)
            {
                textBox3.UseSystemPasswordChar = true;
                checkBox2.Text = "Göster";
            }
        }
    }
}
