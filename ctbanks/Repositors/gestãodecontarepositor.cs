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
    public class gestãodecontarepositor
    {
        private readonly string ConnectionString;
        public gestãodecontarepositor(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public long Adicionar(GestãocompraDTO carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Insert<GestãocompraDTO>(carro);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            GestaoContas carro = BuscarPorId(id);
            connection.Delete<GestaoContas>(carro);
        }
        public GestaoContas BuscarPorVeiculoId(int veiculoId)
        {

            using var connection = new SQLiteConnection(ConnectionString);
            string query = "SELECT * FROM Carros WHERE VeiculoId = @VeiculoId";
            return connection.QueryFirstOrDefault<GestaoContas>(query, new { VeiculoId = veiculoId });

        }
        public List<GestaoContas> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<GestaoContas>().ToList();
        }
        public GestaoContas BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<GestaoContas>(id);
        }
    }
}
