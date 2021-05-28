using System; 

class URI {

    static void Main(string[] args) { 

            string n = Console.ReadLine();
            string Ax_Num ;
            
            //continue a solução
            
            Ax_Num = "";
            
            for (int j = n.Length; j >= 0; j--){ 
               Ax_Num = Ax_Num + n.IndexOf(j) ;
               Console.WriteLine(j);
            }
            
  //          string v = new string(arr);
            Console.WriteLine(Ax_Num);

    }

}