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
    public partial class vezneHastaKabul : Form
    {
        public vezneHastaKabul()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(baglantisinifi.adres);
        private void hastagoruntule()
        {
            SqlDataAdapter listele = new SqlDataAdapter("select * from hastakayit", baglanti);
            DataSet dshafiza = new DataSet();
            listele.Fill(dshafiza);
            dataGridView1.DataSource = dshafiza.Tables[0];
            baglanti.Close();     
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow sec = dataGridView1.CurrentRow;
            txtBox_tc.Text = sec.Cells["tcno"].Value.ToString();
            txtBox_ad.Text = sec.Cells["adı"].Value.ToString();
            txtBox_soyad.Text = sec.Cells["soyadı"].Value.ToString();
            dT_dogumtarihi.Text = sec.Cells["dogumtarihi"].Value.ToString();
            txtBox_yas.Text = sec.Cells["yas"].Value.ToString();
            txtBox_telefon.Text = sec.Cells["telefon"].Value.ToString();
            txtBox_adres.Text = sec.Cells["adres"].Value.ToString();
            cmb_Sigorta.Text= sec.Cells["sigortadurumu"].Value.ToString();
            cmb_Poliklinik.Text= sec.Cells["poliklinik"].Value.ToString();
            txtBox_anneadı.Text = sec.Cells["anneadı"].Value.ToString();
            txtBox_babaadı.Text = sec.Cells["babaadı"].Value.ToString();
            //if (sec.Cells["cinsiyet"].Selected == true && sec.Cells["cinsiyet"].Value.ToString() == "Erkek")
            //{
            //    radioButton1.Checked = true;
            //}
            //else
            //{
            //    radioButton2.Checked = true;
            //}
            //if (sec.Cells["sigortamevcut"].Selected == true && sec.Cells["sigortamevcut"].Value.ToString() == "Mevcut")
            //{
            //    rB_Var.Checked = true;
            //}
            //else
            //{
            //    rB_Yok.Checked = true;
            //}
           
        }

        private void vezneHastaKabul_Load(object sender, EventArgs e)
        {
            hastagoruntule();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            string cinsiyet;

            if (radioButton1.Checked == true)
            {
                cinsiyet = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                cinsiyet = radioButton2.Text;
            }
            else{
                cinsiyet = "Belirtilmedi";
            }

            string sigorta;
            if (rB_Var.Checked == true)
            {
                sigorta = "Mevcut";
            }
            else if (rB_Yok.Checked == true)
            {
                sigorta = "Yok";
            }
            else
            {
                sigorta = "Belirtilmedi";
            }
            SqlDataAdapter kaydet = new SqlDataAdapter("INSERT INTO hastakayit(tcno,adı,soyadı,dogumtarihi,yas,cinsiyet,telefon,adres,sigortamevcut,sigortadurumu,poliklinik,anneadı,babaadı,tetkik,sonuc) VALUES ('" + txtBox_tc.Text + "','" + txtBox_ad.Text + "','" + txtBox_soyad.Text + "','" + dT_dogumtarihi.Text + "','" + txtBox_yas.Text + "','" + cinsiyet + "','" + txtBox_telefon.Text + "','" + txtBox_adres.Text + "','" + sigorta + "','" + cmb_Sigorta.SelectedItem.ToString() + "','" + cmb_Poliklinik.SelectedItem.ToString() + "','" + txtBox_anneadı.Text + "','" + txtBox_babaadı.Text + "','" + "Girilmedi" + "','" + "Sonuc Yok"+ "')", baglanti);
            DataSet dshafiza = new DataSet();
            kaydet.Fill(dshafiza);
            baglanti.Close();
            MessageBox.Show("Hasta Eklendi");
            hastagoruntule();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter sil = new SqlDataAdapter("delete from hastakayit where tcno='" + txtBox_tc.Text + "'", baglanti);
            DataSet dshafiza = new DataSet();
            sil.Fill(dshafiza);
            baglanti.Close();
            MessageBox.Show("Hasta Silindi");
            hastagoruntule();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            baglanti.Open();
            string cinsiyet;

            if (radioButton1.Checked == true)
            {
                cinsiyet = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                cinsiyet = radioButton2.Text;
            }
            else{
                cinsiyet = "Belirtilmedi";
            }

            string sigorta;
            if (rB_Var.Checked == true)
            {
                sigorta = "Mevcut";
            }
            else if (rB_Yok.Checked == true)
            {
                sigorta = "Yok";
            }
            else
            {
                sigorta = "Belirtilmedi";
            }
            SqlDataAdapter duzenle = new SqlDataAdapter("update hastakayit set adı='" + txtBox_ad.Text + "'where tcno='" + txtBox_tc.Text + "'", baglanti);
            SqlDataAdapter duzenle2 = new SqlDataAdapter("update hastakayit set soyadı='" + txtBox_soyad.Text + "'where tcno='" + txtBox_tc.Text + "'", baglanti);
            SqlDataAdapter duzenle3 = new SqlDataAdapter("update hastakayit set dogumtarihi='" + dT_dogumtarihi.Text + "'where tcno='" + txtBox_tc.Text + "'", baglanti);
            SqlDataAdapter duzenle10 = new SqlDataAdapter("update hastakayit set yas='" + txtBox_yas.Text + "'where tcno='" + txtBox_tc.Text + "'", baglanti);
            SqlDataAdapter duzenle4 = new SqlDataAdapter("update hastakayit set cinsiyet='" + cinsiyet  + "'where tcno='" + txtBox_tc.Text + "'", baglanti);
            SqlDataAdapter duzenle5 = new SqlDataAdapter("update hastakayit set telefon='" + txtBox_telefon.Text + "'where tcno='" + txtBox_tc.Text + "'", baglanti);
            SqlDataAdapter duzenle6 = new SqlDataAdapter("update hastakayit set adres='" + txtBox_adres.Text + "'where tcno='" + txtBox_tc.Text + "'", baglanti);
            SqlDataAdapter duzenle7 = new SqlDataAdapter("update hastakayit set sigortamevcut='" + sigorta + "'where tcno='" + txtBox_tc.Text + "'", baglanti);
            SqlDataAdapter duzenle8 = new SqlDataAdapter("update hastakayit set sigortadurumu='" + cmb_Sigorta.SelectedItem.ToString() + "'where tcno='" + txtBox_tc.Text + "'", baglanti);
            SqlDataAdapter duzenle9 = new SqlDataAdapter("update hastakayit set poliklinik='" + cmb_Poliklinik.SelectedItem.ToString() + "'where tcno='" + txtBox_tc.Text + "'", baglanti);
            DataSet bellek = new DataSet();
            duzenle.Fill(bellek);
            duzenle2.Fill(bellek);
            duzenle3.Fill(bellek);
            duzenle4.Fill(bellek);
            duzenle5.Fill(bellek);
            duzenle6.Fill(bellek);
            duzenle7.Fill(bellek);
            duzenle8.Fill(bellek);
            duzenle9.Fill(bellek);
            duzenle10.Fill(bellek);
            baglanti.Close();
            MessageBox.Show("Düzenleme Başarılı");
            hastagoruntule();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu a = new menu();
            a.Show();
            this.Hide();
        }

        private void txtBox_adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void rB_hastakayit_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_hastakayit.Checked == true)
            {
                grupBox_Hasta.Enabled = true;
            }
            else
                grupBox_Hasta.Enabled = false;
        }

        private void rB_Vezne_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_Vezne.Checked == true)
            {
                grupBox_vezne.Enabled = true;
            }
            else
                grupBox_vezne.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            cmb_Oda.ResetText();
            cmb_Oda.Items.Clear();
            
            cmb_Oda.Enabled = true;
            
            
            string secim = cmb_Servis.SelectedItem.ToString();
            if (secim == "Dahiliye")
            {
                string[] oda = { "101", "102", "103" };
                cmb_Oda.Items.AddRange(oda);
                lbl_Kat.Text = "Kat= 0 ";
            }
            if (secim == "Yoğun Bakım")
            {
                string[] oda = { "201", "202","203","204","205" };
                cmb_Oda.Items.AddRange(oda);
                lbl_Kat.Text = "Kat= 3 ";
            }
            if (secim == "Ameliyathane")
            {
                cmb_Oda.Enabled = false;
                    lbl_Kat.Text = "Kat= 4 ";
            }

            if (secim == "Kadın Doğum")
            {
                string[] oda = { "401", "402", "403", };
                cmb_Oda.Items.AddRange(oda);
                lbl_Kat.Text = "Kat= 2 ";

            }
            if (secim == "Poliklinikler")
            {
                cmb_Oda.Enabled=false;
                lbl_Kat.Text = "Kat= 1 ";

            }
        }

        private void grupBox_vezne_Enter(object sender, EventArgs e)
        {

        }

        private void grupBox_Hasta_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter kaydet = new SqlDataAdapter("INSERT INTO veznekayit(adı,soyadı,tarih,servis,oda) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + Convert.ToDateTime(dateTimePicker1.Text) + "','" + cmb_Servis.Text + "','" + cmb_Oda.Text +  "')", baglanti);
            DataSet dshafiza = new DataSet();
            kaydet.Fill(dshafiza);
            baglanti.Close();
            MessageBox.Show("Kayıt Oluşturuldu");
             
        }

        
    }
}
