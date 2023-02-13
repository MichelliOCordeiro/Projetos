using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula20
{
    static void Main()
    {
        int[] num = new int[5]{ 11,22,33,44,55};

        //for (int i = 0; i < num.Length; i++)
        //{
        //    Console.WriteLine(num[i]);
        //}

        //foreach é para leitura de coleções, não serve para atribuir valor ao elemento
        //ex: n=10; isso nao faz
        //sintaxe: nome para o elemento que ele ira ler na coleção (var item) +
        //o nome da lista//array que será consultado
        foreach (var item in num)
        {
            Console.WriteLine(item);
        }

    }

}
