namespace WindowsFormsApp3
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
            this.rbSecim1 = new System.Windows.Forms.RadioButton();
            this.rbSecim2 = new System.Windows.Forms.RadioButton();
            this.rbSecim4 = new System.Windows.Forms.RadioButton();
            this.rbSecim3 = new System.Windows.Forms.RadioButton();
            this.rbSecim5 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbSecim1
            // 
            this.rbSecim1.AutoSize = true;
            this.rbSecim1.Location = new System.Drawing.Point(27, 25);
            this.rbSecim1.Name = "rbSecim1";
            this.rbSecim1.Size = new System.Drawing.Size(76, 20);
            this.rbSecim1.TabIndex = 0;
            this.rbSecim1.TabStop = true;
            this.rbSecim1.Text = "Seçim 1";
            this.rbSecim1.UseVisualStyleBackColor = true;
            this.rbSecim1.CheckedChanged += new System.EventHandler(this.rbSecim1_CheckedChanged);
            // 
            // rbSecim2
            // 
            this.rbSecim2.AutoSize = true;
            this.rbSecim2.Location = new System.Drawing.Point(27, 66);
            this.rbSecim2.Name = "rbSecim2";
            this.rbSecim2.Size = new System.Drawing.Size(76, 20);
            this.rbSecim2.TabIndex = 1;
            this.rbSecim2.TabStop = true;
            this.rbSecim2.Text = "Seçim 2";
            this.rbSecim2.UseVisualStyleBackColor = true;
            this.rbSecim2.CheckedChanged += new System.EventHandler(this.rbSecim2_CheckedChanged);
            // 
            // rbSecim4
            // 
            this.rbSecim4.AutoSize = true;
            this.rbSecim4.Location = new System.Drawing.Point(27, 151);
            this.rbSecim4.Name = "rbSecim4";
            this.rbSecim4.Size = new System.Drawing.Size(76, 20);
            this.rbSecim4.TabIndex = 3;
            this.rbSecim4.TabStop = true;
            this.rbSecim4.Text = "Seçim 4";
            this.rbSecim4.UseVisualStyleBackColor = true;
            this.rbSecim4.CheckedChanged += new System.EventHandler(this.rbSecim4_CheckedChanged);
            // 
            // rbSecim3
            // 
            this.rbSecim3.AutoSize = true;
            this.rbSecim3.Location = new System.Drawing.Point(27, 110);
            this.rbSecim3.Name = "rbSecim3";
            this.rbSecim3.Size = new System.Drawing.Size(76, 20);
            this.rbSecim3.TabIndex = 2;
            this.rbSecim3.TabStop = true;
            this.rbSecim3.Text = "Seçim 3";
            this.rbSecim3.UseVisualStyleBackColor = true;
            this.rbSecim3.CheckedChanged += new System.EventHandler(this.rbSecim3_CheckedChanged);
            // 
            // rbSecim5
            // 
            this.rbSecim5.AutoSize = true;
            this.rbSecim5.Location = new System.Drawing.Point(27, 194);
            this.rbSecim5.Name = "rbSecim5";
            this.rbSecim5.Size = new System.Drawing.Size(76, 20);
            this.rbSecim5.TabIndex = 4;
            this.rbSecim5.TabStop = true;
            this.rbSecim5.Text = "Seçim 5";
            this.rbSecim5.UseVisualStyleBackColor = true;
            this.rbSecim5.CheckedChanged += new System.EventHandler(this.rbSecim5_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(187, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 74);
            this.button1.TabIndex = 6;
            this.button1.Text = "göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(582, -1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(297, 500);
            this.listBox1.TabIndex = 7;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 507);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbSecim5);
            this.Controls.Add(this.rbSecim4);
            this.Controls.Add(this.rbSecim3);
            this.Controls.Add(this.rbSecim2);
            this.Controls.Add(this.rbSecim1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSecim1;
        private System.Windows.Forms.RadioButton rbSecim2;
        private System.Windows.Forms.RadioButton rbSecim4;
        private System.Windows.Forms.RadioButton rbSecim3;
        private System.Windows.Forms.RadioButton rbSecim5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}