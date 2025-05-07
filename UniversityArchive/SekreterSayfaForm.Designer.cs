namespace UniversityArchive
{
    partial class SekreterSayfaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterSayfaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evraklarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evrakEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evrakSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetVermeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teslimAlmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.evraklarToolStripMenuItem,
            this.emanetToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 53);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anasayfaToolStripMenuItem.Image")));
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(99, 49);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem});
            this.personelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personelToolStripMenuItem.Image")));
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(98, 49);
            this.personelToolStripMenuItem.Text = "Personel";
            this.personelToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            // 
            // evraklarToolStripMenuItem
            // 
            this.evraklarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evrakEkleToolStripMenuItem,
            this.evrakSilmeToolStripMenuItem});
            this.evraklarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("evraklarToolStripMenuItem.Image")));
            this.evraklarToolStripMenuItem.Name = "evraklarToolStripMenuItem";
            this.evraklarToolStripMenuItem.Size = new System.Drawing.Size(90, 49);
            this.evraklarToolStripMenuItem.Text = "Evraklar";
            this.evraklarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // evrakEkleToolStripMenuItem
            // 
            this.evrakEkleToolStripMenuItem.Name = "evrakEkleToolStripMenuItem";
            this.evrakEkleToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.evrakEkleToolStripMenuItem.Text = "Evrak Ekle";
            this.evrakEkleToolStripMenuItem.Click += new System.EventHandler(this.evrakEkleToolStripMenuItem_Click);
            // 
            // evrakSilmeToolStripMenuItem
            // 
            this.evrakSilmeToolStripMenuItem.Name = "evrakSilmeToolStripMenuItem";
            this.evrakSilmeToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.evrakSilmeToolStripMenuItem.Text = "Evrak Silme";
            // 
            // emanetToolStripMenuItem
            // 
            this.emanetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emanetVermeToolStripMenuItem,
            this.teslimAlmaToolStripMenuItem});
            this.emanetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emanetToolStripMenuItem.Image")));
            this.emanetToolStripMenuItem.Name = "emanetToolStripMenuItem";
            this.emanetToolStripMenuItem.Size = new System.Drawing.Size(88, 49);
            this.emanetToolStripMenuItem.Text = "Emanet";
            this.emanetToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // emanetVermeToolStripMenuItem
            // 
            this.emanetVermeToolStripMenuItem.Name = "emanetVermeToolStripMenuItem";
            this.emanetVermeToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.emanetVermeToolStripMenuItem.Text = "Emanet Verme";
            this.emanetVermeToolStripMenuItem.Click += new System.EventHandler(this.emanetVermeToolStripMenuItem_Click);
            // 
            // teslimAlmaToolStripMenuItem
            // 
            this.teslimAlmaToolStripMenuItem.Name = "teslimAlmaToolStripMenuItem";
            this.teslimAlmaToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.teslimAlmaToolStripMenuItem.Text = "Teslim Alma";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(64, 49);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(143, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uludağ Üniversitesi Arşivine Hoş Geldiniz!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SekreterSayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SekreterSayfaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekreterSayfaForm";
            this.Load += new System.EventHandler(this.SekreterSayfaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evraklarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evrakEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evrakSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetVermeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teslimAlmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}