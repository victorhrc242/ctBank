using ctBank.entidades;
using ctbanks.Repositors.DTO;
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
    public class contacorrenterepositor:Icontacorrente
    {
        private readonly string ConnectionString;
        public contacorrenterepositor(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public long Adicionar(contacorrenteDTO carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Insert<contacorrenteDTO>(carro);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            ContaCorrente carro = BuscarPorId(id);
            connection.Delete<ContaCorrente>(carro);
        }
        public ContaCorrente BuscarPorVeiculoId(int dConta)
        {

            using var connection = new SQLiteConnection(ConnectionString);
            string query = "SELECT * FROM ContaCorrentes WHERE IdConta = @IdConta";
            return connection.QueryFirstOrDefault<ContaCorrente>(query, new { IdConta = dConta });

        }
        public List<ContaCorrente> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<ContaCorrente>().ToList();
        }
        public ContaCorrente BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<ContaCorrente>(id);
        }
    }
}
