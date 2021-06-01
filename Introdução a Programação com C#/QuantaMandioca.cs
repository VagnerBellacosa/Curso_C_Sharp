// Quanta Mandioca

using System;

class Desafio {
 
    static void Main() {
        
         double chico, bento, bernardo, marina, iara, marlene, total ;
        
         chico = 300 * Int32.Parse(Console.ReadLine());
         bento = 1500 * Int32.Parse(Console.ReadLine());
         bernardo = 600 * Int32.Parse(Console.ReadLine());
         marina = 1000 * Int32.Parse(Console.ReadLine());
         iara = 150 * Int32.Parse(Console.ReadLine());
         marlene = 225;
        
        // Digite aqui o calculo total
        total = chico + bento + bernardo + marina + iara + marlene ; 
        
        Console.WriteLine(total);
    }
}