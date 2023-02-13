using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

class Programa
{
    //    Problema "operadora"
    //Uma operadora de telefonia cobra R$ 50.00 por um plano básico que dá direito a 100 minutos de
    //telefone.Cada minuto que exceder a franquia de 100 minutos custa R$ 2.00. Fazer um programa para
    //ler a quantidade de minutos que uma pessoa consumiu, daí mostrar o valor a ser pago.
    //Exemplo 1:
    //Digite a quantidade de minutos: 22
    //Valor a pagar: R$ 50.00

    static void Main(string[] args)
    {
        int qtdeMinutos = 0;
        int qteExcedente = 0;
        decimal vlrPagar = 0;
        decimal vlrNormal = 50;

        Console.WriteLine("Digite a quantidade de minutos: ");
        qtdeMinutos = int.Parse(Console.ReadLine());

        if (qtdeMinutos > 100)
        {
            qteExcedente = qtdeMinutos - 100;
            vlrPagar = vlrNormal + (qteExcedente * 2);
        } 
        else
        {
            vlrPagar = vlrNormal;
        }        

        Console.WriteLine($"O valor a pagar é de R$ {vlrPagar.ToString("C2")}");
    }
}
