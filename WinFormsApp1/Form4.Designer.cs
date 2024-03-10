namespace WinFormsApp1
{
    partial class Form4
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
            button2 = new Button();
            lBoxSayilar = new ListBox();
            lblSonuc = new Label();
            btnEnBuyukSayi = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(295, 28);
            button2.Name = "button2";
            button2.Size = new Size(127, 38);
            button2.TabIndex = 1;
            button2.Text = "+5 Sayı Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lBoxSayilar
            // 
            lBoxSayilar.FormattingEnabled = true;
            lBoxSayilar.Location = new Point(48, 12);
            lBoxSayilar.Name = "lBoxSayilar";
            lBoxSayilar.Size = new Size(224, 284);
            lBoxSayilar.TabIndex = 2;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(318, 135);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(15, 20);
            lblSonuc.TabIndex = 3;
            lblSonuc.Text = "-";
            // 
            // btnEnBuyukSayi
            // 
            btnEnBuyukSayi.Location = new Point(295, 189);
            btnEnBuyukSayi.Name = "btnEnBuyukSayi";
            btnEnBuyukSayi.Size = new Size(127, 38);
            btnEnBuyukSayi.TabIndex = 4;
            btnEnBuyukSayi.Text = "En Büyük :";
            btnEnBuyukSayi.UseVisualStyleBackColor = true;
            btnEnBuyukSayi.Click += btnEnBuyukSayi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 246);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnEnBuyukSayi);
            Controls.Add(lblSonuc);
            Controls.Add(lBoxSayilar);
            Controls.Add(button2);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private ListBox lBoxSayilar;
        private Label lblSonuc;
        private Button btnEnBuyukSayi;
        private Label label1;
    }
}