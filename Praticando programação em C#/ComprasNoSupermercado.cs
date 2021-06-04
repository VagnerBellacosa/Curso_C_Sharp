// Compras no Supermercado

using System;

    class MinhaClasse {
        
      public static void Main (string[] args) {

        var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
        int y = 0 ;
        string[] ListaCompraOrdenada = new string[1000] ;
        
        // Limita a 100 listas de compra
        if ( totalDeCasosDeTeste > 100){ 
          totalDeCasosDeTeste = 100;
        }

        // Ler todas as listas        
        for (int j = 1; j <= totalDeCasosDeTeste ; j++){ 
                     
           string[] ListaCompra = Console.ReadLine().Split();
           
           Array.Sort(ListaCompra);         
           y = 0;

           // Ler todos os itens da lista original
           for (int x = 0; x < ListaCompra.Length-1 ; x++){              
               // verifica existencia e inclui itens novos
               if (ListaCompra[x] != ListaCompra[x+1] ){ 
                  ListaCompraOrdenada[y]  = ListaCompra[x];
                  y++;
               }              
            }
            
            // obtem o ultimo item da lista original 
             if (ListaCompraOrdenada[y-1] != ListaCompra[ListaCompra.Length-1] ) {
               ListaCompraOrdenada[y]  = ListaCompra[ListaCompra.Length-1];
             }            

            // Lista compras ordenadas e sem repetiçao            
            for (int index = 0; index < ListaCompraOrdenada.Length; index++)  {
                if (ListaCompraOrdenada[index] != null) {
                  Console.Write(ListaCompraOrdenada[index]);
                  Console.Write(" ");
                }
              }
              Console.Write("\n");

            // Limpa array    
            Array.Clear(ListaCompraOrdenada, 0, ListaCompraOrdenada.Length) ;         
       }              
    }  
  }
  