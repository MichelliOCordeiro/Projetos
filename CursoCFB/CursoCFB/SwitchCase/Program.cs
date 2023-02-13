using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula15
{ 
    static void Main()
    {    
        string nome = "";
        char escolha;

        inicio: Console.Clear();

        Console.WriteLine("Escolha a espécie desejada: (a)Cachorro, (b)Gato ou (c)Peixe");
        escolha = char.Parse(Console.ReadLine().ToUpper());
        //nome dessa conversao é type cast

        //essa é a variavel que vai ser analisada: escolha, que vai pegar a opção digitada
        switch (escolha)
        {
            case 'A':
                nome = "Chocolate";
                Console.WriteLine($"O nome do seu novo animal será {nome}");
                break;
            case 'B':
                nome = "Bob";
                Console.WriteLine($"O nome do seu novo animal será {nome}");
                break;
            case 'C':
                nome = "Nemo";
                Console.WriteLine($"O nome do seu novo animal será {nome}");
                break;
            default:
                Console.WriteLine("Nome não encontrado");
                break;
        }

        Console.WriteLine("Deseja fazer uma nova consulta?(s)-Sim(n)-Não");
        escolha = char.Parse(Console.ReadLine().ToUpper());
        switch (escolha)
        {
            case 'S':
                goto inicio;
                break;
            case 'N':
                Console.Clear();
                Console.WriteLine("Fim do programa");;
                break;
        }

    }
}
