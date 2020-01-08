namespace SiparisSistemi
{
    partial class SiparisBilgileri
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
            this.label3 = new System.Windows.Forms.Label();
            this.listvTumSiparisler = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCiro = new System.Windows.Forms.Label();
            this.lblToplamSiparisSayisi = new System.Windows.Forms.Label();
            this.lblEkstraMalzemeGeliri = new System.Windows.Forms.Label();
            this.lblSatilanUrunAdedi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tüm Siparişler";
            // 
            // listvTumSiparisler
            // 
            this.listvTumSiparisler.HideSelection = false;
            this.listvTumSiparisler.Location = new System.Drawing.Point(19, 63);
            this.listvTumSiparisler.Name = "listvTumSiparisler";
            this.listvTumSiparisler.Size = new System.Drawing.Size(378, 269);
            this.listvTumSiparisler.TabIndex = 6;
            this.listvTumSiparisler.UseCompatibleStateImageBehavior = false;
            this.listvTumSiparisler.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(139, 353);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ciro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 378);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Toplam Sipariş Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(18, 403);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ekstra Malzeme Geliri:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(38, 430);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Satılan Ürün Adedi:";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Location = new System.Drawing.Point(185, 353);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(51, 16);
            this.lblCiro.TabIndex = 11;
            this.lblCiro.Text = "label6";
            // 
            // lblToplamSiparisSayisi
            // 
            this.lblToplamSiparisSayisi.AutoSize = true;
            this.lblToplamSiparisSayisi.Location = new System.Drawing.Point(185, 378);
            this.lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            this.lblToplamSiparisSayisi.Size = new System.Drawing.Size(51, 16);
            this.lblToplamSiparisSayisi.TabIndex = 12;
            this.lblToplamSiparisSayisi.Text = "label7";
            // 
            // lblEkstraMalzemeGeliri
            // 
            this.lblEkstraMalzemeGeliri.AutoSize = true;
            this.lblEkstraMalzemeGeliri.Location = new System.Drawing.Point(185, 403);
            this.lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            this.lblEkstraMalzemeGeliri.Size = new System.Drawing.Size(51, 16);
            this.lblEkstraMalzemeGeliri.TabIndex = 13;
            this.lblEkstraMalzemeGeliri.Text = "label8";
            // 
            // lblSatilanUrunAdedi
            // 
            this.lblSatilanUrunAdedi.AutoSize = true;
            this.lblSatilanUrunAdedi.Location = new System.Drawing.Point(185, 430);
            this.lblSatilanUrunAdedi.Name = "lblSatilanUrunAdedi";
            this.lblSatilanUrunAdedi.Size = new System.Drawing.Size(51, 16);
            this.lblSatilanUrunAdedi.TabIndex = 14;
            this.lblSatilanUrunAdedi.Text = "label9";
            // 
            // SiparisBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::SiparisSistemi.Properties.Resources.images3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 484);
            this.Controls.Add(this.lblSatilanUrunAdedi);
            this.Controls.Add(this.lblEkstraMalzemeGeliri);
            this.Controls.Add(this.lblToplamSiparisSayisi);
            this.Controls.Add(this.lblCiro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listvTumSiparisler);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SiparisBilgileri";
            this.Text = "SiparisBilgileri";
            this.Load += new System.EventHandler(this.SiparisBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listvTumSiparisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.Label lblToplamSiparisSayisi;
        private System.Windows.Forms.Label lblEkstraMalzemeGeliri;
        private System.Windows.Forms.Label lblSatilanUrunAdedi;
    }
}