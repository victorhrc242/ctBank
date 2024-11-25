using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctBank.entidades
{
    public class ContaCorrente:conta
    {
        public double LimiteDeCredito { get; set; }
        // sacar  dinheiro
        public virtual bool Sacar(double valor)
        {
            if (Saldo + LimiteDeCredito >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
