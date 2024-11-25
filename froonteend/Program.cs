using ctBank.entidades;

conta conta1 = new conta { Titular = "breno", Saldo = 500 };
ContaCorrente conta2 = new ContaCorrente { Titular = "Gabriel", Saldo = 1000, LimiteDeCredito = 500 };
ContaPoupanca conta3 = new ContaPoupanca { Titular = "Eduarda", Saldo = 1000, TaxaDeJuros = 0.05 };

// Criando um gestor de contas
GestaoContas gestao = new GestaoContas();

// Adicionando as contas ao gestor
gestao.AdicionarConta(conta1);
gestao.AdicionarConta(conta2);
gestao.AdicionarConta(conta3);

// Exibindo todas as contas cadastradas
Console.WriteLine("Contas cadastradas:");
gestao.ExibirTodasContas();
Console.WriteLine();

// Realizando depósitos
Console.WriteLine("Realizando depósitos:");
conta1.Depositar(200);  
conta2.Depositar(300);  
conta3.Depositar(150);  
gestao.ExibirTodasContas();
Console.WriteLine();

// Realizando saques
Console.WriteLine("Realizando saques:");
conta1.Sacar(100);  
conta2.Sacar(600);  
conta3.Sacar(500);  
gestao.ExibirTodasContas();
Console.WriteLine();

// Realizando transferências
Console.WriteLine("Realizando transferências:");
conta2.Transferir(200, conta1);  
conta3.Transferir(100, conta2);  
gestao.ExibirTodasContas();
Console.WriteLine();

// Informações de todas as contas
Console.WriteLine("Informações finais das contas:");
gestao.ExibirTodasContas();