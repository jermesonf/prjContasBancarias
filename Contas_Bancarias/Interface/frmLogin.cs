using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {


            //Instância das Classes
            Login login = new Login();
            AcessoLogin acessoLogin = new AcessoLogin();
            //Armazenar Login e Senha do formulário
            login.Usuario = txtUsuario.Text;
            login.Senha = txtSenha.Text;
            login.data = DateTime.Now;
            //Execução do método Acessar
            acessoLogin.Acessar(login);

            //Verificar se o status é Logado = 1
            if (login.Logado == 1)
            {
                MessageBox.Show(login.Mensagem, "Aviso");
                //Fechar Formulário de Login se usuário e senha estiverem corretos
                frmContasBancarias form = new frmContasBancarias();
                hideElements();
                prgBarra.Visible = true;
                tmrBarraProgresso.Enabled = true;
                //Close();
                //tmrBarraProgresso_Tick(null, null);

                AtualizaLogin atualiza = new AtualizaLogin();
                atualiza.AtualizarLogado(login);


                MessageBox.Show(login.Mensagem);
            }
            else
            {
                MessageBox.Show(login.Mensagem, "Aviso");
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
           
        }

        private void hideElements()
        {
            lblLogin.Hide();
            lblSenha.Hide();
            txtSenha.Hide();
            txtUsuario.Hide();
            btnIniciar.Hide();
        }

        private void tmrBarraProgresso_Tick(object sender, EventArgs e)
        {
            //Desligar o timer quando acima de 100
            if(prgBarra.Value == 100)
            {
                tmrBarraProgresso.Enabled = false;
                lblTexto1.Enabled = false;


                frmContasBancarias form = new frmContasBancarias();
                form.Show();
                this.Hide();

                form.Text += " - " + txtUsuario.Text + " - Acesso: " + DateTime.Now.ToString("g");
            }
            else if(prgBarra.Value == 1)
            {
                lblTexto1.Visible = true;
                prgBarra.Value += 1;
            }
            else if (prgBarra.Value == 40)
            {
                lblTexto1.Text = "Verificando Login";
                prgBarra.Value += 2;
            }
            else if (prgBarra.Value == 60)
            {
                lblTexto1.Text = "Quase lá";
                prgBarra.Value += 3;
            }
            else 
            { 
            prgBarra.Value += 1;
            }

           
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            AtualizaLogin atualiza = new AtualizaLogin();
            Login login = new Login();

            login.Usuario = txtUsuario.Text;

            atualiza.AtualizarLogadoLogoff(login);
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
