using System;
using System.Globalization;

namespace idades {

    class Desafio    {
        static void Main(string[] args)  {
            int n = 1;
            //declare suas variaveis corretamente
            int Ct_Idade = 0;
            int Ct_Count = 0;

            while (   n >= 0   )  {
                n = int.Parse(Console.ReadLine());

                if ( n >= 0      )  {
                     Ct_Idade+= n;
                     Ct_Count++;
                }
            }

            double  Ct_IdadeMedia     =  (double)Ct_Idade    /   Ct_Count   ;
            
            Console.WriteLine( "sum   " + Ct_Idade.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine( "count " + Ct_Count.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine( Ct_IdadeMedia.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
