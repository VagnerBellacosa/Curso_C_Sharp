using System;

namespace UltrapassandoV
{


class MainClass {

  public static void Main () {

    var R = int32.Parse(Console.ReadLine());
    var V = 0;
    var b = 0;
    var c = 0;
    var d = 0;

    do { 
 
      V = int.Parse(Console.ReadLine());
//      Console.WriteLine(" V " + V );

    } while ( R >= V  );

      b = R;
      d = R;
//      c++;
//      Console.WriteLine(" b " + b );
      
    for ( int x = b ; x <= V ; x++    ) {
           
//      Console.WriteLine(" c " + c );     
//      Console.WriteLine(" x " + x );    
//      Console.WriteLine(" R " + R );
      
      if ( d > V ) {
        break ;          
        }
      else {
        c++;
        d = d + x ;  
      }

    }
    Console.WriteLine(c);
    
  }
}
}
