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
    public class contapoupaçarepositor:IContapoupanca
    {
        private readonly string ConnectionString;
        public contapoupaçarepositor(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public long Adicionar(contapopancaDTO carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Insert<contapopancaDTO>(carro);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            ContaPoupanca carro = BuscarPorId(id);
            connection.Delete<ContaPoupanca>(carro);
        }

        public ContaPoupanca BuscarPorVeiculoId(int IdConta)
        {

            using var connection = new SQLiteConnection(ConnectionString);
            string query = "SELECT * FROM ContaPoupancas WHERE IdConta = @IdConta";
            return connection.QueryFirstOrDefault<ContaPoupanca>(query, new { IdConta = IdConta });

        }
        public List<ContaPoupanca> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<ContaPoupanca>().ToList();
        }
        public ContaPoupanca BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<ContaPoupanca>(id);
        }
    }
}

