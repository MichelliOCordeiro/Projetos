using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

class Programa
{
    //Fazer um programa para ler o nome de um(a) funcionário(a), o valor que ele(a) 
    //recebe por hora, e a  quantidade de horas trabalhadas por ele(a). Ao final, mostrar o valor 
    //do pagamento do funcionário com uma mensagem explicativa, conforme exemplo.
    //Exemplo 1:
    //Nome: Joao Silva
    //Valor por hora: 50.00
    //Horas trabalhadas: 60
    //O pagamento para Joao Silva deve ser 3000.00

    static void Main(string[] args)
    {
        string nome = "";
        decimal valorHora = 0;
        int horasTrabalhadas = 0;
        decimal pagamento = 0;

        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Informe o valor da sua hora de trabalho: ");
        valorHora = decimal.Parse(Console.ReadLine().Replace(".", ","));

        Console.WriteLine("Digite a quantidade das horas trabalhadas: ");
        horasTrabalhadas = int.Parse(Console.ReadLine());

        pagamento = valorHora * horasTrabalhadas;

        Console.WriteLine($"O pagamento para {nome} deve ser de {pagamento.ToString("C2", CultureInfo.CurrentCulture)}");
    }

}

