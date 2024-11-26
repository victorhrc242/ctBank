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
    public interface Icontacorrente
    {
        long Adicionar(contacorrenteDTO carro);

        void Remover(int id);

        ContaCorrente BuscarPorVeiculoId(int veiculoId);


        List<ContaCorrente> Listar();
        
     

    }
}
