using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula18
{
    static void Main()
    {
        //3 é a  linha e 5 a coluna 
        int[,] n= new int[3, 5];
        /*
         10 20 30 40 50
         60 70 80 90 12
         25 35 45 55 65
        */
        // outra forma
        int[,] num = new int[2, 2] { { 10, 20 }, { 30, 40 } };

        n[0, 0] = 10; 
        n[0, 1] = 20; 
        n[0, 2] = 30; 
        n[0, 3] = 40; 
        n[0, 4] = 50;

        Console.WriteLine(n[0,0]);
        Console.WriteLine(num[0,0]);
    }
}
