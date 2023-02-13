using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
class Programa
{
    //Fazer um programa para calcular o troco no processo de pagamento de um produto de uma mercearia.
    //O programa deve ler o preço unitário do produto, a quantidade de unidades compradas deste produto,
    //e o valor em dinheiro dado pelo cliente(suponha que haja dinheiro suficiente). Seu programa deve
    //mostrar o valor do troco a ser devolvido ao cliente.
    //Exemplo 1:
    //Preço unitário do produto: 8.00
    //Quantidade comprada: 2
    //Dinheiro recebido: 20.00
    //TROCO = 4.00

    static void Main(string[] args)
    {
        decimal preco = 0;
        int qtdeComprada = 0;
        decimal valorRecebido = 0;
        decimal troco = 0;

        Console.WriteLine("Preço unitário do produto: ");
        preco = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Quantidade comprada: ");
        qtdeComprada = int.Parse(Console.ReadLine());

        Console.WriteLine("Dinheiro recebido: ");
        valorRecebido = decimal.Parse(Console.ReadLine());

        troco = valorRecebido - (preco * qtdeComprada);

        Console.WriteLine($"Seu troco sera de: {troco.ToString("C2", CultureInfo.CurrentCulture)}");        
    }
}


