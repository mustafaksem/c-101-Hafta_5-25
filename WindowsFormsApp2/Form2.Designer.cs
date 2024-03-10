namespace WindowsFormsApp2
{
    partial class Form2
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
            this.tbSayi1 = new System.Windows.Forms.TextBox();
            this.tbSayi2 = new System.Windows.Forms.TextBox();
            this.btnAsalSayilar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToplama = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblEnBuyuk = new System.Windows.Forms.Label();
            this.lblEnKucuk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSayi1
            // 
            this.tbSayi1.Location = new System.Drawing.Point(12, 12);
            this.tbSayi1.Name = "tbSayi1";
            this.tbSayi1.Size = new System.Drawing.Size(100, 22);
            this.tbSayi1.TabIndex = 0;
            // 
            // tbSayi2
            // 
            this.tbSayi2.Location = new System.Drawing.Point(172, 12);
            this.tbSayi2.Name = "tbSayi2";
            this.tbSayi2.Size = new System.Drawing.Size(100, 22);
            this.tbSayi2.TabIndex = 1;
            // 
            // btnAsalSayilar
            // 
            this.btnAsalSayilar.Location = new System.Drawing.Point(366, 5);
            this.btnAsalSayilar.Name = "btnAsalSayilar";
            this.btnAsalSayilar.Size = new System.Drawing.Size(156, 36);
            this.btnAsalSayilar.TabIndex = 2;
            this.btnAsalSayilar.Text = "Asal sayıları listele";
            this.btnAsalSayilar.UseVisualStyleBackColor = true;
            this.btnAsalSayilar.Click += new System.EventHandler(this.btnAsalSayilar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "arasındaki";
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.ItemHeight = 16;
            this.lbSayilar.Location = new System.Drawing.Point(12, 60);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(515, 260);
            this.lbSayilar.TabIndex = 5;
            this.lbSayilar.SelectedIndexChanged += new System.EventHandler(this.lbSayilar_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Chocolate;
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(14, 336);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(515, 41);
            this.progressBar1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Toplam :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ortalama :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "En Büyük :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "En Küçük :";
            // 
            // lblToplama
            // 
            this.lblToplama.AutoSize = true;
            this.lblToplama.Location = new System.Drawing.Point(142, 401);
            this.lblToplama.Name = "lblToplama";
            this.lblToplama.Size = new System.Drawing.Size(11, 16);
            this.lblToplama.TabIndex = 11;
            this.lblToplama.Text = "-";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(142, 436);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(11, 16);
            this.lblOrtalama.TabIndex = 12;
            this.lblOrtalama.Text = "-";
            // 
            // lblEnBuyuk
            // 
            this.lblEnBuyuk.AutoSize = true;
            this.lblEnBuyuk.Location = new System.Drawing.Point(416, 401);
            this.lblEnBuyuk.Name = "lblEnBuyuk";
            this.lblEnBuyuk.Size = new System.Drawing.Size(11, 16);
            this.lblEnBuyuk.TabIndex = 13;
            this.lblEnBuyuk.Text = "-";
            // 
            // lblEnKucuk
            // 
            this.lblEnKucuk.AutoSize = true;
            this.lblEnKucuk.Location = new System.Drawing.Point(416, 436);
            this.lblEnKucuk.Name = "lblEnKucuk";
            this.lblEnKucuk.Size = new System.Drawing.Size(11, 16);
            this.lblEnKucuk.TabIndex = 14;
            this.lblEnKucuk.Text = "-";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 551);
            this.Controls.Add(this.lblEnKucuk);
            this.Controls.Add(this.lblEnBuyuk);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblToplama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbSayilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAsalSayilar);
            this.Controls.Add(this.tbSayi2);
            this.Controls.Add(this.tbSayi1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSayi1;
        private System.Windows.Forms.TextBox tbSayi2;
        private System.Windows.Forms.Button btnAsalSayilar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSayilar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblToplama;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblEnBuyuk;
        private System.Windows.Forms.Label lblEnKucuk;
    }
}