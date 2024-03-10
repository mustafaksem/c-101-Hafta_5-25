namespace Ders27_02
{
    partial class Form3
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgOgrenciler = new System.Windows.Forms.DataGridView();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyadi = new System.Windows.Forms.TextBox();
            this.txtokulNumarasi = new System.Windows.Forms.TextBox();
            this.txtTCKimlikNo = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "TC no :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(679, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Öğrenci no :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "İsim :";
            // 
            // dgOgrenciler
            // 
            this.dgOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOgrenciler.Location = new System.Drawing.Point(0, 12);
            this.dgOgrenciler.Name = "dgOgrenciler";
            this.dgOgrenciler.RowHeadersWidth = 51;
            this.dgOgrenciler.RowTemplate.Height = 24;
            this.dgOgrenciler.Size = new System.Drawing.Size(632, 385);
            this.dgOgrenciler.TabIndex = 9;
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Location = new System.Drawing.Point(779, 36);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(163, 22);
            this.txtOgrenciAdi.TabIndex = 14;
            // 
            // txtOgrenciSoyadi
            // 
            this.txtOgrenciSoyadi.Location = new System.Drawing.Point(779, 78);
            this.txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
            this.txtOgrenciSoyadi.Size = new System.Drawing.Size(163, 22);
            this.txtOgrenciSoyadi.TabIndex = 15;
            // 
            // txtokulNumarasi
            // 
            this.txtokulNumarasi.Location = new System.Drawing.Point(779, 131);
            this.txtokulNumarasi.Name = "txtokulNumarasi";
            this.txtokulNumarasi.Size = new System.Drawing.Size(163, 22);
            this.txtokulNumarasi.TabIndex = 16;
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.Location = new System.Drawing.Point(779, 187);
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(163, 22);
            this.txtTCKimlikNo.TabIndex = 17;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(779, 259);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(163, 44);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtTCKimlikNo);
            this.Controls.Add(this.txtokulNumarasi);
            this.Controls.Add(this.txtOgrenciSoyadi);
            this.Controls.Add(this.txtOgrenciAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgOgrenciler);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgOgrenciler;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.TextBox txtOgrenciSoyadi;
        private System.Windows.Forms.TextBox txtokulNumarasi;
        private System.Windows.Forms.TextBox txtTCKimlikNo;
        private System.Windows.Forms.Button btnEkle;
    }
}