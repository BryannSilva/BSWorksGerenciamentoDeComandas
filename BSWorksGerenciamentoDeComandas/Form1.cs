using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaBSWorks;

namespace BSWorksGerenciamentoDeComandas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (txbSenha.Text != "")
            {
                pibSenha.Visible = true;
            }
            else
            {
                pibSenha.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Verificar o tamanho do email e senha:
            if (txbEmail.Text.Length >= 6 && txbSenha.Text.Length >= 1)
            {
                // Fazer a validação:
                // Instanciar o usuário:
                Usuario usuario = new Usuario();

                // Atribuir os valores dos campos no usuário:
                usuario.Email = txbEmail.Text;
                usuario.Senha = txbSenha.Text;

                // Consultar os dados no banco e obter o resultado em uma tabela:
                DataTable resultado = Banco.UsuarioDAO.Logar(usuario);

                if (resultado.Rows.Count > 0)
                {
                    // Limpar os campos:
                    txbEmail.Clear();
                    txbSenha.Clear();

                    // Atribuir os resultados da consulta no obj usuario:
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                    usuario.Id = (int)resultado.Rows[0]["id"];

                    // Ir para o menu principal:
                    Views.MenuPrincipal menuPrincipal = new Views.MenuPrincipal(usuario);

                    // Esconder o form atual:
                    Hide();

                    // Mostrar o menu principal:
                    menuPrincipal.ShowDialog();

                    // Mostrar a tela de login após fechar o menu:
                    Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verifique as informações digitas!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pibSenha_Click(object sender, EventArgs e)
        {              
            
            //Esconder ou mostrar senha:                         
                
                if (txbSenha.UseSystemPasswordChar)
                {
                    pibSenha.Image = Properties.Resources.ver;
                    txbSenha.UseSystemPasswordChar = false;
                }
                else
                {
                    pibSenha.Image = Properties.Resources.esconder;
                    txbSenha.UseSystemPasswordChar = true;
                }        
            
            
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {
            if (txbSenha.Text != "")
            {
                pibSenha.Visible = true;
            }
            else
            {
                pibSenha.Visible = false;
            }
        }

        private void pibSenha_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
