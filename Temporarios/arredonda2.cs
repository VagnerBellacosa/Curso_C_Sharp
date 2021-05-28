using System;

class Classe {

    static void Main() {
      
        string[] line = Console.ReadLine().Split(" ");
        
        
            int v1 = Int32.Parse(line[0]);
            int v2 = Int32.Parse(line[1]);
            int v3 = 0;

            
            double Ct_Media =   ((double)v1 / v2) ;

            
            Console.WriteLine(Ct_Media.ToString("F"));

}
}
