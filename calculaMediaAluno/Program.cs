using System;

namespace calculaMediaAluno
{

class Desafio {
    static void Main() {
    //declare suas variaveis corretamente
    string Ax_Resposta = " " ;
    string Ax_Nota1 = " " ;
    string Ax_Nota2 = " " ;
    double Ct_Nota1 = 0;
    double Ct_Nota2 = 0;

      //continue a solução ou implemente da sua maneira

      while (  Ax_Resposta   != "2" ) {
                  
          string Ax_Nota = Console.ReadLine();
          double Ct_Nota = Convert.ToDouble(Ax_Nota);          

          if (Ct_Nota < 0 || Ct_Nota > 10)  {
            Console.WriteLine("nota invalida");            
            } 
          else if ( Ax_Nota1 == " " )  {
            Ct_Nota1 = Ct_Nota;
            Ax_Nota1 = Ct_Nota1.ToString("N2");
           }
           else if ( Ax_Nota2 == " "   ) {      
             Ct_Nota2 = Ct_Nota;                   
             Ax_Nota2 = Ct_Nota2.ToString("N2");
             double media = ( Ct_Nota1 + Ct_Nota2 ) / 2 ; 

   //         Console.WriteLine("Nota 1: " + Ct_Nota1.ToString("N2"));
   //         Console.WriteLine("Nota 2: " + Ct_Nota2.ToString("N2"));
            Console.Write("media = ");
            Console.WriteLine(media.ToString("N2"));
            Ax_Resposta = " ";
            
            while ( Ax_Resposta != "1" && Ax_Resposta != null ){
              
              Console.WriteLine("novo calculo (1-sim 2-nao)");
              Ax_Resposta = Console.ReadLine();	
             
              if ( Ax_Resposta == "1"      ) {                
                 Ax_Nota1 = " " ;
                 Ax_Nota2 = " " ;
              } else if ( Ax_Resposta == "2"  ) {
                 break ;
              }
            }
          } 
        }
    }
}
}
