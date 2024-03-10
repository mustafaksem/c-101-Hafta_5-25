namespace WindowsFormsApp1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnControl = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnBuyuk = new System.Windows.Forms.Label();
            this.lblEnKucuk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.btnSirala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
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
            this.listBox1.Location = new System.Drawing.Point(39, 164);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 276);
            this.listBox1.TabIndex = 0;
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(315, 164);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(179, 54);
            this.btnControl.TabIndex = 1;
            this.btnControl.Text = ">>>";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(527, 164);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(225, 276);
            this.listBox2.TabIndex = 2;
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(39, 24);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(225, 22);
            this.txtMetin.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "En Büyük";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "En Küçük";
            // 
            // lblEnBuyuk
            // 
            this.lblEnBuyuk.AutoSize = true;
            this.lblEnBuyuk.Location = new System.Drawing.Point(888, 163);
            this.lblEnBuyuk.Name = "lblEnBuyuk";
            this.lblEnBuyuk.Size = new System.Drawing.Size(11, 16);
            this.lblEnBuyuk.TabIndex = 7;
            this.lblEnBuyuk.Text = "-";
            // 
            // lblEnKucuk
            // 
            this.lblEnKucuk.AutoSize = true;
            this.lblEnKucuk.Location = new System.Drawing.Point(888, 202);
            this.lblEnKucuk.Name = "lblEnKucuk";
            this.lblEnKucuk.Size = new System.Drawing.Size(11, 16);
            this.lblEnKucuk.TabIndex = 8;
            this.lblEnKucuk.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(776, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Toplamları";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(776, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ortalamaları";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(891, 240);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(11, 16);
            this.lblToplam.TabIndex = 11;
            this.lblToplam.Text = "-";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(891, 275);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(11, 16);
            this.lblOrtalama.TabIndex = 12;
            this.lblOrtalama.Text = "-";
            // 
            // btnSirala
            // 
            this.btnSirala.Location = new System.Drawing.Point(527, 461);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(225, 59);
            this.btnSirala.TabIndex = 13;
            this.btnSirala.Text = "Sırala";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 532);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEnKucuk);
            this.Controls.Add(this.lblEnBuyuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnBuyuk;
        private System.Windows.Forms.Label lblEnKucuk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Button btnSirala;
    }
}

