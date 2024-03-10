namespace Form1
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sayiBilgisi1 = new System.Windows.Forms.TextBox();
            this.sayiBilgisi2 = new System.Windows.Forms.TextBox();
            this.sonucBilgisi = new System.Windows.Forms.Label();
            this.toplaMesaji = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 418);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sayı 2";
            // 
            // sayiBilgisi1
            // 
            this.sayiBilgisi1.Location = new System.Drawing.Point(117, 24);
            this.sayiBilgisi1.Name = "sayiBilgisi1";
            this.sayiBilgisi1.Size = new System.Drawing.Size(170, 22);
            this.sayiBilgisi1.TabIndex = 16;
            // 
            // sayiBilgisi2
            // 
            this.sayiBilgisi2.Location = new System.Drawing.Point(117, 58);
            this.sayiBilgisi2.Name = "sayiBilgisi2";
            this.sayiBilgisi2.Size = new System.Drawing.Size(170, 22);
            this.sayiBilgisi2.TabIndex = 17;
            // 
            // sonucBilgisi
            // 
            this.sonucBilgisi.AutoSize = true;
            this.sonucBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucBilgisi.Location = new System.Drawing.Point(36, 120);
            this.sonucBilgisi.Name = "sonucBilgisi";
            this.sonucBilgisi.Size = new System.Drawing.Size(171, 48);
            this.sonucBilgisi.TabIndex = 18;
            this.sonucBilgisi.Text = "SONUÇ";
            // 
            // toplaMesaji
            // 
            this.toplaMesaji.BackColor = System.Drawing.Color.Red;
            this.toplaMesaji.Location = new System.Drawing.Point(12, 198);
            this.toplaMesaji.Name = "toplaMesaji";
            this.toplaMesaji.Size = new System.Drawing.Size(164, 136);
            this.toplaMesaji.TabIndex = 19;
            this.toplaMesaji.Text = "TOPLA";
            this.toplaMesaji.UseVisualStyleBackColor = false;
            this.toplaMesaji.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(194, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 136);
            this.button2.TabIndex = 20;
            this.button2.Text = "ÇIKART";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Fuchsia;
            this.button3.Location = new System.Drawing.Point(403, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 136);
            this.button3.TabIndex = 21;
            this.button3.Text = "ÇARP";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(600, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 136);
            this.button4.TabIndex = 22;
            this.button4.Text = "BÖL";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 418);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.toplaMesaji);
            this.Controls.Add(this.sonucBilgisi);
            this.Controls.Add(this.sayiBilgisi2);
            this.Controls.Add(this.sayiBilgisi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label sonucBilgisi;
        private System.Windows.Forms.TextBox sayiBilgisi2;
        private System.Windows.Forms.TextBox sayiBilgisi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button toplaMesaji;
    }
}

