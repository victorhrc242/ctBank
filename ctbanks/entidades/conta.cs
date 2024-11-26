using ctbanks.entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctBank.entidades
{
    public class conta:Iconta
    {
        public int id { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        // depositar
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        // sacar
        public  bool Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
        //trasferir
        public void Transferir(double valor, Iconta contaDestino)
        {
            if (Sacar(valor))
            {
                contaDestino.Depositar(valor);
            }
        }
        //exibir as informaçoes
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Titular: {Titular}, Saldo: {Saldo}");
        }
    }
}

