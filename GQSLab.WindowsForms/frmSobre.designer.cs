namespace GQSLab.WindowsForms
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.labelNomeSistema = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDataAtualizacao = new System.Windows.Forms.Label();
            this.labelInfoAtualizacao = new System.Windows.Forms.Label();
            this.labelInfoEmpresa = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNomeSistema
            // 
            this.labelNomeSistema.AutoSize = true;
            this.labelNomeSistema.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeSistema.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelNomeSistema.Location = new System.Drawing.Point(15, 9);
            this.labelNomeSistema.Name = "labelNomeSistema";
            this.labelNomeSistema.Size = new System.Drawing.Size(117, 37);
            this.labelNomeSistema.TabIndex = 0;
            this.labelNomeSistema.Text = "GQSLab";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.labelDataAtualizacao);
            this.groupBox1.Controls.Add(this.labelInfoAtualizacao);
            this.groupBox1.Controls.Add(this.labelInfoEmpresa);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 90);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // labelDataAtualizacao
            // 
            this.labelDataAtualizacao.AutoSize = true;
            this.labelDataAtualizacao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDataAtualizacao.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelDataAtualizacao.Location = new System.Drawing.Point(175, 11);
            this.labelDataAtualizacao.Name = "labelDataAtualizacao";
            this.labelDataAtualizacao.Size = new System.Drawing.Size(94, 21);
            this.labelDataAtualizacao.TabIndex = 19;
            this.labelDataAtualizacao.Text = "15/06/2015";
            // 
            // labelInfoAtualizacao
            // 
            this.labelInfoAtualizacao.AutoSize = true;
            this.labelInfoAtualizacao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelInfoAtualizacao.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelInfoAtualizacao.Location = new System.Drawing.Point(6, 11);
            this.labelInfoAtualizacao.Name = "labelInfoAtualizacao";
            this.labelInfoAtualizacao.Size = new System.Drawing.Size(166, 21);
            this.labelInfoAtualizacao.TabIndex = 11;
            this.labelInfoAtualizacao.Text = "Última atualização em:";
            // 
            // labelInfoEmpresa
            // 
            this.labelInfoEmpresa.AutoSize = true;
            this.labelInfoEmpresa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoEmpresa.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelInfoEmpresa.Location = new System.Drawing.Point(7, 46);
            this.labelInfoEmpresa.Name = "labelInfoEmpresa";
            this.labelInfoEmpresa.Size = new System.Drawing.Size(494, 17);
            this.labelInfoEmpresa.TabIndex = 10;
            this.labelInfoEmpresa.Text = "Sistema Desenvolvido para a disciplina de Gestão da Qualidade de Software (GQS)";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(12, 145);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(88, 31);
            this.btOk.TabIndex = 11;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 183);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNomeSistema);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sobre o GQSLab";
            this.Load += new System.EventHandler(this.frmSobre_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSobre_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeSistema;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelInfoAtualizacao;
        private System.Windows.Forms.Label labelInfoEmpresa;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label labelDataAtualizacao;
    }
}