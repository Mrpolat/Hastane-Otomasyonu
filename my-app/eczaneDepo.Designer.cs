namespace HastaneOtomasyonu
{
    partial class eczaneDepo
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
            this.gB_eczane = new System.Windows.Forms.GroupBox();
            this.lbl_durum = new System.Windows.Forms.Label();
            this.cmb_mevcutilac = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_teminet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_eczane = new System.Windows.Forms.ComboBox();
            this.cmb_ilac = new System.Windows.Forms.ComboBox();
            this.nud_adet = new System.Windows.Forms.NumericUpDown();
            this.gB_depo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rB_eczane = new System.Windows.Forms.RadioButton();
            this.rB_depo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.gB_eczane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_adet)).BeginInit();
            this.gB_depo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_eczane
            // 
            this.gB_eczane.Controls.Add(this.btn_teminet);
            this.gB_eczane.Controls.Add(this.label4);
            this.gB_eczane.Controls.Add(this.label3);
            this.gB_eczane.Controls.Add(this.label2);
            this.gB_eczane.Controls.Add(this.cmb_eczane);
            this.gB_eczane.Controls.Add(this.cmb_ilac);
            this.gB_eczane.Controls.Add(this.nud_adet);
            this.gB_eczane.Enabled = false;
            this.gB_eczane.Location = new System.Drawing.Point(12, 93);
            this.gB_eczane.Name = "gB_eczane";
            this.gB_eczane.Size = new System.Drawing.Size(320, 207);
            this.gB_eczane.TabIndex = 0;
            this.gB_eczane.TabStop = false;
            this.gB_eczane.Text = "Eczane";
            // 
            // lbl_durum
            // 
            this.lbl_durum.AutoSize = true;
            this.lbl_durum.Location = new System.Drawing.Point(11, 81);
            this.lbl_durum.Name = "lbl_durum";
            this.lbl_durum.Size = new System.Drawing.Size(42, 17);
            this.lbl_durum.TabIndex = 9;
            this.lbl_durum.Text = "Bilgi :";
            this.lbl_durum.Click += new System.EventHandler(this.lbl_durum_Click);
            // 
            // cmb_mevcutilac
            // 
            this.cmb_mevcutilac.FormattingEnabled = true;
            this.cmb_mevcutilac.Location = new System.Drawing.Point(130, 31);
            this.cmb_mevcutilac.Name = "cmb_mevcutilac";
            this.cmb_mevcutilac.Size = new System.Drawing.Size(121, 24);
            this.cmb_mevcutilac.TabIndex = 8;
            this.cmb_mevcutilac.SelectedIndexChanged += new System.EventHandler(this.cmb_mevcutilac_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mevcut İlaçlar";
            // 
            // btn_teminet
            // 
            this.btn_teminet.Location = new System.Drawing.Point(33, 166);
            this.btn_teminet.Name = "btn_teminet";
            this.btn_teminet.Size = new System.Drawing.Size(91, 35);
            this.btn_teminet.TabIndex = 6;
            this.btn_teminet.Text = "Temin Et";
            this.btn_teminet.UseVisualStyleBackColor = true;
            this.btn_teminet.Click += new System.EventHandler(this.btn_teminet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adet Seçin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "İlaç Seçin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eczane Seçin";
            // 
            // cmb_eczane
            // 
            this.cmb_eczane.FormattingEnabled = true;
            this.cmb_eczane.Items.AddRange(new object[] {
            "Gülfidan Eczanesi",
            "Faruk Eczanesi",
            "Ömer Eczanesi",
            "Çiçek Eczanesi",
            "Fırat Eczanesi",
            "Yol Eczanesi"});
            this.cmb_eczane.Location = new System.Drawing.Point(130, 40);
            this.cmb_eczane.Name = "cmb_eczane";
            this.cmb_eczane.Size = new System.Drawing.Size(121, 24);
            this.cmb_eczane.TabIndex = 2;
            // 
            // cmb_ilac
            // 
            this.cmb_ilac.FormattingEnabled = true;
            this.cmb_ilac.Items.AddRange(new object[] {
            "AFINITOR",
            "ALOMIDE",
            "PATANOL",
            "MAXIDEX",
            "XOLAİR",
            "FLAREX",
            "FORADİL",
            "EXALON"});
            this.cmb_ilac.Location = new System.Drawing.Point(130, 83);
            this.cmb_ilac.Name = "cmb_ilac";
            this.cmb_ilac.Size = new System.Drawing.Size(121, 24);
            this.cmb_ilac.TabIndex = 1;
            // 
            // nud_adet
            // 
            this.nud_adet.Location = new System.Drawing.Point(131, 126);
            this.nud_adet.Name = "nud_adet";
            this.nud_adet.Size = new System.Drawing.Size(120, 22);
            this.nud_adet.TabIndex = 0;
            // 
            // gB_depo
            // 
            this.gB_depo.Controls.Add(this.lbl_durum);
            this.gB_depo.Controls.Add(this.label5);
            this.gB_depo.Controls.Add(this.cmb_mevcutilac);
            this.gB_depo.Enabled = false;
            this.gB_depo.Location = new System.Drawing.Point(12, 319);
            this.gB_depo.Name = "gB_depo";
            this.gB_depo.Size = new System.Drawing.Size(320, 215);
            this.gB_depo.TabIndex = 1;
            this.gB_depo.TabStop = false;
            this.gB_depo.Text = "Depo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yapılacak İşlemi Seçin";
            // 
            // rB_eczane
            // 
            this.rB_eczane.AutoSize = true;
            this.rB_eczane.Location = new System.Drawing.Point(26, 33);
            this.rB_eczane.Name = "rB_eczane";
            this.rB_eczane.Size = new System.Drawing.Size(76, 21);
            this.rB_eczane.TabIndex = 3;
            this.rB_eczane.TabStop = true;
            this.rB_eczane.Text = "Eczane";
            this.rB_eczane.UseVisualStyleBackColor = true;
            this.rB_eczane.CheckedChanged += new System.EventHandler(this.rB_eczane_CheckedChanged);
            // 
            // rB_depo
            // 
            this.rB_depo.AutoSize = true;
            this.rB_depo.Location = new System.Drawing.Point(26, 60);
            this.rB_depo.Name = "rB_depo";
            this.rB_depo.Size = new System.Drawing.Size(63, 21);
            this.rB_depo.TabIndex = 4;
            this.rB_depo.TabStop = true;
            this.rB_depo.Text = "Depo";
            this.rB_depo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(338, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eczaneDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 546);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rB_depo);
            this.Controls.Add(this.rB_eczane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gB_depo);
            this.Controls.Add(this.gB_eczane);
            this.Name = "eczaneDepo";
            this.Text = "eczaneDepo";
            this.Load += new System.EventHandler(this.eczaneDepo_Load);
            this.gB_eczane.ResumeLayout(false);
            this.gB_eczane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_adet)).EndInit();
            this.gB_depo.ResumeLayout(false);
            this.gB_depo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_eczane;
        private System.Windows.Forms.Label lbl_durum;
        private System.Windows.Forms.ComboBox cmb_mevcutilac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_teminet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_eczane;
        private System.Windows.Forms.ComboBox cmb_ilac;
        private System.Windows.Forms.NumericUpDown nud_adet;
        private System.Windows.Forms.GroupBox gB_depo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rB_eczane;
        private System.Windows.Forms.RadioButton rB_depo;
        private System.Windows.Forms.Button button1;
    }
}