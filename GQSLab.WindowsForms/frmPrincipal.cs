using System;
using System.Windows.Forms;

namespace GQSLab.WindowsForms
{
    /// <summary>
    /// Form Principal 
    /// Contém o menu e o mdiContainer
    /// </summary>
    public partial class frmPrincipal : Form
    {      
        /// <summary>
        /// Método Construtor sem parâmetros
        /// </summary>        
        public frmPrincipal()
        {
            InitializeComponent();
        }     
        
        /// <summary>
        /// Executa quando o form é carregado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Abre o form c/ Logo
            frmLogo fLogo = new frmLogo();
            AbreForm(fLogo);

            // Exibe opções do menu
            ExibeMenuPrincipal();
        }

        /// <summary>
        /// Executa quando o form logo é focado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPrincipal_MdiChildActivate(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in menuPrincipal.Items)
            {
                if (this.ActiveMdiChild != null && item.Tag != null && item.Tag.ToString().Equals(this.ActiveMdiChild.Name))
                {
                    item.BackColor = System.Drawing.SystemColors.Control;
                }
                else
                {
                    item.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                }
            }
        }


        /// <summary>
        /// Função genérica para abrir e configurar os forms
        /// </summary>
        /// <param name="f"></param>
        private void AbreForm(Form f)
        {
            if (f != null)
            {
                // Seta o frmPrincipal como pai do form f
                f.MdiParent = this;

                // Faz o form f preencher toda a tela
                f.Dock = DockStyle.Fill;

                f.FormClosed += new FormClosedEventHandler(f_FormClosed);

                // Mostra o form f
                f.Show();
            }
        }

        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = (Form)sender;
            f.Dispose();
            f = null;
        }

        /// <summary>
        /// Verifica se Form já existe
        /// </summary>
        /// <param name="frm"></param>
        /// <returns></returns>
        public bool ExisteForm(String frm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(frm))
                {
                    f.Activate();
                    return true;
                }
            }

            return false;
        }

        #region Menu

        /// <summary>
        /// Executa quando o item Produto é clicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuProduto_Click(object sender, EventArgs e)
        {
            if (!ExisteForm("frmProduto"))
            {
                frmProduto fProduto = new frmProduto();
                AbreForm(fProduto);
            }          

            foreach (ToolStripItem item in menuPrincipal.Items)
            {
                item.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            }

            toolStripMenuProduto.BackColor = System.Drawing.SystemColors.Control;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuOperacoes_Click(object sender, EventArgs e)
        {
            if (!ExisteForm("frmOperacoes"))
            {
                frmOperacoes fOperacoes = new frmOperacoes();
                AbreForm(fOperacoes);
            }
        }

        /// <summary>
        /// Executa quando o item Sobre for clicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuSobre_Click(object sender, EventArgs e)
        {
            frmSobre fSobre = new frmSobre();
            fSobre.ShowDialog();

            foreach (ToolStripItem item in menuPrincipal.Items)
            {
                item.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            }

            toolStripMenuSobre.BackColor = System.Drawing.SystemColors.Control;
        }

        /// <summary>
        /// Executa quando o item Sair for clicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuSair_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        /// <summary>
        /// Exibe menus
        /// </summary>
        public void ExibeMenuPrincipal()
        {
            try
            {
                foreach (ToolStripItem item in menuPrincipal.Items)
                {
                    if (!item.Tag.Equals("Sair") && !item.Tag.ToString().Equals("frmSobre"))
                        item.Visible = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erro!"
                    + "\n Desc.:" + exc.Message, "GQSLab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion       
    }
}