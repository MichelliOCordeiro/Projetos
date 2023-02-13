using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

class Programa
{
    // Fazer um programa para ler as duas notas que um aluno obteve no primeiro e segundo semestres de
    // uma disciplina anual.Em seguida, mostrar a nota final que o aluno obteve(com uma casa decimal) no
    //ano juntamente com um texto explicativo.Caso a nota final do aluno seja inferior a 60.00, mostrar a
    //mensagem "REPROVADO", conforme exemplos.
    //    Exemplo 1:
    //Digite a primeira nota: 45.5
    //Digite a segunda nota: 31.3
    //NOTA FINAL = 76.8


    static void Main(string[] args)
    {
        decimal nota1 = 0;
        decimal nota2 = 0;
        decimal notaFinal = 0;

        Console.WriteLine("Digite a primeira nota: ");
        nota1 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota: ");
        nota2 = decimal.Parse(Console.ReadLine());

        notaFinal = nota1 + nota2;

        Console.WriteLine($"A sua nota final é: {notaFinal}");

        if(notaFinal < 60)
        {
            Console.WriteLine("REPROVADO");
        } 
    }
}
