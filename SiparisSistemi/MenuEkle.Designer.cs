namespace SiparisSistemi
{
    partial class MenuEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.btnMenuKaydet = new System.Windows.Forms.Button();
            this.txtMenuFiyat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Menü Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menü Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fiyat:";
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Location = new System.Drawing.Point(18, 95);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(166, 20);
            this.txtMenuAdi.TabIndex = 12;
            // 
            // btnMenuKaydet
            // 
            this.btnMenuKaydet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuKaydet.Location = new System.Drawing.Point(18, 216);
            this.btnMenuKaydet.Name = "btnMenuKaydet";
            this.btnMenuKaydet.Size = new System.Drawing.Size(165, 49);
            this.btnMenuKaydet.TabIndex = 14;
            this.btnMenuKaydet.Text = "Kaydet";
            this.btnMenuKaydet.UseVisualStyleBackColor = false;
            this.btnMenuKaydet.Click += new System.EventHandler(this.BtnMenuKaydet_Click);
            // 
            // txtMenuFiyat
            // 
            this.txtMenuFiyat.Location = new System.Drawing.Point(17, 151);
            this.txtMenuFiyat.Name = "txtMenuFiyat";
            this.txtMenuFiyat.Size = new System.Drawing.Size(166, 20);
            this.txtMenuFiyat.TabIndex = 15;
            // 
            // MenuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SiparisSistemi.Properties.Resources.images3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 298);
            this.Controls.Add(this.txtMenuFiyat);
            this.Controls.Add(this.btnMenuKaydet);
            this.Controls.Add(this.txtMenuAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "MenuEkle";
            this.Text = "MenuEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMenuAdi;
        private System.Windows.Forms.Button btnMenuKaydet;
        private System.Windows.Forms.TextBox txtMenuFiyat;
    }
}