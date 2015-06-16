using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using GQSLab.Model;

namespace GQSLab.WindowsForms
{
    public partial class frmProduto : Form
    {
        #region Variáveis

        public List<Produto> produtos = new List<Produto>();
        public int idProduto = 0;

        #endregion

        #region Enumerações

        public enum ColunaGrid
        {
            IdProduto = 1,
            Descricao = 2,
            Qtde = 3,
            Preco = 4
        }

        #endregion

        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            // Busca produtos           
            this.produtos = BuscaProdutos();

            // Popula combobox de Produtos
            ExibeProdutosCombobox(this.produtos);

            // Monta filtro de busca
            cbFiltro.Items.Insert(0, "Todos");
            cbFiltro.Items.Insert(1, "Por Produto");            
            cbFiltro.SelectedIndex = 0;
        }

        private void frmProduto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    break;
                case Keys.F2: btNovo.PerformClick();
                    break;
                case Keys.Escape: Close();
                    break;
            }
        }

        private void frmProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessTabKey(true);
            }
        }


        private void btNovo_Click(object sender, EventArgs e)
        {
            var fpCad = new frmProduto_Cadastro(this);
            fpCad.ShowDialog();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProduto.Enabled = !cbFiltro.Text.Equals("Todos");
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProdutos.DataSource = null;

                if (cbFiltro.Text.Equals("Todos"))
                {
                    // Exibe produtos no Grid
                    ExibeProdutosGrid(BuscaProdutos());
                }
                else
                {
                    // Obtem produto selecionado
                    var idProduto = 0;
                    if (cbProduto.SelectedValue != null && cbProduto.ValueMember != "")
                    {
                        var p = (Produto)cbProduto.SelectedValue;
                        idProduto = p.Id;
                    }

                    // Filtra produtos por id
                    var produtos = BuscaProdutos().Where(p => p.Id == idProduto).ToList();

                    // Exibe no Grid
                    ExibeProdutosGrid(produtos);
                }
            }
            catch (WarningException exc)
            {
                MessageBox.Show("Atenção!"
                    + "\n Desc: " + exc.Message, "GQSLab", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erro!"
                    + "\n Desc.:" + exc.Message, "GQSLab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Simula busca de produtos
        /// </summary>
        /// <returns></returns>
        public List<Produto> BuscaProdutos()
        {
            var produtos = new List<Produto>
                               {
                                   new Produto
                                       {
                                           Id = 1,
                                           Descricao = "Produto A",
                                           Preco = 15,
                                           Qtde = 20,
                                           DataVencimento = new DateTime(2015, 4, 1)
                                       },
                                   new Produto
                                       {
                                           Id = 2,
                                           Descricao = "Produto B",
                                           Preco = 20,
                                           Qtde = 25,
                                           DataVencimento = new DateTime(2015, 5, 27)
                                       },
                                   new Produto
                                       {
                                           Id = 3,
                                           Descricao = "Produto C",
                                           Preco = 30,
                                           Qtde = 35,
                                           DataVencimento = new DateTime(2015, 5, 16)
                                       }
                               };

            return produtos;
        }

        /// <summary>
        /// Popula Combobox de Produtos
        /// </summary>
        public void ExibeProdutosCombobox(List<Produto> produtos)
        {
            // Popula Combobox de Produtos
            cbProduto.DisplayMember = "Descricao";
            cbProduto.ValueMember = "IdProduto";
            cbProduto.DataSource = produtos;
        }

        /// <summary>
        /// Popula Grid de Produtos
        /// </summary>
        public void ExibeProdutosGrid(List<Produto> produtos)
        {
            // Popula Grid de Produtos
            dgvProdutos.DataSource = produtos;
        }


        private void dgvResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifica se é coluna correspondente
                //if (e.RowIndex >= 0 && e.ColumnIndex == colVisualizar.Index)
                //{
                //    // Obtem Id do Produto selecionado no Grid
                //    this._idProduto = Convert.ToInt32(dgvResultado.Rows[e.RowIndex].Cells[dgvResultado_colNIdProduto.Index].Value);

                //    // Ativa opções edição/exclusão
                //    AtivaOpcoesEdicao();

                //    // Exibe dados do Produto
                //    ExibeProduto(this._idProduto);
                //}
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erro!"
                    + "\n Desc.:" + exc.Message, "GQSLab", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
    }
}