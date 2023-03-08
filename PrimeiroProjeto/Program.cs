using PrimeiroProjeto.Contas;
using PrimeiroProjeto.Titular;

//ContaCorrente contaUsuario = new ContaCorrente();

//contaUsuario.conta = "101010x";
////contaUsuario.titular = "José";
Cliente cliente = new Cliente();


cliente.Nome = "José";
cliente.Profissao = "Dev";
cliente.CPF = "738348348384748";

ContaCorrente conta = new ContaCorrente();

//Acessando Propriedade
conta.Numero_Agencia = 1;
//Lendo a propriedade
Console.WriteLine(conta.Numero_Agencia);

//conta.titular = cliente;
//conta.conta = "1921929";
//conta.numero_agencia = 1;
//conta.DefinirSaldo(2746) ;



//contaUsuario.numero_agencia = 2345;
//contaUsuario.saldo = 15;


//contaUsuario.Depositar(100);



//Console.WriteLine("Conta do Andé " + contaUsuario.saldo);

//ContaCorrente contaMaria = new ContaCorrente();

//contaUsuario.Transferir(100, contaMaria);

//Console.WriteLine("Conta Maria: " +  contaMaria.saldo);
//Console.WriteLine("Conta José: " + contaUsuario.saldo);

