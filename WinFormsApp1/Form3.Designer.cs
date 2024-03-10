namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbSayi1 = new TextBox();
            tbSayi2 = new TextBox();
            lBox = new ListBox();
            chTopla = new CheckBox();
            chCarp = new CheckBox();
            chCikar = new CheckBox();
            chBol = new CheckBox();
            btHesapla = new Button();
            btTemizle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 67);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "1. Sayı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 115);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 176);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Sonuç";
            // 
            // tbSayi1
            // 
            tbSayi1.Location = new Point(168, 64);
            tbSayi1.Name = "tbSayi1";
            tbSayi1.Size = new Size(192, 27);
            tbSayi1.TabIndex = 3;
            // 
            // tbSayi2
            // 
            tbSayi2.Location = new Point(168, 108);
            tbSayi2.Name = "tbSayi2";
            tbSayi2.Size = new Size(192, 27);
            tbSayi2.TabIndex = 5;
            // 
            // lBox
            // 
            lBox.FormattingEnabled = true;
            lBox.Location = new Point(168, 165);
            lBox.Name = "lBox";
            lBox.Size = new Size(192, 164);
            lBox.TabIndex = 6;
            // 
            // chTopla
            // 
            chTopla.AutoSize = true;
            chTopla.Location = new Point(481, 79);
            chTopla.Name = "chTopla";
            chTopla.Size = new Size(68, 24);
            chTopla.TabIndex = 7;
            chTopla.Text = "Topla";
            chTopla.UseVisualStyleBackColor = true;
            // 
            // chCarp
            // 
            chCarp.AutoSize = true;
            chCarp.Location = new Point(481, 133);
            chCarp.Name = "chCarp";
            chCarp.Size = new Size(62, 24);
            chCarp.TabIndex = 8;
            chCarp.Text = "Çarp";
            chCarp.UseVisualStyleBackColor = true;
            // 
            // chCikar
            // 
            chCikar.AutoSize = true;
            chCikar.Location = new Point(623, 79);
            chCikar.Name = "chCikar";
            chCikar.Size = new Size(64, 24);
            chCikar.TabIndex = 9;
            chCikar.Text = "Çıkar";
            chCikar.UseVisualStyleBackColor = true;
            // 
            // chBol
            // 
            chBol.AutoSize = true;
            chBol.Location = new Point(614, 133);
            chBol.Name = "chBol";
            chBol.Size = new Size(53, 24);
            chBol.TabIndex = 10;
            chBol.Text = "Böl";
            chBol.UseVisualStyleBackColor = true;
            // 
            // btHesapla
            // 
            btHesapla.Location = new Point(493, 185);
            btHesapla.Name = "btHesapla";
            btHesapla.Size = new Size(161, 55);
            btHesapla.TabIndex = 11;
            btHesapla.Text = "Hesapla";
            btHesapla.UseVisualStyleBackColor = true;
            btHesapla.Click += btHesapla_Click;
            // 
            // btTemizle
            // 
            btTemizle.Location = new Point(493, 262);
            btTemizle.Name = "btTemizle";
            btTemizle.Size = new Size(161, 55);
            btTemizle.TabIndex = 12;
            btTemizle.Text = "Temizle";
            btTemizle.UseVisualStyleBackColor = true;
            btTemizle.Click += btTemizle_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btTemizle);
            Controls.Add(btHesapla);
            Controls.Add(chBol);
            Controls.Add(chCikar);
            Controls.Add(chCarp);
            Controls.Add(chTopla);
            Controls.Add(lBox);
            Controls.Add(tbSayi2);
            Controls.Add(tbSayi1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbSayi1;
        private TextBox tbSayi2;
        private ListBox lBox;
        private CheckBox chTopla;
        private CheckBox chCarp;
        private CheckBox chCikar;
        private CheckBox chBol;
        private Button btHesapla;
        private Button btTemizle;
    }
}