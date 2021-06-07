// Desafios Aritméticos Intermediários em C#
// Tipos de Triângulos

using System; 

class Desafio {

// Um triângulo é um polígono que possui três lados e que necessariamente é uma figura plana cujos lados são segmentos de reta.
// Para ser polígono, esses segmentos de reta encontram-se apenas em suas extremidades, formando, assim, três vértices. 
// Além disso, também são encontrados três ângulos internos em qualquer que seja o triângulo.

        public static void Main()        {
            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);

            Array.Sort(s);

            double a2 = double.Parse(s[2]);
            double b2 = double.Parse(s[1]);
            double c2 = double.Parse(s[0]);

// a2 = hipotenusa
// b2 e c2 = cateto
            double hipotenusa = Math.Pow(a2, 2);
            double cateto1 = Math.Pow(b2, 2);
            double cateto2 = Math.Pow(c2, 2);

// Nao forma triangulo
// | b - c | < a < b + c
// | a - c | < b < a + c
// | a - b | < c < a + b

            if (  a >= b + c )
                Console.WriteLine("NAO FORMA TRIANGULO");

// O triângulo pode ser classificado segundo seus ângulos internos.
// Triângulo retângulo: tem um ângulo que mede 90º
// Triângulo Obtusângulo: tem um ângulo maior que 90°.
// Triângulo Acutângulo: Tem todos os ângulos menores que 90°.

            else if ( hipotenusa == cateto1 + cateto2 )
                Console.WriteLine("TRIANGULO RETANGULO");
            else if ( hipotenusa > cateto1 + cateto2 )
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if ( hipotenusa < cateto1 + cateto2  )
                Console.WriteLine("TRIANGULO ACUTANGULO");

//  Triangulos podem ser classificados segundo a medida do seu lado.
//  Triângulo escaleno: Todos os lados e ângulos são diferentes.
//  Triângulos isósceles: dois lados iguais e os ângulos opostos a esses lados iguais.
//  Triângulo equilátero: Todos os lados e ângulos iguais. Concluímos que seus ângulos serão de 60°.

//            if ( hipotenusa != cateto1 + cateto2 )    { 
//              if (  a2 == b2 && b2 == c2   )
                if (  a == b && b == c  )
                  Console.WriteLine("TRIANGULO EQUILATERO");
//              else if (( a2 == b2 && b2 != c2 ) ||
//                       ( a2 != b2 && b2 != c2))  
              else if ( (( a == b ) && ( a != c )) ||
                        (( b == c ) && ( b != a))  ||
                        ((c == a ) && (c!= b)) )
//                    if ( hipotenusa > cateto1 + cateto2 )
                      Console.WriteLine("TRIANGULO ISOSCELES");
                      
//              else if ( a2 != b2 && b2 != c2 && a2 != c2 )
//                  Console.WriteLine("TRIANGULO ESCALENO");
//            }
              Console.ReadLine();              
        }
}

  