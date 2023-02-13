using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
class Programa
{
    //    Fazer um programa para calcular o troco no processo de pagamento de um produto de uma mercearia.
    //O programa deve ler o preço unitário do produto, a quantidade de unidades compradas deste produto,
    //e o valor em dinheiro dado pelo cliente.Seu programa deve mostrar o valor do troco a ser devolvido
    //ao cliente. Se o dinheiro dado pelo cliente não for suficiente, mostrar uma mensagem informando o
    //valor restante conforme exemplo.
    //Exemplo 1:
    //Preço unitário do produto: 8.00
    //Quantidade comprada: 2
    //Dinheiro recebido: 20.00
    //TROCO = 4.00

    static void Main(string[] args)
    {
        decimal precoUnitario = 0;
        int qtdeComprada = 0;
        decimal vlrCompra = 0;
        decimal vlrDinheiro = 0;
        decimal troco = 0;

        Console.WriteLine("Digite o preço unitário do produto: ");
        precoUnitario = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade comprada: ");
        qtdeComprada = int.Parse(Console.ReadLine());   

        vlrCompra = precoUnitario * qtdeComprada;

        Console.WriteLine("Valor recebido: ");
        vlrDinheiro = decimal.Parse(Console.ReadLine());        

        if (vlrDinheiro < vlrCompra)
        {
           troco = vlrCompra - vlrDinheiro;
           Console.WriteLine($"Dinheiro insuficiente. Faltam {troco.ToString("c2")} reais");
        } 
        else
        {
            troco = vlrDinheiro - vlrCompra;
            Console.WriteLine($"Seu troco é de: {troco.ToString("c2")} reais");
        }
    }
}