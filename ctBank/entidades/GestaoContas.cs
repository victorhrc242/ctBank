using ctBank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctBank.entidades
{
    public class GestaoContas
    {
        // isso lisat as infromsçord
        private List<Iconta> contas = new List<Iconta>();

        // adiciona os usuarios
        public void AdicionarConta(Iconta conta)
        {
            contas.Add(conta);
        }
        // exibi todos os usuarios do Banko
        public void ExibirTodasContas()
        {
            foreach (var conta in contas)
            {
                conta.ExibirInformacoes();
            }
        }
    }
}
