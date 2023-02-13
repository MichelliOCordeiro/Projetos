using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
class Programa
{
    //Fazer um programa para ler dois valores inteiros X e Y, e depois mostrar na tela o valor da soma destes
    //números.
    //Exemplo 1:
    //Digite o valor de X: 8
    //Digite o valor de Y: 10
    //SOMA = 18

    static void Main(string[] args)
    {
        int x = 0;
        int y = 0;
        int soma = 0;

        Console.WriteLine("Digite o valor de X: ");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de X: ");
        y = int.Parse(Console.ReadLine());

        soma = x + y;

        Console.WriteLine($"A soma é igual a: {soma}");
    }
}
