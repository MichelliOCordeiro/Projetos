using System;
using System.Globalization;

class Programa
{
//Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma
//casa decimal, bem como o valor do metro quadrado do terreno com duas casas decimais.Em seguida,
//o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno, ambos com
//duas casas decimais, conforme exemplo.

    static void Main(string[] args)
    {
        double largura = 0;
        double comprimento = 0;
        double metroQuadrado = 0;
        double area = 0;
        double valor = 0;

        Console.WriteLine("Digite a largura do terreno: ");
        largura = double.Parse(Console.ReadLine().Replace(".", ","));

        Console.WriteLine("Digite o comprimento do terreno: ");
        comprimento = double.Parse(Console.ReadLine().Replace(".", ","));

        Console.WriteLine("Digite o valor do metro quadrado: ");
        metroQuadrado = double.Parse(Console.ReadLine().Replace(".", ","));

        area = comprimento * largura;
        valor = area * metroQuadrado;

        Console.WriteLine($"Area do terreno: {(area).ToString("C2", CultureInfo.CurrentCulture)}");
        Console.WriteLine($"Preço do terreno: {(valor).ToString("C2", CultureInfo.CurrentCulture)}");
    }
}

