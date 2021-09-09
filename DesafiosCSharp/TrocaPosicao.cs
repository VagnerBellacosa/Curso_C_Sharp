using System;
using System.Collections.Generic;
using System.Linq;
using static System.Boolean;

class TrocaPosicao {
  public static void Main (string[] args) {
    //complete o código com sua solução
    int[] vetor = new int[21];
    IEnumerable<int> sequencia = Enumerable.Range(1,20);
    IEnumerable<int> sequencia2 = Enumerable.Range(1,20)  ;
	
	foreach (int c in sequencia)    {
		vetor[c-1] = int.Parse(Console.ReadLine()); 
		}
		
   foreach (int j in sequencia2)    {
	   Console.WriteLine( "N[" + ( j - 1 ) + "] = " + vetor[ 20 - j] );
    }
  }
}
