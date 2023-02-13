using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula10
{
        enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabádo};

        static void Main()
        {
            //ira imprimir sabado
            DiasSemana ds = DiasSemana.Sabádo;
            Console.WriteLine(ds);

            //vai pegar pelo indice
            DiasSemana ds2 = (DiasSemana)3;
            Console.WriteLine(ds2);

            //pega o numero do indice do dia
            int ds3 = (int)DiasSemana.Domingo;
            Console.WriteLine(ds3);
        }

}
