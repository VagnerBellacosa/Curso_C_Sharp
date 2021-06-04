// Crescimento Populacional

using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb, CrescimentoA, CrescimentoB, Populacao;
            int anos;

            for (int i = 0; i < t; i++)            {
                
                anos = 0;
                
                string[] valores = Console.ReadLine().Split();
                
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

               //declare as variaveis corretamente
                cpa =  double.Parse(valores[2]);
                cpb =  double.Parse(valores[3]);

                CrescimentoA =  (1 + (cpa/100));
                CrescimentoB =  (1 + (cpb/100));                
                
                while (pa <= pb)                {

                   //complete o while
                   anos++;
                   
                   Populacao = (double)pa * CrescimentoA;
                   pa=(int)Populacao;
                   

                   Populacao = (double)pb * CrescimentoB;
                   pb = (int)Populacao;

                    if (anos > 100)                    {
                         Console.WriteLine("Mais de 1 seculo.");
                       break;                
                    }
                }

                if (anos <= 100)                {
                   Console.WriteLine( anos + " anos.");                      
                }
            }
    }
}