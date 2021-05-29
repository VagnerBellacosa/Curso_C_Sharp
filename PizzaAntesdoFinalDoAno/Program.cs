using System;

// A entrada contém vários casos de teste. A primeira linha de cada caso contém os inteiros
//  N e D (1 ≤ N, D ≤ 50), o número de pessoas e o número de datas consideradas, respectivamente.
// As pessoas são numeradas de 1 a N. As próximas D linhas descrevem uma data considerada. 
// Cada linha começa com a data na forma dia∕mes∕ano. A linha é seguida de N inteiros p1,p2,...,pN. 
//O inteiro pi é 1 se a pessoa i pode comparecer na data considerada, ou 0 caso contrário.
// É garantido que as datas são sempre válidas, e não há zeros à esquerda. 
//Além disso, as datas são dadas em ordem, do dia mais cedo para o dia mais tarde.

namespace PizzaAntesdoFinalDoAno {

//continue a solução
public class pizzaria {
  
  public static void Main(){
  
    string[] line = Console.ReadLine().Split(" ");
    int totalDePessoas = int.Parse(line[0]);
    int totalDeDatas = int.Parse(line[1]);     ;
    
    string dataConsiderada = " ";
    
    for (int i = 0; i < totalDeDatas; i++)    {

       int totalDePessoasQuePodemComparecer =  0  ;
      
       string[] entradaDataConfirmacao = Console.ReadLine().Split(" ");
                
       for (int j = 1 ; j <= entradaDataConfirmacao.Length - 1  ; j++)      {
          totalDePessoasQuePodemComparecer =  totalDePessoasQuePodemComparecer + 
                                            int.Parse(entradaDataConfirmacao[j]) ;
        }
      
//        Console.WriteLine( "Total " +  totalDePessoasQuePodemComparecer );

        if (totalDePessoasQuePodemComparecer ==  totalDePessoas  )       {
          dataConsiderada =  entradaDataConfirmacao[0] ;
          break ;
        }

      }

      if ( dataConsiderada != " "  )      {
        Console.WriteLine(dataConsiderada);
      } 
      else   {
        Console.WriteLine("Pizza antes de FdA");
      }
    
  }
}
}
