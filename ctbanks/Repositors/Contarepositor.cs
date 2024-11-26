using ctBank.entidades;
using ctbanks.entidades.Interfaces;
using ctbanks.Repositors.Interfaces;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctbanks.Repositors
{
    public class Contarepositor:Icontas
    {
        private readonly string ConnectionString;
        public Contarepositor(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public long Adicionar(conta conta)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Insert<conta>(conta);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            conta conta = BuscarPorId(id);
            connection.Delete<conta>(conta);
        }
        public List<conta> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<conta>().ToList();
        }
        public conta BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<conta>(id);
        }
    }
}
