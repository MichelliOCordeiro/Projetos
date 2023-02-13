using byteBank.Contas;
using byteBank.Titular;

////aqui estou criando o objeto que é a conta corrente, estou dando valores para esse objeto e seus campos.
////o conta corrente em verde quer dizer que estou dando um tipo "conta corrente" na variavel contaDaMichelli
//// isso quer dizer que agora a contadaMi tera uma agencia,conta, etc...
////quando chamo a variavel e dou o ponto ele entra nesses campos que defini na classe
//ContaCorrente contaDaMichelli = new ContaCorrente();

//contaDaMichelli.conta = "000";
////contaDaMichelli.titular = "Michelli";
//contaDaMichelli.saldo = 1000;
//contaDaMichelli.numeroAgencia = 1;

//Console.WriteLine($"O saldo da conta da Michelli é: {contaDaMichelli.saldo}");

//contaDaMichelli.Depositar(100);

//Console.WriteLine($"O saldo da conta da Michelli após o depósito é de: {contaDaMichelli.saldo}");

//if (contaDaMichelli.Sacar(1500) == true)
//{
//    Console.WriteLine($"O saldo da conta da Michelli após o saque é de: {contaDaMichelli.saldo}");
//}
//else
//{
//    Console.WriteLine("Você não possui saldo para sacar este valor");
//}

//ContaCorrente contaDoBob = new ContaCorrente();

//contaDoBob.conta = "001";
////contaDoBob.titular = "Bob";
//contaDoBob.saldo = 500;
//contaDoBob.numeroAgencia = 1;

//contaDaMichelli.Transferir(500, contaDoBob);

//Console.WriteLine($"O saldo da conta da Michelli após a transferencia é de: {contaDaMichelli.saldo}");

//Console.WriteLine($"O saldo da conta da Bob após o transferencia da Michelli é de: {contaDoBob.saldo}");

//contaDoBob.MostrarInfo();

//Cliente contaDoChoco = new Cliente();
//contaDoChoco.cpf = "123";
//contaDoChoco.profissao = "gerente";
//contaDoChoco.nome = "Chocolate";

//ContaCorrente contaChoco = new ContaCorrente();
//contaChoco.titular = new Cliente();
//contaChoco.titular.profissao = "oi";

////ContaCorrente contaDoLeo = new ContaCorrente();
//contaDoLeo.SetSaldo(200);
//Console.WriteLine(contaDoLeo.GetSaldo());

//quando usa uma propriedade static na hora de chamar ela, sempre deve ser chamado a classe e não o obj
//conta1 por ex, assim como o this no construtor nao pode ser usado, pq ele é do obj nao da classe
//ContaCorrente conta1 = new ContaCorrente(123, "1111-4");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//Cliente cliente1 = new Cliente("Michelli", "1111-4");
//Cliente conta2 = new Cliente("Bob", "1111-2");
//Cliente conta3 = new Cliente("Chocolate", "1111-3");
Cliente cliente4 = new Cliente("Leonardo", "1111-6");

//Console.WriteLine(Cliente.TotalDeClientes);

ContaCorrente cliente = new ContaCorrente(cliente4, 18, "455");
Console.WriteLine(cliente.Conta);





