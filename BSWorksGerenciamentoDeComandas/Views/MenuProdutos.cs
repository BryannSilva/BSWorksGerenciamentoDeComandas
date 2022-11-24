using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaBSWorks;

namespace BSWorksGerenciamentoDeComandas.Views
{
    public partial class MenuProdutos : Form
    {
        Usuario usuario;
        int idSelecionado = 0;

        public MenuProdutos(Usuario u)
        {
            InitializeComponent();            

            // Mudar o label:
            lblInformacao.Text = "Você está logado como " + u.NomeCompleto;
            this.usuario = u;

            // Salvar o resultado da listagem de categorias em um objeto:
            var r = Banco.CategoriaDAO.ListarTudo();
            ArrayList rows = new ArrayList();
            // Converter esse objeto para array:
            foreach (DataRow dataRow in r.Rows)
            {
                rows.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Atribuir os valores nos cmbs:
            cmbIdCategoriaCad.DataSource = rows;
            cmbIdCategoriaEdi.DataSource = rows.Clone();
            // Atribuir a tabela de produtos no dgv:
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();

            AtualizarDgv();
        }

        private int obterIDdaString(string texto)
        {
            /* Ao chamar obterIDdaString("12 - Alimentação")
             * o resultador será 12
             * Show?
             */
            return int.Parse(texto.Split(' ')[0]);
        }

        public void AtualizarDgv()
        {
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja remover o seguinte produto \n" +
               "" + lblRemover.Text + "?", "Atenção!",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                // Apagar o usuário:
                if (Banco.ProdutoDAO.Remover(idSelecionado) != -1)
                {
                    MessageBox.Show("Produto removido!", "Atenção!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // Atualizar o dgv;
                    AtualizarDgv();

                    // Desativar os campos:
                    grbEditar.Enabled = false;
                    grbRemover.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Houve um erro ao remover!", "Atenção!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
           

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os groupboxes:
            grbEditar.Enabled = true;
            grbRemover.Enabled = true;

            // Obter o número da linha selecionada:

            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex;

            // Obter toda a linha selecionada:
            var dadosLinha = dgvProdutos.Rows[linhaSelecionada];

            // Popular os campos do editar:
            txbNomeEdi.Text = dadosLinha.Cells[1].Value.ToString();
            txbPrecoEdi.Text = dadosLinha.Cells[2].Value.ToString();
            

            // Popuplar o "remover":
            lblRemover.Text = dadosLinha.Cells[0].Value.ToString() + " - " + dadosLinha.Cells[1].Value.ToString();

            // Salvar o id na variavel global:
            idSelecionado = (int)dadosLinha.Cells[0].Value;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar se os campos estão vazios:
            if (txbNomeEdi.Text != "" && txbPrecoEdi.Text != "")
            {
                // Instanciar o produto:
                Produto produto = new Produto();

                // Obter as informações dos campos:
                produto.Id = idSelecionado;
                produto.Nome = txbNomeEdi.Text;
                produto.Preco = double.Parse(txbPrecoEdi.Text);
                produto.IdCategoria = obterIDdaString(cmbIdCategoriaEdi.Text);

                if (Banco.ProdutoDAO.Editar(produto))
                {
                    MessageBox.Show("Usuário modificado com sucesso!");
                    
                    // Atualizar o DGV:
                    AtualizarDgv();
                    grbEditar.Enabled = false;
                    grbRemover.Enabled = false;                    
                }
                else
                {
                    MessageBox.Show("Erro ao modificar produto");
                }

                MessageBox.Show("Produto editado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Atualizar o dgv;
                AtualizarDgv();

                // Desativar os campos:
                grbEditar.Enabled = false;
                grbRemover.Enabled = false;
            }
            else
            {
                MessageBox.Show("Houve um erro ao editar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Verificar se os campos estão vazios:
            if (txbNomeCad.Text.Length >= 5 && txbIdCadastroCad.Text.Length >= 1
                && txbPrecoCad.Text.Length >= 2)
            {
                // Instanciar o produto:
                Produto produto = new Produto();

                // Obter as informações dos campos:
                produto.Id = idSelecionado;
                produto.Nome = txbNomeCad.Text;
                produto.Preco = double.Parse(txbPrecoCad.Text);
                produto.IdCategoria = obterIDdaString(cmbIdCategoriaEdi.Text);
                produto.IdRespCadastro = usuario.Id;

                // Enviar para o banco e verificar se deu certo:
                if (Banco.ProdutoDAO.Cadastrar(produto))
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");

                    // Limpar os campos:
                    txbNomeCad.Clear();
                    txbIdCadastroCad.Clear();
                    txbPrecoCad.Clear();

                    // Atualizar o dgv:
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar produto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
