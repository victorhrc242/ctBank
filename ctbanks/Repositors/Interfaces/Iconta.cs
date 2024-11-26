using ctBank.entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctbanks.Repositors.Interfaces
{
    public interface Icontas
    {
        public long Adicionar(conta conta);
        public void Remover(int id);
        public List<conta> Listar();
        public conta BuscarPorId(int id);
   
    }
}
