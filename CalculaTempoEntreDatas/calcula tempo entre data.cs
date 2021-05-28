using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTermino;

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
            int transformaSegundosInicio = 60 -  segundoMomentoInicio ;
            int transformaMinutoInicio = 60 -  minutoMomentoInicio ;
            int transformaHoraInicio = 24 -  horaMomentoInicio ;
            
            // segundo final
            int Ct_Segundos =  transformaSegundosInicio  + segundoMomentoTermino ;
            
            if (Ct_Segundos >= 60) {
               Ct_Segundos = Ct_Segundos - 60 ;
            }
    
            // minuto final
            int Ct_Minutos = transformaMinutoInicio  + minutoMomentoTermino ;

            if ((Ct_Minutos ) >= 60 ) {
                Ct_Minutos = Ct_Minutos - 60 ; 
            }
            
            // hora final
            int Ct_Horas =  transformaHoraInicio  + horaMomentoTermino;

            if (  Ct_Horas  >= 24)  {
               Ct_Horas = Ct_Horas - 24;
            }
            
            int w=0;
            
            for (int i = diaInicio ; diaInicio < diaTermino; i++)
            {
                w++;
            }

            Console.WriteLine("{0} dia(s)", w);
            Console.WriteLine("{0} hora(s)", Ct_Horas);
            Console.WriteLine("{0} minuto(s)", Ct_Minutos );
            Console.WriteLine("{0} segundo(s)", Ct_Segundos);            
    }

}