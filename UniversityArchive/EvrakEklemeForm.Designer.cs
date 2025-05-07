namespace UniversityArchive
{
    partial class EvrakEklemeForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.evrakKaydetBtn = new System.Windows.Forms.Button();
            this.kaydedenIDTxt = new System.Windows.Forms.TextBox();
            this.evrakSahibiTxt = new System.Windows.Forms.TextBox();
            this.rafNoTxt = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.evrakTuruCmbx = new System.Windows.Forms.ComboBox();
            this.evrakAdTxt = new System.Windows.Forms.TextBox();
            this.evrakIDTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(498, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(531, 700);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.evrakKaydetBtn);
            this.groupBox1.Controls.Add(this.kaydedenIDTxt);
            this.groupBox1.Controls.Add(this.evrakSahibiTxt);
            this.groupBox1.Controls.Add(this.rafNoTxt);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.evrakTuruCmbx);
            this.groupBox1.Controls.Add(this.evrakAdTxt);
            this.groupBox1.Controls.Add(this.evrakIDTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 689);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evrak ekle";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(137, 472);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(282, 30);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // evrakKaydetBtn
            // 
            this.evrakKaydetBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.evrakKaydetBtn.Location = new System.Drawing.Point(137, 591);
            this.evrakKaydetBtn.Name = "evrakKaydetBtn";
            this.evrakKaydetBtn.Size = new System.Drawing.Size(282, 32);
            this.evrakKaydetBtn.TabIndex = 9;
            this.evrakKaydetBtn.Text = "Kaydet";
            this.evrakKaydetBtn.UseVisualStyleBackColor = true;
            // 
            // kaydedenIDTxt
            // 
            this.kaydedenIDTxt.Location = new System.Drawing.Point(137, 532);
            this.kaydedenIDTxt.Name = "kaydedenIDTxt";
            this.kaydedenIDTxt.Size = new System.Drawing.Size(282, 30);
            this.kaydedenIDTxt.TabIndex = 8;
            // 
            // evrakSahibiTxt
            // 
            this.evrakSahibiTxt.Location = new System.Drawing.Point(137, 412);
            this.evrakSahibiTxt.Name = "evrakSahibiTxt";
            this.evrakSahibiTxt.Size = new System.Drawing.Size(282, 30);
            this.evrakSahibiTxt.TabIndex = 6;
            // 
            // rafNoTxt
            // 
            this.rafNoTxt.Location = new System.Drawing.Point(137, 352);
            this.rafNoTxt.Name = "rafNoTxt";
            this.rafNoTxt.Size = new System.Drawing.Size(282, 30);
            this.rafNoTxt.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(137, 259);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(282, 83);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // evrakTuruCmbx
            // 
            this.evrakTuruCmbx.FormattingEnabled = true;
            this.evrakTuruCmbx.Items.AddRange(new object[] {
            "Sıınav kağıtları",
            "Diploma belgesi",
            "Transkript",
            "Dilekçe",
            "Rapor",
            "Tutanak"});
            this.evrakTuruCmbx.Location = new System.Drawing.Point(137, 199);
            this.evrakTuruCmbx.Name = "evrakTuruCmbx";
            this.evrakTuruCmbx.Size = new System.Drawing.Size(282, 31);
            this.evrakTuruCmbx.TabIndex = 3;
            // 
            // evrakAdTxt
            // 
            this.evrakAdTxt.Location = new System.Drawing.Point(137, 139);
            this.evrakAdTxt.Name = "evrakAdTxt";
            this.evrakAdTxt.Size = new System.Drawing.Size(282, 30);
            this.evrakAdTxt.TabIndex = 2;
            // 
            // evrakIDTxt
            // 
            this.evrakIDTxt.Location = new System.Drawing.Point(137, 79);
            this.evrakIDTxt.Name = "evrakIDTxt";
            this.evrakIDTxt.Size = new System.Drawing.Size(282, 30);
            this.evrakIDTxt.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(10, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kaydeden ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kayıt Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Evrak Sahibi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Raf No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Türü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Evrak Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // EvrakEklemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1030, 703);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EvrakEklemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EvrakEklemeForm";
            this.Load += new System.EventHandler(this.EvrakEklemeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kaydedenIDTxt;
        private System.Windows.Forms.TextBox evrakSahibiTxt;
        private System.Windows.Forms.TextBox rafNoTxt;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox evrakTuruCmbx;
        private System.Windows.Forms.TextBox evrakAdTxt;
        private System.Windows.Forms.TextBox evrakIDTxt;
        private System.Windows.Forms.Button evrakKaydetBtn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}