namespace SiparisSistemi
{
    partial class EkstraMalzemeEkle
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
            this.btnEkstraMalzemeKaydet = new System.Windows.Forms.Button();
            this.txtEkstaraMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEkstraMalzemeEkleFiyat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEkstraMalzemeKaydet
            // 
            this.btnEkstraMalzemeKaydet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEkstraMalzemeKaydet.Location = new System.Drawing.Point(31, 215);
            this.btnEkstraMalzemeKaydet.Name = "btnEkstraMalzemeKaydet";
            this.btnEkstraMalzemeKaydet.Size = new System.Drawing.Size(165, 49);
            this.btnEkstraMalzemeKaydet.TabIndex = 20;
            this.btnEkstraMalzemeKaydet.Text = "Kaydet";
            this.btnEkstraMalzemeKaydet.UseVisualStyleBackColor = false;
            this.btnEkstraMalzemeKaydet.Click += new System.EventHandler(this.BtnEkstraMalzemeKaydet_Click);
            // 
            // txtEkstaraMalzemeAdi
            // 
            this.txtEkstaraMalzemeAdi.Location = new System.Drawing.Point(31, 94);
            this.txtEkstaraMalzemeAdi.Name = "txtEkstaraMalzemeAdi";
            this.txtEkstaraMalzemeAdi.Size = new System.Drawing.Size(166, 20);
            this.txtEkstaraMalzemeAdi.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fiyat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ekstra Malzeme Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ekstra Malzeme Bilgileri";
            // 
            // txtEkstraMalzemeEkleFiyat
            // 
            this.txtEkstraMalzemeEkleFiyat.Location = new System.Drawing.Point(31, 150);
            this.txtEkstraMalzemeEkleFiyat.Name = "txtEkstraMalzemeEkleFiyat";
            this.txtEkstraMalzemeEkleFiyat.Size = new System.Drawing.Size(166, 20);
            this.txtEkstraMalzemeEkleFiyat.TabIndex = 21;
            // 
            // EkstraMalzemeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SiparisSistemi.Properties.Resources.images3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(432, 305);
            this.Controls.Add(this.txtEkstraMalzemeEkleFiyat);
            this.Controls.Add(this.btnEkstraMalzemeKaydet);
            this.Controls.Add(this.txtEkstaraMalzemeAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "EkstraMalzemeEkle";
            this.Text = "EkstraMalzemeEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkstraMalzemeKaydet;
        private System.Windows.Forms.TextBox txtEkstaraMalzemeAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEkstraMalzemeEkleFiyat;
    }
}