namespace WinFormsApp1
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
            txtNot1 = new TextBox();
            txtNot3 = new TextBox();
            txtNot2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnHesapla = new Button();
            label4 = new Label();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // txtNot1
            // 
            txtNot1.Location = new Point(203, 32);
            txtNot1.Name = "txtNot1";
            txtNot1.Size = new Size(170, 27);
            txtNot1.TabIndex = 0;
            // 
            // txtNot3
            // 
            txtNot3.Location = new Point(203, 130);
            txtNot3.Name = "txtNot3";
            txtNot3.Size = new Size(170, 27);
            txtNot3.TabIndex = 1;
            // 
            // txtNot2
            // 
            txtNot2.Location = new Point(203, 80);
            txtNot2.Name = "txtNot2";
            txtNot2.Size = new Size(170, 27);
            txtNot2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 3;
            label1.Text = "1. Yazılı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 83);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 4;
            label2.Text = "2. Yazılı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 130);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Sözlü";
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(203, 179);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(167, 37);
            btnHesapla.TabIndex = 6;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 240);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 7;
            label4.Text = "Ortalama";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(289, 240);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(15, 20);
            lblSonuc.TabIndex = 8;
            lblSonuc.Text = "-";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 557);
            Controls.Add(lblSonuc);
            Controls.Add(label4);
            Controls.Add(btnHesapla);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNot2);
            Controls.Add(txtNot3);
            Controls.Add(txtNot1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNot1;
        private TextBox txtNot3;
        private TextBox txtNot2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnHesapla;
        private Label label4;
        private Label lblSonuc;
    }
}