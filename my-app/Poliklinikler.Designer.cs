namespace HastaneOtomasyonu
{
    partial class Poliklinikler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_Poliklinik = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(22, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Poliklinik:";
            // 
            // cmb_Poliklinik
            // 
            this.cmb_Poliklinik.FormattingEnabled = true;
            this.cmb_Poliklinik.Items.AddRange(new object[] {
            "Hepsi",
            "Beslenme",
            "Beyin ve Sinir Cerrahisi",
            "Cildiye",
            "Çocuk Cerrahi Hastalıkları",
            "Diş",
            "Fizik Tedavi ve Rehabilitasyon",
            "Genel Cerrahi",
            "Göğüs Hastalıkları",
            "Kulak Burun Boğaz",
            "Kardiyoloji ",
            "Nöroloji"});
            this.cmb_Poliklinik.Location = new System.Drawing.Point(118, 64);
            this.cmb_Poliklinik.Name = "cmb_Poliklinik";
            this.cmb_Poliklinik.Size = new System.Drawing.Size(121, 24);
            this.cmb_Poliklinik.TabIndex = 19;
            this.cmb_Poliklinik.SelectedIndexChanged += new System.EventHandler(this.cmb_Poliklinik_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 235);
            this.dataGridView1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(345, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 59);
            this.button1.TabIndex = 21;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Poliklinikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_Poliklinik);
            this.Controls.Add(this.label9);
            this.Name = "Poliklinikler";
            this.Text = "Poliklinikler";
            this.Load += new System.EventHandler(this.Poliklinikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_Poliklinik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;

    }
}