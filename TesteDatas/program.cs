using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTermino;
            int Ct_Horas = 0, Ct_Minutos = 0 , Ct_Segundos = 0 ;  

//            string[] dadosInicio = Console.ReadLine().Split();


//*************************************************************************
   //        string[] dadosInicio = { "DIA", "05" };
   //         string[] dadosMomentoInicio = {"08", ":", "12", ":", "25" };
   //         string[] dadosTermino = {"dia", "09"};
   //         string[] dadosMomentoTermino = {"06", ":", "13", ":", "25" };
//* 3 22 1 0
  //          string[] dadosInicio = { "DIA", "05" };
  //          string[] dadosMomentoInicio = {"08", ":", "10", ":", "11" };
  //          string[] dadosTermino = {"dia", "06"};
  //          string[] dadosMomentoTermino = {"08", ":", "09", ":", "11" };
//* 0 23 59 0 
  //          string[] dadosInicio = { "DIA", "12" };
  //          string[] dadosMomentoInicio = {"07", ":", "30", ":", "00" };
  //          string[] dadosTermino = {"dia", "12"};
  //          string[] dadosMomentoTermino = {"19", ":", "30", ":", "00" };
//* 0 12 0 0 
   //         string[] dadosInicio = { "DIA", "11" };
   //         string[] dadosMomentoInicio = {"07", ":", "57", ":", "09" };
   //         string[] dadosTermino = {"dia", "15"};
   //          string[] dadosMomentoTermino = {"19", ":", "00", ":", "00" };
//* 4 11 2 51
            string[] dadosInicio = { "DIA", "01" };
            string[] dadosMomentoInicio = {"08", ":", "00", ":", "00" };
            string[] dadosTermino = {"dia", "01"};
            string[] dadosMomentoTermino = {"08", ":", "00", ":", "00" };
//* 0 0 1 0
 //         string[] dadosInicio = { "DIA", "01" };
 //           string[] dadosMomentoInicio = {"08", ":", "00", ":", "00" };
 //           string[] dadosTermino = {"dia", "02"};
 //          string[] dadosMomentoTermino = {"08", ":", "00", ":", "01" };
//* 1 0 1 0
//            string[] dadosInicio = { "DIA", "01" };
//            string[] dadosMomentoInicio = {"08", ":", "00", ":", "00" };
//            string[] dadosTermino = {"dia", "02"};
//            string[] dadosMomentoTermino = {"08", ":", "00", ":", "59" };
//* 1 0 0 59
//            string[] dadosInicio = { "DIA", "01" };
//            string[] dadosMomentoInicio = {"08", ":", "00", ":", "00" };
//            string[] dadosTermino = {"dia", "01"};
//            string[] dadosMomentoTermino = {"08", ":", "00", ":", "59" };
//* 1 0 0 59
   //         string[] dadosInicio = { "DIA", "01" };
   //         string[] dadosMomentoInicio = {"08", ":", "00", ":", "00" };
   //         string[] dadosTermino = {"dia", "01"};
   //         string[] dadosMomentoTermino = {"08", ":", "30", ":", "00" };
//* 0 0 30 0
  //          string[] dadosInicio = { "DIA", "01" };
  //          string[] dadosMomentoInicio = {"08", ":", "00", ":", "00" };
  //          string[] dadosTermino = {"dia", "01"};
  //          string[] dadosMomentoTermino = {"12", ":", "00", ":", "00" };
//* 0 4 0 0
  //         string[] dadosInicio = { "DIA", "01" };
  //          string[] dadosMomentoInicio = {"08", ":", "00", ":", "00" };
  //          string[] dadosTermino = {"dia", "02"};
  //          string[] dadosMomentoTermino = {"08", ":", "00", ":", "00" };
//* 1 0 0 0 
    //        string[] dadosInicio = { "DIA", "01" };
    //        string[] dadosMomentoInicio = {"08", ":", "00", ":", "00" };
    //       string[] dadosTermino = {"dia", "03"};
    //        string[] dadosMomentoTermino = {"08", ":", "00", ":", "00" };
//* 2 0 0 0 
    //        string[] dadosInicio = { "DIA", "01" };
    //        string[] dadosMomentoInicio = {"08", ":", "00", ":", "00" };
    //        string[] dadosTermino = {"dia", "02"};
    //        string[] dadosMomentoTermino = {"08", ":", "01", ":", "00" };
//* 1 0 1 0
//        string[] dadosInicio = { "DIA", "05" };
//            string[] dadosMomentoInicio = {"08", ":", "12", ":", "23" };
//            string[] dadosTermino = {"dia", "10"};
//            string[] dadosMomentoTermino = {"06", ":", "13", ":", "23" };
//* 4 22 1 0
   //         string[] dadosInicio = { "DIA", "1" };
   //         string[] dadosMomentoInicio = {"08", ":", "12", ":", "23" };
   //         string[] dadosTermino = {"dia", "31"};
   //         string[] dadosMomentoTermino = {"06", ":", "13", ":", "23" };
//* 29 22 1 0
 //           string[] dadosInicio = { "DIA", "1" };
 //           string[] dadosMomentoInicio = {"00", ":", "00", ":", "00" };
 //           string[] dadosTermino = {"dia", "31"};
 //           string[] dadosMomentoTermino = {"23", ":", "59", ":", "59" };
//* 30 23 59 59 
    //        string[] dadosInicio = { "DIA", "1" };
    //        string[] dadosMomentoInicio = {"00", ":", "00", ":", "00" };
    //        string[] dadosTermino = {"dia", "31"};
    //        string[] dadosMomentoTermino = {"23", ":", "59", ":", "00" };
//* 30 23 59 00 
  //          string[] dadosInicio = { "DIA", "1" };
  //          string[] dadosMomentoInicio = {"00", ":", "00", ":", "00" };
  //          string[] dadosTermino = {"dia", "31"};
  //          string[] dadosMomentoTermino = {"23", ":", "00", ":", "00" };
//* 30 23 59 00


            diaInicio = Convert.ToInt32(dadosInicio[1]);

            //string[] dadosMomentoInicio = Console.ReadLine().Split();
  
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[4]);

//            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

//            string[] dadosMomentoTermino = Console.ReadLine().Split();
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino  = Convert.ToInt32(dadosMomentoTermino[2]);
            segundoMomentoTermino  = Convert.ToInt32(dadosMomentoTermino[4]);

            // hora inicio
            int transformaSegundosInicio = 60 - segundoMomentoInicio ;
            int transformaMinutoInicio = 60 - minutoMomentoInicio ;
            int transformaHoraInicio = 24 - horaMomentoInicio ;
            
            // acumula dias
            int W = 0;
            
            for (int i = diaInicio ;  diaTermino > i  ; i++)
              {
                 W++;
              }

            // Acumula segundos
            Ct_Segundos =  transformaSegundosInicio  + segundoMomentoTermino ;
            // Acumula minutos
            Ct_Minutos = transformaMinutoInicio  + minutoMomentoTermino ;
                        
            // Calcula diferença segundos
            if (Ct_Segundos > 59) {
               Ct_Segundos = Ct_Segundos - 60 ;
            }   
            else  {
                  if (Ct_Segundos == 0) {
                    Ct_Minutos++ ;
                  }

            }
            
            // Calcula diferença minutos
            if (Ct_Minutos  > 59 ) {
                Ct_Minutos = Ct_Minutos - 60 ; 
            }            
            
            if ( segundoMomentoInicio > segundoMomentoTermino  ) {
              Ct_Minutos-- ;
            }

            // Acumula Dias
            if ( W == 0) {
              Ct_Horas =   horaMomentoTermino - horaMomentoInicio  ;
            }
            else {
                Ct_Horas = transformaHoraInicio  + horaMomentoTermino  ;
                if (  horaMomentoInicio  >= horaMomentoTermino ){
                  W--;
                  }
            }

            // Ajuste de horas
            if ( Ct_Horas > 24 ) {
               Ct_Horas = Ct_Horas - 24 ;
            }
            else {            
              if ( Ct_Horas == 24 ) {
                  if (horaMomentoInicio  ==   horaMomentoTermino  &&
                      minutoMomentoInicio > minutoMomentoTermino) {
                     Ct_Horas--;
                    }   
                  else  {  
                         if (horaMomentoInicio  ==   horaMomentoTermino  &&
                           segundoMomentoInicio > segundoMomentoTermino) {
                           Ct_Horas--;
                        }  
                       else {  
                              Ct_Horas = 0 ;
                              W++;                                                  
                       }
                 } 
              }                  
            } 

            if ( minutoMomentoInicio > minutoMomentoTermino  && horaMomentoInicio  >   horaMomentoTermino ) {
              Ct_Horas-- ;
            }
            else {
               if ( minutoMomentoInicio > minutoMomentoTermino  && horaMomentoInicio  <   horaMomentoTermino ) {
                 Ct_Horas-- ;
               }
            }

TimeSpan tsPeriodoIni = new TimeSpan(diaInicio, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio);

TimeSpan tsPeriodoFini = new TimeSpan(diaTermino, horaMomentoTermino, minutoMomentoTermino, segundoMomentoTermino);

TimeSpan intervalo = tsPeriodoFini -  tsPeriodoIni ;

            Console.WriteLine("{0} hora(s)", intervalo.Hours);
            Console.WriteLine("{0} minuto(s)", intervalo.Minutes);

            if ( W == 0 && Ct_Horas == 0 && Ct_Minutos == 00) {
              Ct_Minutos = 1;
              Ct_Segundos = 0 ;
            }
            
            Console.WriteLine("Dia Ini :" + diaInicio);
            Console.WriteLine("Hora Ini : " + horaMomentoInicio +  ":"  +  minutoMomentoInicio  + ":" + segundoMomentoInicio );
            Console.WriteLine("Dia Fini : " + diaTermino);
            Console.WriteLine("Hora Fini : "  +   horaMomentoTermino  + ":" + minutoMomentoTermino  +  ":" +  segundoMomentoTermino  );
            Console.WriteLine("*------------------------------------------------:");
            Console.WriteLine("{0} dia(s)", W);
            Console.WriteLine("{0} hora(s)", Ct_Horas);
            Console.WriteLine("{0} minuto(s)", Ct_Minutos );
            Console.WriteLine("{0} segundo(s)", Ct_Segundos);            
            Console.WriteLine("*------------------------------------------------:");
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