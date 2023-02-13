using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula20
{
    static void Main()
    {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2, 5]{{11, 22, 00, 44, 55 },{ 66, 77, 88, 99, 00 }};

        //o random gera numeros aleatorios
        //na linha 21, ele esta chamando a classe random, gerando um novo numero
        //e colocando esse numero como proximo, respeitando o maximo de 50
        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = random.Next(50);
        }

        Console.WriteLine("Elementos do vetor1");
        foreach (var item in vetor1)
        {
            Console.WriteLine(item);
        }

        //public static int BinarySearch(array, valor);
        //este metodo retorna a posição do elemento procurado, caso nao esteja no array
        //retorna -1
        Console.WriteLine("BinarySearch");
        int procurado = 5;
        int pos = Array.BinarySearch(vetor1, procurado);
        Console.WriteLine("Valor {0} está na posição {1}", procurado, pos);
        Console.WriteLine("-------------------------------------------");

        //public static void Copy(Ar_origem,Ar_destino,qtde_elementos);
        //faz a copia dos elementos de um array para outro
        //sintaxe dos parametros: qual o vetor que quero passar p outro(origem),
        //vetor que ira receber os dados(destino), e a qtde que qro passar
        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }

        //public void CopyTo(Ar_destino,a_partir_desta_pos);
        //todos os elementos do vetor1 serão passados ao vetor3
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0);
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");

        //public longe GetLongLenght(dimensão);
        //vai retornar a qtde de elementos do array
        Console.WriteLine("GetLongLenght");
        long qtdeElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
        Console.WriteLine("-------------------------------------------");

        //public int GetLowerBound(dimensão);
        //vai retornar o menor indice do array        
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        //quando é matriz colocar qual dimensão deseja saber: 1(1° dimensao) e 0(2°dimensao)
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor Índice do vetor1 {0}", MenorIndiceVetor);
        Console.WriteLine("-------------------------------------------");

        //public int GetUpperBound
        //retorna o maior indice do array
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(0);
        Console.WriteLine("Maior índice do vetor1 {0}", MaiorIndiceMatriz_D1);
        Console.WriteLine("-------------------------------------------");

        //public object GetValue(long índice);
        //vai retornar um valor a partr de um indice, se quiser um numeral fazer um cast
        Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1, 3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor1);
        Console.WriteLine("-------------------------------------------");

        //public static int IndexOf(array,valor);
        //vai retorna o indice do valor que eu indicar, se tiver 3 numeros 3, vai retornar o
        //primeiro com esse resultado
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vetor1, 6);
        Console.WriteLine("Indice do primeiro valor 3:{0}", indice1);
        Console.WriteLine("-------------------------------------------");

        //public static int IndexOf(array,valor);
        //vai retorna o indice do valor que eu indicar, se tiver 3 numeros 3, vai retornar o
        //ultimo com esse resultado
        //public static int LastIndexOf(array,valor):
        Console.WriteLine("LastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("Indice do último valor 33:{0}", indice2);
        Console.WriteLine("-------------------------------------------");

        //public static void Reverse(array);
        //inverte a ordem dos elementos, faz o contrario
        Array.Reverse(vetor1);
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }

        //public void SetValue(object valor, long pos);
        //setar um valor em uma posição no vetor, no for ele vai inserir 0 em todas as posições
        vetor2.SetValue(99, 0);
        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0, i);
        }
        Console.WriteLine("Vetor 2");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }

        //public static void Sort(array);
        //ordenar a posição crescente. Se quiser decrescente, colocar o reverse no final
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Array.Reverse(vetor1);
        Console.WriteLine("Vetor1");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor2");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor3");
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }
    }

}
