namespace SiparisSistemi
{
    partial class AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparisYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sİparişBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menüEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraMalzemeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparisYönetimiToolStripMenuItem
            // 
            this.siparisYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişVerToolStripMenuItem,
            this.sİparişBilgileriToolStripMenuItem});
            this.siparisYönetimiToolStripMenuItem.Name = "siparisYönetimiToolStripMenuItem";
            this.siparisYönetimiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.siparisYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // siparişVerToolStripMenuItem
            // 
            this.siparişVerToolStripMenuItem.Name = "siparişVerToolStripMenuItem";
            this.siparişVerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.siparişVerToolStripMenuItem.Text = "Sipariş Oluştur";
            this.siparişVerToolStripMenuItem.Click += new System.EventHandler(this.SiparişVerToolStripMenuItem_Click);
            // 
            // sİparişBilgileriToolStripMenuItem
            // 
            this.sİparişBilgileriToolStripMenuItem.Name = "sİparişBilgileriToolStripMenuItem";
            this.sİparişBilgileriToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.sİparişBilgileriToolStripMenuItem.Text = "Sipariş Bilgileri";
            this.sİparişBilgileriToolStripMenuItem.Click += new System.EventHandler(this.SİparişBilgileriToolStripMenuItem_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüEkleToolStripMenuItem,
            this.ekstraMalzemeEkleToolStripMenuItem});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menüEkleToolStripMenuItem
            // 
            this.menüEkleToolStripMenuItem.Name = "menüEkleToolStripMenuItem";
            this.menüEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.menüEkleToolStripMenuItem.Text = "Menü Ekle";
            this.menüEkleToolStripMenuItem.Click += new System.EventHandler(this.MenüEkleToolStripMenuItem_Click);
            // 
            // ekstraMalzemeEkleToolStripMenuItem
            // 
            this.ekstraMalzemeEkleToolStripMenuItem.Name = "ekstraMalzemeEkleToolStripMenuItem";
            this.ekstraMalzemeEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekstraMalzemeEkleToolStripMenuItem.Text = "Ekstra Malzeme Ekle";
            this.ekstraMalzemeEkleToolStripMenuItem.Click += new System.EventHandler(this.EkstraMalzemeEkleToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(864, 761);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparisYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sİparişBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menüEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekstraMalzemeEkleToolStripMenuItem;
    }
}



