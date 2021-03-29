using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vezneHastaKabul a = new vezneHastaKabul();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Poliklinikler a = new Poliklinikler();
            a.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            servis a = new servis();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TetkikBirimleri a = new TetkikBirimleri();
            a.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            eczaneDepo a = new eczaneDepo();
            a.Show();
            this.Hide();
        }
    }
}
