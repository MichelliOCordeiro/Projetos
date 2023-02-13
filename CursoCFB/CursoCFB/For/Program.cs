using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula19
{
    static void Main()
    {
        //1º: contador, vai começar a fazer o loop a partir do numero informado
        //2º: até quando ele vai fazer a repetição?
        //3º: o incremento, faz um, depois soma outro, ate chegar na quantidade do 2º

        int[] num = new int[10];

        for (int i = 0; i < num.Length; i++)
        {
            num[i] = i;
            Console.WriteLine("Valor de num na posição {0}: {1}", i, num[i]);
        }
    }

}
