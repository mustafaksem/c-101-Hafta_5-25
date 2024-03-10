namespace Ders27_02
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
            this.dgOgrenciler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOgrenciler
            // 
            this.dgOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOgrenciler.Location = new System.Drawing.Point(41, 24);
            this.dgOgrenciler.Name = "dgOgrenciler";
            this.dgOgrenciler.RowHeadersWidth = 51;
            this.dgOgrenciler.RowTemplate.Height = 24;
            this.dgOgrenciler.Size = new System.Drawing.Size(812, 477);
            this.dgOgrenciler.TabIndex = 0;
            this.dgOgrenciler.SelectionChanged += new System.EventHandler(this.dgOgrenciler_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 529);
            this.Controls.Add(this.dgOgrenciler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOgrenciler;
    }
}

