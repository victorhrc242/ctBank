using ctBank.entidades;
using ctbanks.Repositors.DTO;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctbanks.Repositors.Interfaces
{
    public interface IContapoupanca
    {
         long Adicionar(contapopancaDTO carro);
         void Remover(int id);
         ContaPoupanca BuscarPorVeiculoId(int veiculoId);
         List<ContaPoupanca> Listar();
         ContaPoupanca BuscarPorId(int id);
 
    }
}
