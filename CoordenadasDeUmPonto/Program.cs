using System;
using System.Globalization;

namespace CoordenadasDeUmPonto {
    class Program {
        static void Main(string[] args)        {

            string[] line = Console.ReadLine().Split(" ");
            string Ax_Quadrante = " " ;
            double X = 0;
            double Y = 0;

            // Testa se variaveis sao validas
            if ( line[0] != null || line[1] != null   )  {

              if ( line.Length > 1)  {
//                 X = double.Parse(line[0]);
//                 Y = double.Parse(line[1]);
                  X = double.Parse(line[0], CultureInfo.InvariantCulture);
                  Y = double.Parse(line[1], CultureInfo.InvariantCulture);                 
              }
            
              // X > 0  and y > 0  Q1
              if ( X > 0 && Y > 0)  {
                  Ax_Quadrante = "Q1" ;   
              }
            
              // X > 0  and y < 0  Q4
              if ( X > 0 && Y < 0)  {
                  Ax_Quadrante = "Q4" ;   
              }

              // X > 0  and y < 0  Q4
              if ( X > 0 && Y == 0)  {
                  Ax_Quadrante = "Eixo X" ;   
              }
              if ( X < 0 && Y == 0)  {
                  Ax_Quadrante = "Eixo X" ;   
              }

              // X > 0  and y < 0  Q4
              if ( X == 0 && Y > 0)  {
                 Ax_Quadrante = "Eixo Y" ;   
              }
              if ( X == 0 && Y < 0)  {
                 Ax_Quadrante = "Eixo Y" ;   
              }

              // x = 0  and Y = 0  origem
              if ( X == 0 && Y == 0)  {
                  Ax_Quadrante = "Origem" ;   
              }

              // X < 0  and Y > 0  Q2
              if ( X < 0 && Y > 0)  {
                  Ax_Quadrante = "Q2" ;   
              }

              // X < 0  and Y < 0  Q3            
              if ( X < 0 && Y < 0)  {
                  Ax_Quadrante = "Q4" ;   
              }

              Console.WriteLine(Ax_Quadrante);

            }
        }
    }
}