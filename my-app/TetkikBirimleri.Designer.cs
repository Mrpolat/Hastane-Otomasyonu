namespace HastaneOtomasyonu
{
    partial class TetkikBirimleri
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
            this.cmb_tetkik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBox_hastatc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_sonuclar = new System.Windows.Forms.TextBox();
            this.btn_sonuckaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_birim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_tetkik
            // 
            this.cmb_tetkik.FormattingEnabled = true;
            this.cmb_tetkik.Items.AddRange(new object[] {
            " Tomografi",
            " Kemik Dansitometri",
            " Endoskopi",
            " Ultrason",
            " Röntgen",
            " Laboratuvar"});
            this.cmb_tetkik.Location = new System.Drawing.Point(497, 89);
            this.cmb_tetkik.Name = "cmb_tetkik";
            this.cmb_tetkik.Size = new System.Drawing.Size(121, 24);
            this.cmb_tetkik.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TetkikBirimleri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBox_hastatc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(33, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 379);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Takip";
            // 
            // txtBox_hastatc
            // 
            this.txtBox_hastatc.Location = new System.Drawing.Point(141, 46);
            this.txtBox_hastatc.Name = "txtBox_hastatc";
            this.txtBox_hastatc.Size = new System.Drawing.Size(154, 22);
            this.txtBox_hastatc.TabIndex = 2;
            this.txtBox_hastatc.TextChanged += new System.EventHandler(this.txtBox_hastatc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hasta Tc No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(340, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sonuçlar:";
            // 
            // txtBox_sonuclar
            // 
            this.txtBox_sonuclar.Location = new System.Drawing.Point(394, 208);
            this.txtBox_sonuclar.Multiline = true;
            this.txtBox_sonuclar.Name = "txtBox_sonuclar";
            this.txtBox_sonuclar.Size = new System.Drawing.Size(224, 169);
            this.txtBox_sonuclar.TabIndex = 4;
            // 
            // btn_sonuckaydet
            // 
            this.btn_sonuckaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sonuckaydet.Location = new System.Drawing.Point(394, 383);
            this.btn_sonuckaydet.Name = "btn_sonuckaydet";
            this.btn_sonuckaydet.Size = new System.Drawing.Size(224, 75);
            this.btn_sonuckaydet.TabIndex = 5;
            this.btn_sonuckaydet.Text = "Hasta Sonuçlarını Kaydet";
            this.btn_sonuckaydet.UseVisualStyleBackColor = true;
            this.btn_sonuckaydet.Click += new System.EventHandler(this.btn_sonuckaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birim:";
            // 
            // txtBox_birim
            // 
            this.txtBox_birim.Location = new System.Drawing.Point(450, 152);
            this.txtBox_birim.Name = "txtBox_birim";
            this.txtBox_birim.Size = new System.Drawing.Size(168, 22);
            this.txtBox_birim.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(529, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 63);
            this.button1.TabIndex = 8;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TetkikBirimleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_birim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_sonuckaydet);
            this.Controls.Add(this.txtBox_sonuclar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_tetkik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TetkikBirimleri";
            this.Text = "TetkikBirimleri";
            this.Load += new System.EventHandler(this.TetkikBirimleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_tetkik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_sonuclar;
        private System.Windows.Forms.TextBox txtBox_hastatc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sonuckaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_birim;
        private System.Windows.Forms.Button button1;
    }
}