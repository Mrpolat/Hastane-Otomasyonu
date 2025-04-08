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

namespace HastaneOtomasyonu
{
    public partial class girisEkrani : Form
    {
        public girisEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(baglantisinifi.adres);
        SqlCommand cmd;
        SqlDataReader dr;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void girisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM ekrangiris where id='" + textBox1.Text + "'and parola='" + textBox2.Text + "'", baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                MessageBox.Show("Giriş Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menu a = new menu();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. Tekrar deneyiniz.");
            }
            baglanti.Close();
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.PasswordChar = '\0';
            }
            else 
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
