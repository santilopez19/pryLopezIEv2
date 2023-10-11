namespace pryLopezIE
{
    partial class frmCargar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargar));
            this.prbCarga = new System.Windows.Forms.ProgressBar();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.timerCarga = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // prbCarga
            // 
            this.prbCarga.BackColor = System.Drawing.Color.Black;
            this.prbCarga.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prbCarga.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.prbCarga.Location = new System.Drawing.Point(0, 626);
            this.prbCarga.Margin = new System.Windows.Forms.Padding(4);
            this.prbCarga.Name = "prbCarga";
            this.prbCarga.Size = new System.Drawing.Size(1018, 28);
            this.prbCarga.Step = 100;
            this.prbCarga.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbCarga.TabIndex = 4;
            // 
            // pctLogo
            // 
            this.pctLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(0, 0);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(1018, 626);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 5;
            this.pctLogo.TabStop = false;
            // 
            // timerCarga
            // 
            this.timerCarga.Enabled = true;
            this.timerCarga.Tick += new System.EventHandler(this.timerCarga_Tick);
            // 
            // frmCargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1018, 654);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.prbCarga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCargar";
            this.Load += new System.EventHandler(this.frmCargar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prbCarga;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Timer timerCarga;
    }
}