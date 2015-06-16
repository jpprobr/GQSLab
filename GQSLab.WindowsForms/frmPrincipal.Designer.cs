namespace GQSLab.WindowsForms
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuOperacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuProduto,
            this.toolStripMenuOperacoes,
            this.toolStripMenuSobre,
            this.toolStripMenuSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuPrincipal.Size = new System.Drawing.Size(584, 73);
            this.menuPrincipal.TabIndex = 0;
            // 
            // toolStripMenuProduto
            // 
            this.toolStripMenuProduto.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuProduto.Image")));
            this.toolStripMenuProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuProduto.Name = "toolStripMenuProduto";
            this.toolStripMenuProduto.Size = new System.Drawing.Size(67, 67);
            this.toolStripMenuProduto.Tag = "frmProduto";
            this.toolStripMenuProduto.Text = "Produtos";
            this.toolStripMenuProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuProduto.ToolTipText = "Produto";
            this.toolStripMenuProduto.Click += new System.EventHandler(this.toolStripMenuProduto_Click);
            // 
            // toolStripMenuSobre
            // 
            this.toolStripMenuSobre.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuSobre.Image")));
            this.toolStripMenuSobre.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuSobre.Name = "toolStripMenuSobre";
            this.toolStripMenuSobre.Size = new System.Drawing.Size(60, 67);
            this.toolStripMenuSobre.Tag = "frmSobre";
            this.toolStripMenuSobre.Text = "Sobre";
            this.toolStripMenuSobre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuSobre.ToolTipText = "Sobre";
            this.toolStripMenuSobre.Click += new System.EventHandler(this.toolStripMenuSobre_Click);
            // 
            // toolStripMenuSair
            // 
            this.toolStripMenuSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuSair.Image")));
            this.toolStripMenuSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuSair.Name = "toolStripMenuSair";
            this.toolStripMenuSair.Size = new System.Drawing.Size(60, 67);
            this.toolStripMenuSair.Tag = "Sair";
            this.toolStripMenuSair.Text = "Sair";
            this.toolStripMenuSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuSair.ToolTipText = "Sair do Sistema";
            this.toolStripMenuSair.Click += new System.EventHandler(this.toolStripMenuSair_Click);
            // 
            // toolStripMenuOperacoes
            // 
            this.toolStripMenuOperacoes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuOperacoes.Image")));
            this.toolStripMenuOperacoes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripMenuOperacoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuOperacoes.Name = "toolStripMenuOperacoes";
            this.toolStripMenuOperacoes.Size = new System.Drawing.Size(75, 67);
            this.toolStripMenuOperacoes.Text = "Operações";
            this.toolStripMenuOperacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuOperacoes.ToolTipText = "Operações";
            this.toolStripMenuOperacoes.Click += new System.EventHandler(this.toolStripMenuOperacoes_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.menuPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "frmPrincipal";
            this.Text = "GQSLab";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmPrincipal_MdiChildActivate);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSobre;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSair;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuProduto;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuOperacoes;
    }
}

