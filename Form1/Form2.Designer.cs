namespace Form1
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
            this.comboMsjKutusu = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbSayi = new System.Windows.Forms.TextBox();
            this.btnSayiEkle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboMsjKutusu
            // 
            this.comboMsjKutusu.FormattingEnabled = true;
            this.comboMsjKutusu.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboMsjKutusu.Location = new System.Drawing.Point(242, 28);
            this.comboMsjKutusu.Name = "comboMsjKutusu";
            this.comboMsjKutusu.Size = new System.Drawing.Size(197, 24);
            this.comboMsjKutusu.TabIndex = 0;
            this.comboMsjKutusu.SelectedIndexChanged += new System.EventHandler(this.comboMsjKutusu_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 94);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mesaj Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbSayi
            // 
            this.txtbSayi.Location = new System.Drawing.Point(242, 82);
            this.txtbSayi.Name = "txtbSayi";
            this.txtbSayi.Size = new System.Drawing.Size(204, 22);
            this.txtbSayi.TabIndex = 2;
            // 
            // btnSayiEkle
            // 
            this.btnSayiEkle.Location = new System.Drawing.Point(367, 129);
            this.btnSayiEkle.Name = "btnSayiEkle";
            this.btnSayiEkle.Size = new System.Drawing.Size(79, 40);
            this.btnSayiEkle.TabIndex = 3;
            this.btnSayiEkle.Text = "EKLE";
            this.btnSayiEkle.UseVisualStyleBackColor = true;
            this.btnSayiEkle.Click += new System.EventHandler(this.btnSayiEkle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Random 5 sayı ata";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Topla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSayiEkle);
            this.Controls.Add(this.txtbSayi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboMsjKutusu);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMsjKutusu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbSayi;
        private System.Windows.Forms.Button btnSayiEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}