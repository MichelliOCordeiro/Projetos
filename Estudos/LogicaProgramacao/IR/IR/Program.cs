using System;
using System.Drawing;

class Programa
{   
    //O João gostaria de criar um programa sobre Imposto de Renda(IR) e verificou as regras de alíquota.
    //Ele descobriu no site da receita o seguinte:
    //De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
    //De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
    //De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636.

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o seu salario: ");
        double salario = int.Parse(Console.ReadLine());

        if (salario <=2800.00 || salario <= 1900.0)
        {
            Console.WriteLine("A aliquota é de 7,5% e pode deduzir na declaração o valor de R$ 142");
        }

        else if (salario <= 3751.00 || salario >=2800.01)
        {
            Console.WriteLine("A aliquota é de 15% e pode deduzir na declaração o valor de R$ 350");
        }
        else if (salario <= 4664.00 || salario >= 3751.01)
        {
            Console.WriteLine("A aliquota é de 22,5% e pode deduzir na declaração o valor de R$ 636");
        }

        Console.WriteLine("Gostaria de fazer mais alguma pesquisa? Digite 1(sim) ou 2(não)");
        var resposta = int.Parse(Console.ReadLine());

    }
}
