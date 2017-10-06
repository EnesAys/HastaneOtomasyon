namespace HastaneOtomasyon
{
    partial class Form1
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
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorDuzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorToolStripMenuItem,
            this.hemşireToolStripMenuItem,
            this.hastaToolStripMenuItem,
            this.randevuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorEkleToolStripMenuItem,
            this.doktorDuzenleToolStripMenuItem,
            this.doktorSilToolStripMenuItem});
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.doktorToolStripMenuItem.Text = "Doktor";
            // 
            // doktorEkleToolStripMenuItem
            // 
            this.doktorEkleToolStripMenuItem.Name = "doktorEkleToolStripMenuItem";
            this.doktorEkleToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.doktorEkleToolStripMenuItem.Text = "Doktor Ekle";
            this.doktorEkleToolStripMenuItem.Click += new System.EventHandler(this.doktorEkleToolStripMenuItem_Click);
            // 
            // doktorDuzenleToolStripMenuItem
            // 
            this.doktorDuzenleToolStripMenuItem.Name = "doktorDuzenleToolStripMenuItem";
            this.doktorDuzenleToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.doktorDuzenleToolStripMenuItem.Text = "Doktor Düzenle";
            this.doktorDuzenleToolStripMenuItem.Click += new System.EventHandler(this.doktorDuzenleToolStripMenuItem_Click);
            // 
            // doktorSilToolStripMenuItem
            // 
            this.doktorSilToolStripMenuItem.Name = "doktorSilToolStripMenuItem";
            this.doktorSilToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.doktorSilToolStripMenuItem.Text = "Doktor Sil";
            this.doktorSilToolStripMenuItem.Click += new System.EventHandler(this.doktorSilToolStripMenuItem_Click);
            // 
            // hemşireToolStripMenuItem
            // 
            this.hemşireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hemşireEkleToolStripMenuItem,
            this.hemşireDüzenleToolStripMenuItem,
            this.hemşireSilToolStripMenuItem});
            this.hemşireToolStripMenuItem.Name = "hemşireToolStripMenuItem";
            this.hemşireToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.hemşireToolStripMenuItem.Text = "Hemşire";
            // 
            // hemşireEkleToolStripMenuItem
            // 
            this.hemşireEkleToolStripMenuItem.Name = "hemşireEkleToolStripMenuItem";
            this.hemşireEkleToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.hemşireEkleToolStripMenuItem.Text = "Hemşire Ekle";
            this.hemşireEkleToolStripMenuItem.Click += new System.EventHandler(this.hemşireEkleToolStripMenuItem_Click);
            // 
            // hemşireDüzenleToolStripMenuItem
            // 
            this.hemşireDüzenleToolStripMenuItem.Name = "hemşireDüzenleToolStripMenuItem";
            this.hemşireDüzenleToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.hemşireDüzenleToolStripMenuItem.Text = "Hemşire Düzenle";
            this.hemşireDüzenleToolStripMenuItem.Click += new System.EventHandler(this.hemşireDüzenleToolStripMenuItem_Click);
            // 
            // hemşireSilToolStripMenuItem
            // 
            this.hemşireSilToolStripMenuItem.Name = "hemşireSilToolStripMenuItem";
            this.hemşireSilToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.hemşireSilToolStripMenuItem.Text = "Hemşire Sil";
            this.hemşireSilToolStripMenuItem.Click += new System.EventHandler(this.hemşireSilToolStripMenuItem_Click);
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaEkleToolStripMenuItem,
            this.hastaDüzenleToolStripMenuItem,
            this.hastaSilToolStripMenuItem});
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.hastaToolStripMenuItem.Text = "Hasta";
            // 
            // hastaEkleToolStripMenuItem
            // 
            this.hastaEkleToolStripMenuItem.Name = "hastaEkleToolStripMenuItem";
            this.hastaEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.hastaEkleToolStripMenuItem.Text = "Hasta Ekle";
            this.hastaEkleToolStripMenuItem.Click += new System.EventHandler(this.hastaEkleToolStripMenuItem_Click);
            // 
            // hastaDüzenleToolStripMenuItem
            // 
            this.hastaDüzenleToolStripMenuItem.Name = "hastaDüzenleToolStripMenuItem";
            this.hastaDüzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.hastaDüzenleToolStripMenuItem.Text = "Hasta Düzenle";
            this.hastaDüzenleToolStripMenuItem.Click += new System.EventHandler(this.hastaDüzenleToolStripMenuItem_Click);
            // 
            // hastaSilToolStripMenuItem
            // 
            this.hastaSilToolStripMenuItem.Name = "hastaSilToolStripMenuItem";
            this.hastaSilToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.hastaSilToolStripMenuItem.Text = "Hasta Sil";
            this.hastaSilToolStripMenuItem.Click += new System.EventHandler(this.hastaSilToolStripMenuItem_Click);
            // 
            // randevuToolStripMenuItem
            // 
            this.randevuToolStripMenuItem.Name = "randevuToolStripMenuItem";
            this.randevuToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.randevuToolStripMenuItem.Text = "Randevu";
            this.randevuToolStripMenuItem.Click += new System.EventHandler(this.randevuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(946, 480);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hastane Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorDuzenleToolStripMenuItem;
    }
}

