using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugbaProjesi
{
    public partial class KullaniciArayuz : Form
    {
        public KullaniciArayuz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunIslemleri.Urunler urunler = new UrunIslemleri.Urunler();
            urunler.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            KullaniciGirisi kullaniciGirisi = new KullaniciGirisi();
            kullaniciGirisi.ShowDialog();
            this.Close();
        }
    }
}
