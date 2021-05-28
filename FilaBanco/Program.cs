using System;

namespace FilaBanco {
    
    class Program {
      
      public static void Main (string[] args) {

        var totalTestesClientes = int.Parse(Console.ReadLine());
        
        // Limita a 1000
        if ( totalTestesClientes > 1000 ){ 
          totalTestesClientes = 1000;
        }
    
        // Ler todas Casos de Testes Clientes
        if (totalTestesClientes >= 1)   {      

           for (int y = 1; y <= totalTestesClientes ; y++){ 
               
             var Ct_TotalClientes = int.Parse(Console.ReadLine());
             
             int Ct_Reorg = 0 ;

             // Limita a 1000
              if ( Ct_TotalClientes > 1000){ 
                  Ct_TotalClientes = 1000;
              }

             // obtem a ordem original dos clientes
              string[] ClientesIN = Console.ReadLine().Split();
              // int tamanho = 
              int[] ClientesChegando =  new int[Ct_TotalClientes];              
              int[] ClientesChegandoOrdenando =  new int[Ct_TotalClientes];              

//              Array.Copy(ClientesChegando, ClientesChegandoOrdenando , ClientesChegando.Length);
              
              for (int z = 0 ; z < Ct_TotalClientes ; z++){ 
                ClientesChegando[z] = Int32.Parse(ClientesIN[z]);
                ClientesChegandoOrdenando[z] = Int32.Parse(ClientesIN[z]);
              }  

              Array.Sort(ClientesChegandoOrdenando);
              int x=0;

              // acumula diferenças na fila reorganizada
              for (int z = Ct_TotalClientes - 1 ; z >= 0 ; z--){                 
                  if (ClientesChegandoOrdenando[z] == ClientesChegando[x]){ 
                      Ct_Reorg++ ;                      
                 }
                 x++;
               }

               Console.WriteLine( Ct_Reorg) ;
           }
        }
    }
}
}