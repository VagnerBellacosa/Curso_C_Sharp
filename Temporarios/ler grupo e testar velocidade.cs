using System;

class Program {

  static void Main(string[] args) { 

    var CodTartaruga = int.Parse(Console.ReadLine());

    while (true) ;
    
        string[] Velocidade = Console.ReadLine().Split();

        int Resultado = 0 ;

        for ( int i = 0; i < Velocidade.Length ; i++) {
    
           int Ac_Velocidade = int.Parse(Velocidade[i]);            
 
           if (Ac_Velocidade >= 20)   {
              Resultado = 3 ; 
              break;
           } 
           else { 
             if (Ac_Velocidade > 10)   {
               Resultado = 2 ; 
             } 
             else {
               Resultado = 1 ; 
             }
           }   
          }

          Console.WriteLine( Resultado);
  
          CodTartaruga = int.Parse(Console.ReadLine());  
       
//       if ( CodTartaruga == null || CodTartaruga.Count() == 0 ) {
          if ( CodTartaruga  == 0 ) {
            Break ;
           }
        }
   }
}
