using System;

namespace AreaDoCirculo
{
class Classe {

    static void Main(string[] args)
    {

        double pi = 3.14159, r;

        r = Convert.ToDouble(Console.ReadLine());

      //insira o calculo da area de acordo com o solicitado

        Console.WriteLine("A=" + (  r  * r *  pi   ).ToString("0.0000"));
    }

}
}
