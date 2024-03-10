namespace UrunBilgiSistemi
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
            this.btnToplamMaliyet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbBirim = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAdet = new System.Windows.Forms.TextBox();
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.tbSatişFiyati = new System.Windows.Forms.TextBox();
            this.tbMaliyet = new System.Windows.Forms.TextBox();
            this.tbKodu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgUrunler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToplamMaliyet
            // 
            this.btnToplamMaliyet.Location = new System.Drawing.Point(231, 393);
            this.btnToplamMaliyet.Name = "btnToplamMaliyet";
            this.btnToplamMaliyet.Size = new System.Drawing.Size(208, 53);
            this.btnToplamMaliyet.TabIndex = 38;
            this.btnToplamMaliyet.Text = "TOPLAM MALİYET";
            this.btnToplamMaliyet.UseVisualStyleBackColor = true;
            this.btnToplamMaliyet.Click += new System.EventHandler(this.btnToplamMaliyet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(-38, 393);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(208, 53);
            this.btnSil.TabIndex = 37;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(756, 329);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(132, 23);
            this.btnGuncelle.TabIndex = 36;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbBirim
            // 
            this.cbBirim.FormattingEnabled = true;
            this.cbBirim.Items.AddRange(new object[] {
            "kutu",
            "Kilogram",
            "Adet",
            "Plaka"});
            this.cbBirim.Location = new System.Drawing.Point(880, 276);
            this.cbBirim.Name = "cbBirim";
            this.cbBirim.Size = new System.Drawing.Size(164, 24);
            this.cbBirim.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(753, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ürün birimi :";
            // 
            // tbAdet
            // 
            this.tbAdet.Location = new System.Drawing.Point(880, 237);
            this.tbAdet.Name = "tbAdet";
            this.tbAdet.Size = new System.Drawing.Size(164, 22);
            this.tbAdet.TabIndex = 32;
            // 
            // tbAdi
            // 
            this.tbAdi.Location = new System.Drawing.Point(880, 78);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(164, 22);
            this.tbAdi.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(753, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ürün adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(753, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Adet :";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(880, 112);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(164, 24);
            this.cbKategori.TabIndex = 28;
            // 
            // tbSatişFiyati
            // 
            this.tbSatişFiyati.Location = new System.Drawing.Point(880, 198);
            this.tbSatişFiyati.Name = "tbSatişFiyati";
            this.tbSatişFiyati.Size = new System.Drawing.Size(164, 22);
            this.tbSatişFiyati.TabIndex = 27;
            // 
            // tbMaliyet
            // 
            this.tbMaliyet.Location = new System.Drawing.Point(880, 151);
            this.tbMaliyet.Name = "tbMaliyet";
            this.tbMaliyet.Size = new System.Drawing.Size(164, 22);
            this.tbMaliyet.TabIndex = 26;
            // 
            // tbKodu
            // 
            this.tbKodu.Location = new System.Drawing.Point(880, 39);
            this.tbKodu.Name = "tbKodu";
            this.tbKodu.Size = new System.Drawing.Size(164, 22);
            this.tbKodu.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(753, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Satış fiyatı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(753, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ürün maliyeti :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(753, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ürün kategorisi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(753, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ürün kodu :";
            // 
            // dgUrunler
            // 
            this.dgUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUrunler.Location = new System.Drawing.Point(-38, 37);
            this.dgUrunler.Name = "dgUrunler";
            this.dgUrunler.RowHeadersWidth = 51;
            this.dgUrunler.RowTemplate.Height = 24;
            this.dgUrunler.Size = new System.Drawing.Size(764, 334);
            this.dgUrunler.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 482);
            this.Controls.Add(this.btnToplamMaliyet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbBirim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAdet);
            this.Controls.Add(this.tbAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.tbSatişFiyati);
            this.Controls.Add(this.tbMaliyet);
            this.Controls.Add(this.tbKodu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgUrunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToplamMaliyet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbBirim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAdet;
        private System.Windows.Forms.TextBox tbAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.TextBox tbSatişFiyati;
        private System.Windows.Forms.TextBox tbMaliyet;
        private System.Windows.Forms.TextBox tbKodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgUrunler;
    }
}

