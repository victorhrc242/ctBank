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
    public interface Igestaodecompra
    {
        
        long Adicionar(GestãocompraDTO carro);
         void Remover(int id);
         GestaoContas BuscarPorVeiculoId(int veiculoId);
         List<GestaoContas> Listar();
         GestaoContas BuscarPorId(int id);
        
    
    }
}
