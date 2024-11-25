using ctBank.entidades;
using ctbanks.Repositors.DTO;
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
    public class contacorrenterepositor
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
        public ContaCorrente BuscarPorVeiculoId(int veiculoId)
        {

            using var connection = new SQLiteConnection(ConnectionString);
            string query = "SELECT * FROM Carros WHERE VeiculoId = @VeiculoId";
            return connection.QueryFirstOrDefault<ContaCorrente>(query, new { VeiculoId = veiculoId });

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
