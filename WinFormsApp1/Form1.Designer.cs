namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            txtSayi = new TextBox();
            txtSonuc = new TextBox();
            btnHesapla = new Button();
            label1 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(182, 104);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSayi
            // 
            txtSayi.Location = new Point(450, 23);
            txtSayi.Name = "txtSayi";
            txtSayi.Size = new Size(125, 27);
            txtSayi.TabIndex = 1;
            // 
            // txtSonuc
            // 
            txtSonuc.Enabled = false;
            txtSonuc.Location = new Point(450, 70);
            txtSonuc.Name = "txtSonuc";
            txtSonuc.Size = new Size(125, 27);
            txtSonuc.TabIndex = 2;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(450, 103);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(126, 35);
            btnHesapla.TabIndex = 3;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 23);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 4;
            label1.Text = "Sayıyı giriniz :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 70);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 5;
            label2.Text = "Sayıların Toplamı :";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 32);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 567);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHesapla);
            Controls.Add(txtSonuc);
            Controls.Add(txtSayi);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtSayi;
        private TextBox txtSonuc;
        private Button btnHesapla;
        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
    }
}
