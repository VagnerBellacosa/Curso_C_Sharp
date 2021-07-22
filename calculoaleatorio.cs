using System; 
class {
        public static void Main()         {
             
            double a, b , avg = 0;
            int i, postive = 0;

            for ( i = 0; i < 6; i++  )           {
               a = double.Parse(Console.ReadLine());
                
                if ( a > 0 )  {
                  b += a;
                  positive++;
                }
            }
            
            avg = b / postive;
            
            Console.WriteLine("{0} valores positivos", postive);
            Console.WriteLine("{0}", avg.ToString("0.0"));

            Console.ReadLine();
        }
}