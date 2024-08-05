using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmContasBancarias : MetroFramework.Forms.MetroForm
    {
        

        public frmContasBancarias()
        {
            InitializeComponent();
        }

        private void playSimpleSound()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.som);
            player.Play();
        }

        private void playSimpleSound2()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.apito);
            player.Play();
        }

        private void playSimpleSound3()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.ps1);
            player.Play();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try {
               

                if (cboTipo.Text == "Conta Corrente")
                {
                    //Instanciar a Classe = carregar na memória
                    ContaCorrente cc = new ContaCorrente();

                    //A variavel cc é um objeto
                    cc.Agencia = Convert.ToInt32(txtAgencia.Text);
                    cc.Conta = Convert.ToInt32(txtConta.Text);
                    cc.Valor = Convert.ToDecimal(txtValor.Text);
                    cc.Tipo = cboTipo.Text;

                    string mensagem = cc.VerificarContaCorrente(cc.Conta);

                    if (mensagem == "Verificação OK.")
                    {
                        MessageBox.Show(mensagem, "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensagem + "\r\n Informe 5 digitos", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; //parar execução
                    }

                    dgvCorrente.Rows.Add(cc.Agencia, cc.Conta, cc.Valor, cc.Tipo);
                    playSimpleSound();

                    //Selecionar a guia indicada
                    tabContas.SelectedTab = tabCorrente;
                    
                    

                }

                else if(cboTipo.Text == "Conta Poupança"){

                    //Instanciar a Classe = carregar na memória
                    ContaPoupanca cp = new ContaPoupanca();

                    cp.Agencia = Convert.ToInt32(txtAgencia.Text);
                    cp.Conta = Convert.ToInt32(txtConta.Text);
                    cp.Valor = Convert.ToDecimal(txtValor.Text);

                    cp.Tipo = cboTipo.Text;

                    dgvPoupanca.Rows.Add(cp.Agencia, cp.Conta, cp.Valor, cp.Tipo);
                    playSimpleSound2();

                    string mensagem = cp.VerificarContaPoupanca(cp.Conta);

                    if (mensagem == "Verificação OK.")
                    {
                        MessageBox.Show(mensagem, "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensagem + "\r\n Informe 7 digitos", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; //parar execução
                    }

                    //Selecionar a guia indicada
                    tabContas.SelectedTab = tabPoupanca;

                }
            }catch(Exception erro) { 
                MessageBox.Show("ERRO - Valor Inválido. \n\n\n\n" + erro.Message);
                
            }
            //finally
            //{
            //    MessageBox.Show("Execução finally");
            //}  


            //chamada do procedimento
            LimparCampos();

        }

        //Procedimento - tem void
        private void LimparCampos()
        {
            txtAgencia.Clear();
            txtConta.Clear();
            txtValor.Clear();
            cboTipo.Text = "";
        }

        private void frmContasBancarias_Load(object sender, EventArgs e)
        {
            playSimpleSound3();
            esconderElementos();
            lblBemVindo.Visible = true;

        }

        private void frmContasBancarias_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void esconderElementos()
        {
            txtAgencia.Visible = false;
            txtConta.Visible = false;
            txtValor.Visible = false;

            lblAgencia.Visible=false;
            lblConta.Visible=false;
            lblValor.Visible=false;
            metroLabel1.Visible=false;

            dgvCorrente.Visible=false;
            dgvPoupanca.Visible=false;
            
            cboTipo.Visible=false;
            
            colAgencia.Visible=false;
            colAgenciaPoupanca.Visible = false;
            colContaPoupanca.Visible = false;
            colTipo.Visible=false;
            colTipoPoupanca.Visible = false;
            colValor.Visible=false;
            colValorPoupanca.Visible = false;
            
            btnAdicionar.Visible=false;

            tabContas.Visible=false;
            tabCorrente.Visible=false;
            
        }

        private void mostrarElementos()
        {
            txtAgencia.Visible = true;
            txtConta.Visible = true;
            txtValor.Visible = true;

            lblAgencia.Visible = true;
            lblConta.Visible = true;
            lblValor.Visible = true;
            metroLabel1.Visible = true;


            dgvCorrente.Visible = true;
            dgvPoupanca.Visible = true;

            cboTipo.Visible = true;

            colAgencia.Visible = true;
            colAgenciaPoupanca.Visible = true;
            colContaPoupanca.Visible = true;
            colTipo.Visible = true;
            colTipoPoupanca.Visible = true;
            colValor.Visible = true;
            colValorPoupanca.Visible = true;

            btnAdicionar.Visible = true;

            tabContas.Visible = true;
            tabCorrente.Visible = true;
        }

        private void prgTempo_Click(object sender, EventArgs e)
        {

        }

        private void tmrBemvindo_Tick(object sender, EventArgs e)
        {

            if (prgTempo.Value == 100)
            {
                tmrBemvindo.Enabled = false;
                lblBemVindo.Visible = false;
                mostrarElementos();
            }
            else
            {
                prgTempo.Value += 10;
            }
        }
    }
}
