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
    public partial class servis : Form
    {
        public servis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(baglantisinifi.adres);
        DataTable tablo;

        private void ziyaret()
        {
            SqlDataAdapter listele = new SqlDataAdapter("select * from veznekayit", baglanti);
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

        private void cmb_Servis_SelectedIndexChanged(object sender, EventArgs e)
        {
             try
            {
                if (cmb_Servis.SelectedIndex == 0)
                {
                    ziyaret();
                    
                }
                if (cmb_Servis.SelectedIndex == 1)
                {
                    string getir = "select *from veznekayit where servis='Dahiliye'";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);

                }
                if (cmb_Servis.SelectedIndex == 2)
                {
                    string getir = "select *from veznekayit where servis='Yoğun Bakım'";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);
                }
                if (cmb_Servis.SelectedIndex == 3)
                {
                    string getir = "select *from veznekayit where servis='Ameliyathane'";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);
                }
                if (cmb_Servis.SelectedIndex == 4)
                {
                    string getir = "select *from veznekayit where servis='Kadın Doğum'";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);
                }
                 if (cmb_Servis.SelectedIndex == 5)
                {
                    string getir = "select *from veznekayit where servis='Poliklinikler'";
                    SqlDataAdapter srg = new SqlDataAdapter();
                    dataGridView1.DataSource = listeler(srg, getir);

                }
                
               
               

            }
            catch
            {
        }
    }

        private void servis_Load(object sender, EventArgs e)
        {
            ziyaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu a = new menu();
            a.Show();
            this.Hide();
        }
}
}
