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
    // Fazer um programa para ler a quantidade de glicose no sangue de uma pessoa e
    // depois mostrar na tela a classificação desta glicose de acordo com
    //a tabela de referência ao lado.
    // Classificação Glicose
    //Normal Até 100 mg/dl
    //Elevado
    //Maior que 100 até
    //140 mg/dl
    //Diabetes Maior de 140 mg/dl
    //    Exemplo 1:
    //Digite a medida da glicose: 90.0
    //Classificacao: normal

    static void Main(string[] args)
    {
        decimal glicose = 0;
        string classificacao = "";

        Console.WriteLine("Digite a medida da glicose: ");
        glicose = decimal.Parse(Console.ReadLine());

        if (glicose <= 100)
        {
            classificacao = "Normal";
        }
        else if (glicose > 100 && glicose <= 140)
        {
            classificacao = "Elevado";
        } 
        else
        {
            classificacao = "Diabetes";
        }

        Console.WriteLine($"Sua classificação é {classificacao}");
    }
}
