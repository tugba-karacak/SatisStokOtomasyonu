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

namespace TugbaProjesi
{
    public partial class PersonelArayuz : Form
    {
        public PersonelArayuz()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void FormGetir(Form form)
        {
            pnlSayfalar.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Left;
            pnlSayfalar.Controls.Add(form);
            form.Show();
        }
        private void PersonelArayuz_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personeller.PersonelListele personelListele= new Personeller.PersonelListele();
            FormGetir(personelListele);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            UrunIslemleri.UrunEkle urunEkle = new UrunIslemleri.UrunEkle();
            FormGetir(urunEkle);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
