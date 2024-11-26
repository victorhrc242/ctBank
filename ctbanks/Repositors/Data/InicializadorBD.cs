using System.Data.SQLite;
using Dapper;

public class InicializadorBD
{
    private const string ConnectionString = "Data Source=Banco.db"; // Caminho do banco de dados SQLite

    public static void Inicializar()
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();

            // Criar tabela Conta
            string commandoSQL = @"
            CREATE TABLE IF NOT EXISTS Contas (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Titular TEXT NOT NULL,
                Saldo DOUBLE NOT NULL
            );";

            connection.Execute(commandoSQL);

            // Criar tabela ContaCorrente
            commandoSQL = @"
            CREATE TABLE IF NOT EXISTS ContaCorrentes (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                LimiteDeCredito DOUBLE NOT NULL,
                IdConta INTEGER,
                FOREIGN KEY (IdConta) REFERENCES Conta(Id)
            );";

            connection.Execute(commandoSQL);

            // Criar tabela ContaPoupanca
            commandoSQL = @"
            CREATE TABLE IF NOT EXISTS ContaPoupancas (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                TaxaDeJuros DOUBLE NOT NULL,
                IdConta INTEGER,
                FOREIGN KEY (IdConta) REFERENCES Conta(Id)
            );";

            connection.Execute(commandoSQL);

            // Criar tabela GestaoContas
            commandoSQL = @"
            CREATE TABLE IF NOT EXISTS GestaoContas (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                IdConta INTEGER,
                FOREIGN KEY (IdConta) REFERENCES Conta(Id)
            );";

            connection.Execute(commandoSQL);
        }
    }
}
