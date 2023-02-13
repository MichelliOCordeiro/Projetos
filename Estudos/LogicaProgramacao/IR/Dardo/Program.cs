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
    //    Problema "dardo"
    //No arremesso de dardo, o atleta tem três chances para lançar o dardo à maior
    //distância que conseguir.
    //Você deve criar um programa para, dadas as medidas das três tentativas de
    //lançamento, informar qual foi a maior.
    //Exemplo 1:
    //Digite as tres distancias:
    //83.21
    //79.53
    //89.15
    //MAIOR DISTANCIA = 89.15

    static void Main(string[] args)
    {
        decimal distancia1 = 0;
        decimal distancia2 = 0;
        decimal distancia3 = 0;
        decimal maiorDistancia = 0;

        Console.WriteLine("Digite a primeira distância: ");
        distancia1 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite a primeira distância: ");
        distancia2 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite a primeira distância: ");
        distancia3 = decimal.Parse(Console.ReadLine());

        if ((distancia1 > distancia2) && (distancia2 > distancia3))
        {
            maiorDistancia = distancia1;
        }
        else if ((distancia2 > distancia3))
        {
            maiorDistancia = distancia2;
        }
        else
        {
            maiorDistancia = distancia3;
        }

        Console.WriteLine($"A maior distância é: {maiorDistancia}");
    }
}
