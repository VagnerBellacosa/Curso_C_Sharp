using System;

namespace PinkECerebro {

class minhaClasse {

    static void Main(string[] args) { 

       int  n = int.Parse(Console.ReadLine());

         //declare suas variaveis aqui   
        string[] line = Console.ReadLine().Split();
 
        int  Ct_mult2 = 0;
        int  Ct_mult3 = 0;
        int  Ct_mult4 = 0;
        int  Ct_mult5 = 0;
        double  Li = 0 ;

        // Limita o array, a leitura e os testes a 1000 de acordo com a especificaçao do usuario.
        if ( n > 1000){
           n = 1000;
        }

        // Limita o array, a leitura e os testes a 1 de acordo com a especificaçao do usuario.
        if ( n < 1){
           n = 0;
        }

        Array.Sort(line);  

//       Console.WriteLine("{0} qtd num", n    );
//       Console.WriteLine("{0} qtd occurs ", line.Length    );

        //continue a solução
        for ( int  x = 0 ; n > x ; x++  ) {

//       Console.WriteLine("{0} qtd occurs loop ", x    );

            // verifique se existem numeros  na linha do Pink
            if ( line.Length >= 1)  {
               Li = int.Parse(line[x])  ;        
            }
            else  {
                break ;
            }    

//          Console.WriteLine("{0} Numero", Li    );

            // verifica se o numero dado é maior ou igual a 1 e menor ou igual a 100
            if ( Li < 1 || Li > 100 ) {
                break ;
            }    
                    
            // verifica se o numero é divisivel por 2
            if ((Li % 2) == 0){ 
                Ct_mult2++;
            }        

            // verifica se o numero é divisivel por 3
            if ((Li % 3) == 0){ 
                Ct_mult3++;
            }        

            // verifica se o numero é divisivel por 4
            if ((Li % 4) == 0){ 
                Ct_mult4++;
            }        

            // verifica se o numero é divisivel por 5
            if ((Li % 5) == 0){ 
                Ct_mult5++;
            }                    

        }

        Console.WriteLine("{0} Multiplo(s) de 2", Ct_mult2    );
        Console.WriteLine("{0} Multiplo(s) de 3", Ct_mult3    );
        Console.WriteLine("{0} Multiplo(s) de 4", Ct_mult4    );
        Console.WriteLine("{0} Multiplo(s) de 5", Ct_mult5    );

    }
    }
}
