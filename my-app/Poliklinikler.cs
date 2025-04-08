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
using System.Data.Sql;

namespace HastaneOtomasyonu
{
    public partial class Poliklinikler : Form
    {
        public Poliklinikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(baglantisinifi.adres);
        DataTable tablo;

        private void Poliklinikler_Load(object sender, EventArgs e)
        {
            hastalar();
        }
         private void hastalar()
        {
            SqlDataAdapter listele = new SqlDataAdapter("select * from hastakayit", baglanti);
            DataSet dshafiza = new DataSet();
            listele.Fill(dshafiza);
            dataGridView1.DataSource = dshafiza.Tables[0];
            baglanti.Close(); 
        }
        public DataTable listeler(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        
        private void cmb_Poliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Poliklinik.SelectedIndex == 0)
                {
                    hastalar();
                    
                }
                if (cmb_Poliklinik.SelectedIndex == 1)
                {
                    string getir = "select *from hastakayit where poliklinik='Beslenme'";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);

                }
                if (cmb_Poliklinik.SelectedIndex == 2)
                {
                    string getir = "select *from hastakayit where poliklinik='Beyin ve Sinir Cerrahisi'";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);
                }
                if (cmb_Poliklinik.SelectedIndex == 3)
                {
                    string getir = "select *from hastakayit where poliklinik='Cildiye'";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);
                }
                if (cmb_Poliklinik.SelectedIndex == 4)
                {
                    string getir = "select *from hastakayit where poliklinik='Çocuk Cerrahi Hastalıkları'";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);
                }
                if (cmb_Poliklinik.SelectedIndex == 5)
                {
                    string getir = "select *from hastakayit where poliklinik='Diş'";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);
                }
                if (cmb_Poliklinik.SelectedIndex == 6)
                {
                    string getir = "select *from hastakayit where poliklinik='Fizik Tedavi ve Rehabilitasyon'";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);
                }
                if (cmb_Poliklinik.SelectedIndex == 7)
                {
                    string getir = "select *from hastakayit where poliklinik='Genel Cerrahi'";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);
                }
                if (cmb_Poliklinik.SelectedIndex == 8)
                {
                    string getir = "select *from hastakayit where poliklinik='Göğüs Hastalıkları'";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);
                }
                if (cmb_Poliklinik.SelectedIndex == 9)
                {
                    string getir = "select *from hastakayit where poliklinik='Kulak Burun Boğaz'";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);
                }
                if (cmb_Poliklinik.SelectedIndex == 10)
                {
                    string getir = "select *from hastakayit where poliklinik='Kardiyoloji '";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);
                }
                if (cmb_Poliklinik.SelectedIndex ==11)
                {
                    string getir = "select *from hastakayit where poliklinik='Nöroloji'";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);
                }

            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu a = new menu();
            a.Show();
            this.Hide();
        }
    }
}
