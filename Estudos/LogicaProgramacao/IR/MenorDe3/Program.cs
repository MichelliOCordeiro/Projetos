using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

class Programa
{
    //    Fazer um programa para ler três números inteiros.Em seguida, mostrar qual o menor dentre os três
    //números lidos.Em caso de empate, mostrar apenas uma vez.
    //Exemplo 1:
    //Primeiro valor: 7
    //Segundo valor: 3
    //Terceiro valor: 8
    //MENOR = 3

    static void Main(string[] args)
    {
        int numero1 = 0;
        int numero2 = 0;
        int numero3 = 0;
        int menorNumero = 0;

        Console.WriteLine("Digite o primeiro número: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro número: ");
        numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro número: ");
        numero3 = int.Parse(Console.ReadLine());

        if ((numero1 < numero2) && (numero2 < numero3)) 
        {
            menorNumero = numero1;
        } else if ((numero2 < numero3))
        {
            menorNumero = numero2;
        } else
        {
            menorNumero = numero3;
        }

        Console.WriteLine($"O menor número é: {menorNumero}");
    }
}
