using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

class Programa
{
    //Fazer um programa para ler os três coeficientes de uma equação do segundo grau.Usando a fórmula
    //de Baskara, calcular e mostrar os valores das raízes x1 e x2 da equação com quatro casas decimais,
    //conforme exemplo. Se a equação não possuir raízes reais, mostrar uma mensagem.
    //Exemplo 1:
    //Coeficiente a: 1
    //Coeficiente b: 0
    //Coeficiente c: -9
    //X1 = 3.0000
    //X2 = -3.0000

    static void Main(string[] args)
    {
        double coeficienteA = 0;
        double coeficienteB = 0;
        double coeficienteC = 0;
        double delta = 0;
        double x1 = 0;
        double x2 = 0;

        Console.WriteLine("Digite o coeficiente A: ");
        coeficienteA = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o coeficiente B: ");
        coeficienteB = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o coeficiente C: ");
        coeficienteC = int.Parse(Console.ReadLine());  

        delta = Math.Pow(coeficienteB, 2) - 4 * coeficienteA * coeficienteC;

        //if(coeficienteA == 0)
        //{
        //    Console.WriteLine("Esta equação tem raiz real");
        //} else if (x1 == (-coeficienteB + Ra))
        //{

        //}

    }
}
