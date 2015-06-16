using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using System.Data;
using GQSLab.Model;

namespace GQSLab.WindowsForms
{
    public partial class frmProduto_Cadastro : Form
    {
        #region Variáveis

        private frmProduto _formProdutos;

        private Boolean alteraProduto = false;
        private int _idProduto = 0;
        private string sDescricao = "";
        private int nIdUsuario = 0;
        private int qtdeInicialEstoque = 0;

        private decimal nPrecoCusto = 0;
        private decimal nPercentLucro = 0;

        private int nQtde = 0;

        #region Indices de colunas do Grid

        private int _colNidProduto = 1;
        private int _colCodigoBarra = 2;
        private int _colDescricao = 3;
        private int _colDataCadastro = 5;
        private int _colPrecoCusto = 6;
        private int _colLucro = 7;
        private int _colPrecoVenda = 8;

        #endregion

        #endregion

        #region Construtores
                
        public frmProduto_Cadastro()
        {
            InitializeComponent();
        }

        public frmProduto_Cadastro(frmProduto fp)
        {
            this._formProdutos = fp;

            InitializeComponent();
        }

        #endregion

        /// <summary>
        /// Carrega o Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProduto_Load(object sender, EventArgs e)
        {

        }

        private void frmProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessTabKey(true);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal preco;
                int qtde;
                DateTime dataVencimento;

                // Validação de Descrição
                if(String.IsNullOrEmpty(txtDescricao.Text)) // trim
                    throw new WarningException("Nenhuma descrição foi informada!");

                // Validação de Preço
                if (!Decimal.TryParse(txtPreco.Text, out preco))
                    throw new WarningException("Preço informado é inválido!");

                // Validação de Qtde
                if (!Int32.TryParse(txtQtde.Text, out qtde))
                    throw new WarningException("Quantidade informada é inválida!");

                // Validação de Data de Vencimento
                if (!DateTime.TryParse(txtDataVencimento.Text, out dataVencimento))
                    throw new WarningException("Data de Vencimento informada é inválida!");

                // Monta objeto Produto
                Produto p = new Produto {
                    Id = (this._formProdutos.produtos.Count + 1), // incrementa 1 da coleção
                    Descricao = txtDescricao.Text, 
                    Preco = Convert.ToDecimal(preco), 
                    Qtde = Convert.ToInt32(qtde), 
                    DataVencimento = Convert.ToDateTime(dataVencimento)
                };

                // Executa Validação c/ o Data Annotations
                Validar(p);

                // Salva objeto no List
                this._formProdutos.produtos.Add(p);

                // Atualiza/exibe grid de produtos
                this._formProdutos.ExibeProdutosGrid(this._formProdutos.produtos);
                
                // Exibe mensagem informativa
                MessageBox.Show("Produto salvo com sucesso!", "GQSLab - Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
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

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Popula Combobox de Produtos nas Abas
        /// </summary>
        public void PopulaComboboxProdutos()
        {
            // Popula Combobox de Produtos da Aba Localizar
            //cbProduto.DisplayMember = "sDescricao";
            //cbProduto.ValueMember = "nIdProduto";

            // Parametro 0 = pegar todos os produtos e 1 = com preços e registros de estoque
            //cbProduto.DataSource = produtoDao.BuscaProdutos(0, 0);
        }

        /// <summary>
        /// Exibe dados do Produto
        /// </summary>
        public void ExibeProduto(int idProduto)
        {
            try
            {
                // Busca registro de Produto
                //dtProduto = produtoDao.BuscaProdutos(_idProduto, 0);

                // Verifica se Produto foi encontrado
                //if (dtProduto.Rows.Count <= 0)
                //    throw new Exception("Não foi possível obter dados do Produto selecionado!");

                // Preeche campos de Produto
                //txtIdProduto.Text = dtProduto.Rows[0]["nIdProduto"].ToString();
                //txtCodBarra.Text = dtProduto.Rows[0]["nCodBarra"].ToString();
                //txtDescricao.Text = dtProduto.Rows[0]["sDescricao"].ToString();
                //txtPrecoCusto.Text = Validacao.ConvertParaMilhar(dtProduto.Rows[0]["nPrecoCusto"].ToString());
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


        public void Validar(object obj)
        {
            var erros = Validacao.GetValidationErrors(obj);

            foreach (var error in erros)
            {
                //MessageBox.Show((error.ErrorMessage));
                throw new WarningException(error.ErrorMessage);
            }
        }
        
        #region VALIDAÇÃO - DESATIVADO

        /// <summary>
        /// Converte textos p/ letras Maiúsculas
        /// </summary>
        /// <param name="sender">Objeto</param>
        /// <param name="e">Evento</param>
        private void ValidaTxtMaiusculas(object sender, KeyPressEventArgs e)
        {
            // Converte p/ maiúsculas
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        /// <summary>
        /// Valida Campos do Tipo Inteiro
        /// </summary>
        /// <param name="sender">Objeto</param>
        /// <param name="e">Evento</param>
        private void ValidaTxtInt(object sender, KeyPressEventArgs e)
        {
            // Verificando as expressões regulares - Aceitar somente nº, backspace
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0-9]|[\b]"))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        /// <summary>
        /// Valida campos do Tipo Decimal
        /// </summary>
        /// <param name="sender">Objeto</param>
        /// <param name="e">Evento</param>
        private void ValidaTxtDec(object sender, KeyPressEventArgs e)
        {
            // Verificando as expressões regulares - Aceitar só nº, backspace, vírgula
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0-9]|[\b]|[,]"))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        #endregion                
    }
}