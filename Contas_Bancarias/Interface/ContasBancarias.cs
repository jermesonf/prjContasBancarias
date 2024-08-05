using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class ContasBancarias
    {

        //Atributos = Variáveis
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public decimal Valor { get; set; }
        public string Tipo { get; set; }


        //Métodos = Ações = Funções
        // PROCEDIMENTO - tem void (sem retorno)
        // FUNÇÃO - Tem return (faz algo e retorna uma resposta)

        public string VerificarContaCorrente(int conta)
        {
            if (conta.ToString().Length == 5)
            {
                return "Verificação OK.";
            }
            else
            {
                return "Conta Invalida";
            }

            return "";
        }

        public string VerificarContaPoupanca(int conta)
        {
            if (conta.ToString().Length == 7)
            {
                return "Verificação OK.";
            }
            else
            {
                return "Conta Invalida";
            }

            return "";
        }

    }

    //Herança  : = extends
    public class ContaCorrente : ContasBancarias
    {

    }

    public class ContaPoupanca : ContasBancarias
    {

    }
}
