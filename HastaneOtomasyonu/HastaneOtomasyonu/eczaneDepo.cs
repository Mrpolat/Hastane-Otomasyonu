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
    public partial class eczaneDepo : Form
    {
        public eczaneDepo()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(baglantisinifi.adres);
        SqlCommand cmd;
        private void rB_eczane_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_eczane.Checked == true)
            {
                gB_eczane.Enabled = true;
                gB_depo.Enabled = false; 
            }
            else if (rB_depo.Checked==true)
            {
                gB_depo.Enabled = true;
                gB_eczane.Enabled = false;
            }
            else
            {
                gB_eczane.Enabled = false;
                gB_depo.Enabled = false;  
            }
        }

        private void eczaneDepo_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Distinct ilac from eczane", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                
                cmb_mevcutilac.Items.Add(read["ilac"]);
                
            }
            baglanti.Close();
        }

        private void btn_teminet_Click(object sender, EventArgs e)
        {   //deneme amaçlı  kod 
            //if (VarMi(cmb_ilac.Text) != 0)
            //{
            //    MessageBox.Show("Bu ilaç stoklarda mevcut ");
            //}
            //else
            //{
            // baglanti.Open();
            //SqlDataAdapter kaydet = new SqlDataAdapter("INSERT INTO eczane(eczanead,ilac,adet) VALUES ('" + cmb_eczane.Text + "','" + cmb_ilac.Text + "','" + nud_adet.Value.ToString() + "')", baglanti);
            //DataSet dshafiza = new DataSet();
            //kaydet.Fill(dshafiza);
            //baglanti.Close();
            //MessageBox.Show("İlaç Temin Edildi");
                
            //}
             int aa, bb;
            string a = (String)cmb_eczane.Text.ToString();
            string b = (String)cmb_ilac.Text.ToString();

            aa = a.Length;
            bb = b.Length;
            if (aa == 0 || bb == 0)
            {
                MessageBox.Show("eczane veya ilac girişlerinin doğru olduğunu kontrol ediniz");
            }
            else if (nud_adet.Value.ToString() == "0")
            {
                MessageBox.Show("0 adet ilac sipariş edemezsiniz");
            }
            else
            {
                baglanti.Open();
                SqlDataAdapter kaydet = new SqlDataAdapter("INSERT INTO eczane(eczanead,ilac,adet) VALUES ('" + cmb_eczane.Text + "','" + cmb_ilac.Text + "','" + nud_adet.Value.ToString() + "')", baglanti);
                DataSet dshafiza = new DataSet();
                kaydet.Fill(dshafiza);
                baglanti.Close();
                MessageBox.Show(cmb_eczane.Text+"nden "+nud_adet.Value.ToString()+" adet "+cmb_ilac.Text+" temin edildi ");
                
            }
            Refresh();
             
        }

        private void cmb_mevcutilac_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DENEME AMAÇLI YAZILMIŞ İF ve ELSE İF KODU ASIL KOD ELSE nin içinde yazılmış kod. 
            string secim = cmb_mevcutilac.SelectedItem.ToString();
            if (secim == "EXALON")
            {
     
                lbl_durum.Text = "Bilgi : 25 Adet bu ilaçtan var";

            }
            else if (secim == "PATANOL")
            {

                lbl_durum.Text = "Bilgi : 103 Adet bu ilaçtan var";

            }
            else if (secim == "MAXIDEX")
            {

                lbl_durum.Text = "Bilgi : 75 Adet bu ilaçtan var";

            }
            else
            {
                baglanti.Open();

                SqlCommand cmd = new SqlCommand("select sum(adet) from eczane ", baglanti);
                int toplam = int.Parse(cmd.ExecuteScalar().ToString());
                lbl_durum.Text = "Bilgi : " + toplam.ToString() + " Adet bu ilaçtan var";

                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu a = new menu();
            a.Show();
            this.Hide();
        }

        private void lbl_durum_Click(object sender, EventArgs e)
        {

        }

        

        //deneme amaçlı kod 
        //public int VarMi(string aranan)
        //{
        //    int sonuc;
            
        //    string sorgu = "Select * from eczane WHERE ilac='" + aranan + "'";
        //     cmd = new SqlCommand(sorgu, baglanti);
        //    baglanti.Open();

        //    sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());

        //    baglanti.Close();
        //    return sonuc;
            

        //}
        
        
    }
}
