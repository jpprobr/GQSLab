namespace GQSLab.WindowsForms
{
    partial class frmLogo
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
            this.labelInfoSistema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfoSistema
            // 
            this.labelInfoSistema.AutoSize = true;
            this.labelInfoSistema.Font = new System.Drawing.Font("Segoe UI Semibold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoSistema.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelInfoSistema.Location = new System.Drawing.Point(244, 160);
            this.labelInfoSistema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfoSistema.Name = "labelInfoSistema";
            this.labelInfoSistema.Size = new System.Drawing.Size(444, 128);
            this.labelInfoSistema.TabIndex = 0;
            this.labelInfoSistema.Text = "GQS LAB";
            this.labelInfoSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(928, 744);
            this.Controls.Add(this.labelInfoSistema);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogo";
            this.Tag = "frmLogo";
            this.Text = "GQSLab";
            this.Resize += new System.EventHandler(this.frmLogo_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoSistema;
    }
}