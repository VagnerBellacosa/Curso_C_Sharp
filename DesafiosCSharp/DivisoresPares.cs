using System;

class DivisoresPares    {
	static void Main(string[] args)	{

		int n = int.Parse(Console.ReadLine());

        //complete o código com sua solução 

        for ( int x=1; x < 10000; x++    ){        
			if (  x % n == 2  ){                    
				Console.WriteLine(x);
              }
            }
        }
    }