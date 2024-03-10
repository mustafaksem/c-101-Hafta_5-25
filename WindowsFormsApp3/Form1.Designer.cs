namespace WindowsFormsApp3
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
            this.cbSehirler = new System.Windows.Forms.ComboBox();
            this.lbMeyveler = new System.Windows.Forms.ListBox();
            this.lblSehirAdi = new System.Windows.Forms.Label();
            this.lblMeyveler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSehirler
            // 
            this.cbSehirler.FormattingEnabled = true;
            this.cbSehirler.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "izmir ",
            "Adana",
            "Bursa"});
            this.cbSehirler.Location = new System.Drawing.Point(28, 35);
            this.cbSehirler.Name = "cbSehirler";
            this.cbSehirler.Size = new System.Drawing.Size(274, 24);
            this.cbSehirler.TabIndex = 0;
            this.cbSehirler.SelectedIndexChanged += new System.EventHandler(this.cbSehirler_SelectedIndexChanged);
            // 
            // lbMeyveler
            // 
            this.lbMeyveler.FormattingEnabled = true;
            this.lbMeyveler.ItemHeight = 16;
            this.lbMeyveler.Items.AddRange(new object[] {
            "Armut",
            "Karpuz",
            "Kavun",
            "Üzüm",
            "Elma"});
            this.lbMeyveler.Location = new System.Drawing.Point(486, 28);
            this.lbMeyveler.Name = "lbMeyveler";
            this.lbMeyveler.Size = new System.Drawing.Size(334, 372);
            this.lbMeyveler.TabIndex = 1;
            this.lbMeyveler.SelectedIndexChanged += new System.EventHandler(this.lbMeyveler_SelectedIndexChanged);
            // 
            // lblSehirAdi
            // 
            this.lblSehirAdi.AutoSize = true;
            this.lblSehirAdi.Location = new System.Drawing.Point(35, 129);
            this.lblSehirAdi.Name = "lblSehirAdi";
            this.lblSehirAdi.Size = new System.Drawing.Size(44, 16);
            this.lblSehirAdi.TabIndex = 2;
            this.lblSehirAdi.Text = "label1";
            // 
            // lblMeyveler
            // 
            this.lblMeyveler.AutoSize = true;
            this.lblMeyveler.Location = new System.Drawing.Point(35, 187);
            this.lblMeyveler.Name = "lblMeyveler";
            this.lblMeyveler.Size = new System.Drawing.Size(44, 16);
            this.lblMeyveler.TabIndex = 3;
            this.lblMeyveler.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 429);
            this.Controls.Add(this.lblMeyveler);
            this.Controls.Add(this.lblSehirAdi);
            this.Controls.Add(this.lbMeyveler);
            this.Controls.Add(this.cbSehirler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSehirler;
        private System.Windows.Forms.ListBox lbMeyveler;
        private System.Windows.Forms.Label lblSehirAdi;
        private System.Windows.Forms.Label lblMeyveler;
    }
}

