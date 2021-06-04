// Tempo de um Evento

using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTermino;
            int Ct_Horas = 0, Ct_Minutos = 0 , Ct_Segundos = 0 ;  

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split();

            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[4]);

            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split();
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino  = Convert.ToInt32(dadosMomentoTermino[2]);
            segundoMomentoTermino  = Convert.ToInt32(dadosMomentoTermino[4]);

            // hora inicio
            int transformaSegundosInicio = 60 - segundoMomentoInicio ;
            int transformaMinutoInicio = 60 - minutoMomentoInicio ;
            int transformaHoraInicio = 24 - horaMomentoInicio ;

            // acumula dias
          TimeSpan tsPeriodoIni = new TimeSpan(diaInicio, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio);

          TimeSpan tsPeriodoFini = new TimeSpan(diaTermino, horaMomentoTermino, minutoMomentoTermino, segundoMomentoTermino);

          TimeSpan intervalo = tsPeriodoFini -  tsPeriodoIni ;
   
          Console.WriteLine("{0} dia(s)",  intervalo.Days);
          Console.WriteLine("{0} hora(s)", intervalo.Hours);
            
          if (intervalo.Days == 0 && intervalo.Hours == 0 &&   intervalo.Minutes == 0){
              Console.WriteLine("{0} minuto(s)", 1);
              Console.WriteLine("{0} segundo(s)", 0);                        
            }
          else   {
             Console.WriteLine("{0} minuto(s)", intervalo.Minutes);
             Console.WriteLine("{0} segundo(s)", intervalo.Seconds);                        
          }
    }
}