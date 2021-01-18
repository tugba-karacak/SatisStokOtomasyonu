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

namespace TugbaProjesi.Personeller
{
    public partial class PersonelListele : Form
    {
        private const string ConnectionString = @"Data Source = DESKTOP-LCEGS46; Initial Catalog = TProje; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(ConnectionString);
        public PersonelListele()
        {
            InitializeComponent();
            personelListeleme();
        }

        private void personelListeleme()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from personnel", baglanti);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];
                ListViewItem listViewItem = new ListViewItem(dataRow["id"].ToString());
                listViewItem.SubItems.Add(dataRow["personelAdi"].ToString());
                listView1.Items.Add(listViewItem);
            }
        }
        private void personelGuncelle(int id)
        {
            //string sql = "update personnel set personelAdi=@personelAdi, personelSifre=@personelSifre where id=@id";
            //SqlCommand sqlCommand = new SqlCommand(sql, baglanti);
            //try
            //{
            //    baglanti.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                
            //    sqlDataAdapter.UpdateCommand.CommandText = sql;
            //    if (sqlDataAdapter.UpdateCommand.ExecuteNonQuery()>0)
            //    {
                    
            //    }
            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle();
            personelEkle.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            personelListeleme();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                if (listView1.SelectedItems.Count > 0)
                {
                if (MessageBox.Show("Personeli silmek istediğinize emin misiniz?", "Personeli Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    baglanti.Open();
                    string degisken = listView1.SelectedItems[0].Text;
                    SqlCommand cmd = new SqlCommand("delete from personnel Where id=@id", baglanti);
                    cmd.Parameters.AddWithValue("@id", degisken);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Personel silindi.");
                    listView1.Items.Clear();
                    personelListeleme();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz personeli seçiniz.");
            }
            
        }
    }
}
