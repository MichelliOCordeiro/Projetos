using System;
using System.Globalization;

class Programa
{
    // Fazer um programa para ler as medidas da base e altura de um retângulo.Em seguida, mostrar o valor
    //da área, perímetro e diagonal deste retângulo, com quatro casas decimais, conforme exemplos.
    // Base do retangulo: 4.0
    //Altura do retangulo: 5.0
    //AREA = 20.0000
    //PERIMETRO = 18.0000
    //DIAGONAL = 6.4031
    static void Main(string[] args)
    {
        double baseRetangulo = 0;
        double altura = 0;
        double area = 0;
        double perimetro = 0;
        double diagonal1 = 0;
        double diagonal2 = 0;
        double raiz = 0;


        Console.WriteLine("Digite a base do retangulo: ");
        baseRetangulo = double.Parse(Console.ReadLine().Replace(".", ","));

        Console.WriteLine("Digite a altrura do retangulo: ");
        altura = double.Parse(Console.ReadLine().Replace(".", ","));
        
        // á𝑟𝑒𝑎 = 𝑏𝑎𝑠𝑒 × 𝑎𝑙𝑡𝑢𝑟𝑎
        // 𝑝𝑒𝑟𝑖𝑚𝑒𝑡𝑟𝑜 = 2 × 𝑏𝑎𝑠𝑒 +2 × 𝑎𝑙𝑡𝑢𝑟𝑎 𝑑𝑖𝑎𝑔𝑜𝑛𝑎𝑙 = 𝑏𝑎𝑠𝑒ଶ + 𝑎𝑙𝑡𝑢𝑟𝑎ଶ
        //𝑑𝑖𝑎𝑔𝑜𝑛𝑎𝑙 = 𝑏𝑎𝑠𝑒2 + 𝑎𝑙𝑡𝑢𝑟𝑎2

        area = baseRetangulo * altura;
        perimetro = 2 * baseRetangulo + 2 * altura;

        diagonal1 = Math.Pow(baseRetangulo, 2);
        diagonal2 = Math.Pow(altura, 2);

        raiz = Math.Sqrt(diagonal1 + diagonal2);

        Console.WriteLine($"Area: {(area).ToString("C4", CultureInfo.CurrentCulture)}");
        Console.WriteLine($"Perimetro: {(perimetro).ToString("C4", CultureInfo.CurrentCulture)}");
        Console.WriteLine($"Diagonal: {(raiz).ToString("C4", CultureInfo.CurrentCulture)}");
    }
}

