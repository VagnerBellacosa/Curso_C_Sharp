// Dividindo X por Y 

using System;

class Desafio {

    static void Main() {
        
        int limit = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            
            // Testa falta do Dividendo
            if ( line.Length > 1)  {

               double X = double.Parse(line[0]);
               double Y = double.Parse(line[1]);
            
               // Testa Numeros Validos para Dividendo Divisor
               if ( (Y <= 0.0  || Y >= 0.0  ) &&
                    (X <= 0.0  || X >= 0.0  ))  {
              
                // Testa Divisor
                if (Y == 0  )  {
                      Console.WriteLine("divisao impossivel");
                 } else {
                   double divisao = (double)X / Y; // Digite aqui o calculo da divisao
                   
                    if (divisao < 0 && divisao > -0.5)
	                    {
	                        Console.WriteLine("-0.0");
	                    }
                    else
                    {
                             Console.WriteLine(divisao.ToString("N1"));     
                    }    
                 }
                }
            }
            else {
                   Console.WriteLine("divisao impossivel");
             }            
            
        }
    }
}