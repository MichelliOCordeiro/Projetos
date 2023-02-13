using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

class Programa
{
    //    Fazer um programa para ler a distância total(em km) percorrida por um carro,
    //    bem como o total de
    //combustível gasto por este carro ao percorrer tal distância.
    //Seu programa deve mostrar o consumo
    //médio do carro, com três casas decimais.
    //    Exemplo 1:
    //Distancia percorrida: 500
    //Combustível gasto: 38.5
    //Consumo medio = 12.987

    static void Main(string[] args)
    {
        int distancia = 0;
        decimal combustivel = 0;
        decimal consumoMedio = 0;

        Console.WriteLine("Informe a distancia percorrida: ");
        distancia = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor do combustível gasto: ");
        combustivel = decimal.Parse(Console.ReadLine().Replace(".", ","));    

        consumoMedio = distancia / combustivel;

        Console.WriteLine($"O consumo médio foi de {consumoMedio.ToString("C3")}");
    }

}
