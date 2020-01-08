namespace SiparisSistemi
{
    partial class Sipariş_Oluştur
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMenusec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoyutSec = new System.Windows.Forms.ComboBox();
            this.cmbEkstraSec = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listvEkstraMalzeme = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSiparisBilgi = new System.Windows.Forms.Label();
            this.numericSiparisAdet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericSiparisAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Seçin:";
            // 
            // cmbMenusec
            // 
            this.cmbMenusec.FormattingEnabled = true;
            this.cmbMenusec.Location = new System.Drawing.Point(37, 40);
            this.cmbMenusec.Name = "cmbMenusec";
            this.cmbMenusec.Size = new System.Drawing.Size(166, 24);
            this.cmbMenusec.TabIndex = 1;
            this.cmbMenusec.Text = "Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(38, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Boyut Seçin:";
            // 
            // cmbBoyutSec
            // 
            this.cmbBoyutSec.FormattingEnabled = true;
            this.cmbBoyutSec.Location = new System.Drawing.Point(37, 99);
            this.cmbBoyutSec.Name = "cmbBoyutSec";
            this.cmbBoyutSec.Size = new System.Drawing.Size(166, 24);
            this.cmbBoyutSec.TabIndex = 3;
            this.cmbBoyutSec.Text = "Seçiniz";
            this.cmbBoyutSec.SelectedIndexChanged += new System.EventHandler(this.CmbBoyutSec_SelectedIndexChanged);
            // 
            // cmbEkstraSec
            // 
            this.cmbEkstraSec.FormattingEnabled = true;
            this.cmbEkstraSec.Location = new System.Drawing.Point(37, 158);
            this.cmbEkstraSec.Name = "cmbEkstraSec";
            this.cmbEkstraSec.Size = new System.Drawing.Size(166, 24);
            this.cmbEkstraSec.TabIndex = 5;
            this.cmbEkstraSec.Text = "Seçiniz";
            this.cmbEkstraSec.SelectedIndexChanged += new System.EventHandler(this.CmbEkstraSec_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(38, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ekstra Malzeme Seçin:";
            // 
            // listvEkstraMalzeme
            // 
            this.listvEkstraMalzeme.BackColor = System.Drawing.Color.DarkRed;
            this.listvEkstraMalzeme.ForeColor = System.Drawing.SystemColors.Info;
            this.listvEkstraMalzeme.HideSelection = false;
            this.listvEkstraMalzeme.Location = new System.Drawing.Point(12, 197);
            this.listvEkstraMalzeme.Name = "listvEkstraMalzeme";
            this.listvEkstraMalzeme.Size = new System.Drawing.Size(227, 178);
            this.listvEkstraMalzeme.TabIndex = 6;
            this.listvEkstraMalzeme.UseCompatibleStateImageBehavior = false;
            this.listvEkstraMalzeme.View = System.Windows.Forms.View.List;
            this.listvEkstraMalzeme.SelectedIndexChanged += new System.EventHandler(this.ListvEkstraMalzeme_SelectedIndexChanged);
            this.listvEkstraMalzeme.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListvEkstraMalzeme_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(194, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Siparişi Tamamla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblSiparisBilgi
            // 
            this.lblSiparisBilgi.BackColor = System.Drawing.Color.Transparent;
            this.lblSiparisBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiparisBilgi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSiparisBilgi.Location = new System.Drawing.Point(309, 17);
            this.lblSiparisBilgi.Name = "lblSiparisBilgi";
            this.lblSiparisBilgi.Size = new System.Drawing.Size(366, 321);
            this.lblSiparisBilgi.TabIndex = 8;
            // 
            // numericSiparisAdet
            // 
            this.numericSiparisAdet.Location = new System.Drawing.Point(37, 407);
            this.numericSiparisAdet.Name = "numericSiparisAdet";
            this.numericSiparisAdet.Size = new System.Drawing.Size(166, 22);
            this.numericSiparisAdet.TabIndex = 9;
            this.numericSiparisAdet.ValueChanged += new System.EventHandler(this.NumericSiparisAdet_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(38, 388);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(26, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Toplam Tutar:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(138, 449);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(0, 16);
            this.lblToplamTutar.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(12, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 52);
            this.button2.TabIndex = 13;
            this.button2.Text = "Siparişi Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Sipariş_Oluştur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SiparisSistemi.Properties.Resources.images3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 542);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericSiparisAdet);
            this.Controls.Add(this.lblSiparisBilgi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listvEkstraMalzeme);
            this.Controls.Add(this.cmbEkstraSec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBoyutSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMenusec);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sipariş_Oluştur";
            this.Text = "Sipariş_Oluştur";
            this.Load += new System.EventHandler(this.Sipariş_Oluştur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSiparisAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMenusec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoyutSec;
        private System.Windows.Forms.ComboBox cmbEkstraSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listvEkstraMalzeme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSiparisBilgi;
        private System.Windows.Forms.NumericUpDown numericSiparisAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button button2;
    }
}