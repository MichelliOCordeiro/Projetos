using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

class Programa
{
    //Fazer um programa para ler três medidas A, B e C. Em seguida,
    //calcular e mostrar (imprimir os dados
    //    com quatro casas decimais):
    //a) a área do quadrado que tem lado A
    //b) a área do triângulo retângulo que base A e altura B
    //c) a área do trapézio que tem bases A e B, e altura C
    //Exemplo 1:
    //Digite a medida A: 4.0
    //Digite a medida B: 3.5
    //Digite a medida C: 5.2
    //AREA DO QUADRADO = 16.0000
    //AREA DO TRIANGULO = 7.0000
    //AREA DO TRAPEZIO = 19.50000

    static void Main(string[] args)
    {
        decimal medidaA = 0;
        decimal medidaB = 0;
        decimal medidaC = 0;
        decimal areaDoQuadrado = 0;
        decimal areaDoTriangulo = 0;
        decimal areaDoTrapezio = 0;


        Console.WriteLine("Digite a medida A: ");
        medidaA = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite a medida A: ");
        medidaB = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite a medida A: ");
        medidaC = decimal.Parse(Console.ReadLine());

        areaDoQuadrado = medidaA * medidaA;

        areaDoTriangulo = medidaB * 2;

        areaDoTrapezio = ((medidaB + medidaB) * medidaA / medidaC) / 2;

        Console.WriteLine($"Area do quadrado é {areaDoQuadrado.ToString("C4")}");

        Console.WriteLine($"Area do triângulo é {areaDoTriangulo.ToString("C4")}");

        Console.WriteLine($"Area do trapézio é {areaDoTrapezio.ToString("C4")}");
    }
}
