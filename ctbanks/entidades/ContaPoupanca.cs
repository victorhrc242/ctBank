using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctBank.entidades
{
    public class ContaPoupanca:conta
    {
        public double TaxaDeJuros { get; set; }

        // depositar dinheiro na conta de outro usuario ou na conta do msm usuario
        public virtual void Depositar(double valor)
        {
            Saldo += valor;
            Saldo += Saldo * TaxaDeJuros;  // Aplica os juros após o depósito
        }
    }
}
