using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctbanks.entidades.Interfaces
{
    public interface Iconta
    {
        // metodo depositar
        void Depositar(double valor);
        // metodo sacar

        bool Sacar(double valor);
        // metodo trasferir

        void Transferir(double valor, Iconta contaDestino);
        // metodo exibirinformaçoes

        void ExibirInformacoes();
    }
}
