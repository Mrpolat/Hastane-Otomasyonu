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
    public partial class TetkikBirimleri : Form
    {
        public TetkikBirimleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(baglantisinifi.adres);
        DataTable tablo;
        private void hastagoruntule()
        {
            SqlDataAdapter listele = new SqlDataAdapter("select * from hastakayit", baglanti);
            DataSet dshafiza = new DataSet();
            listele.Fill(dshafiza);
            dataGridView1.DataSource = dshafiza.Tables[0];
            baglanti.Close();
        }

        private void txtBox_hastatc_TextChanged(object sender, EventArgs e)
        {
            tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from hastakayit where tcno like '%" + txtBox_hastatc.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void TetkikBirimleri_Load(object sender, EventArgs e)
        {
            hastagoruntule();
        }

        private void btn_sonuckaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter duzenle = new SqlDataAdapter("update hastakayit set tetkik='" + cmb_tetkik.Text + "'where tcno='" + txtBox_hastatc.Text + "'", baglanti);
            SqlDataAdapter duzenle1 = new SqlDataAdapter("update hastakayit set sonuc='" + txtBox_sonuclar.Text + "'where tcno='" + txtBox_hastatc.Text + "'", baglanti);
            DataSet bellek = new DataSet();
            duzenle.Fill(bellek);
            duzenle1.Fill(bellek);
            baglanti.Close();
            MessageBox.Show("Hasta Sonuçları Eklendi");
            hastagoruntule(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow sec = dataGridView1.CurrentRow;
            txtBox_hastatc.Text = sec.Cells["tcno"].Value.ToString();
            //txtBox_birim.Text = sec.Cells["tetkik"].Value.ToString();
            //txtBox_sonuclar.Text = sec.Cells["sonuc"].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu a = new menu();
            a.Show();
            this.Hide();
        }
    }
}
