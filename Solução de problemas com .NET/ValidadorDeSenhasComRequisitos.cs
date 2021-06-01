// Validador de senhas com requisitos

using System;

namespace ValidadorDeSenhasComRequisitos
{

class ValidarSenha {

    static void Main(string[] args) { 

    bool Fl_Eof  = true;        
 
    // primeira leitura 
    string Password = Console.ReadLine();

    while (Fl_Eof) { 
      
        bool Sem_Erro  = true;
        bool Fl_Char = false;
        bool Fl_CapsLockOn = false;
        bool Fl_CapsLockOff = false;
        bool Fl_Number  = false;
        bool Fl_SpecialChar  = false;        
        bool Fl_SpaceOk = true;

        //a senha deve ter tamanho minimo de 6
        if ( Password.Length < 6 ){ 
          Sem_Erro  = false ;
        }    

        //a senha deve ter tamanho maximo  de 32
        if ( Password.Length > 32 ){ 
          Sem_Erro  = false ;
        }    

        //Verifica alfabeto
          foreach (char c in Password)  //counts number of uppercase letters
          {
              if (Char.IsUpper(c))  {
                  Fl_Char = true;          
                 }            
          }        
        
        //Verifica um número;
        string specialNumbers = @"0123456789";
        foreach (var item in specialNumbers)
        {
            if (Password.Contains(item)){
              Fl_Number  = true;
            }    
        }

        //Verifica uma letra maiuscula
        string LettersUp = @"ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        foreach (var item in LettersUp)
        {
            if (Password.Contains(item)){
              Fl_CapsLockOn = true;
            }    
        }

        //Verifica uma letra minuscula
        string LettersDown = @"abcdefghijklmnopqrstuvwxyz";
        foreach (var item in LettersDown)
        {
            if (Password.Contains(item)){
              Fl_CapsLockOff = true;
            }    
        } 

        //Verifica Space
        string LetterSpace = " ";
        foreach (var item in LetterSpace)
        {
            if (Password.Contains(item)){
              Fl_SpaceOk = false;
            }    
        } 

        // A mesma não pode ter nenhum caractere de pontuação, acentuação ou espaço;
        string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
        foreach (var item in specialChar)
        {
            if (Password.Contains(item)){
              Fl_SpecialChar = true;
              Sem_Erro  = false ;
            }    
        }

       //*   '\n' or '0x0A' (10 in decimal) -> This character is called "Line Feed" (LF).
       //*   '\r' or '0x0D' (13 in decimal) -> This one is called "Carriage return" (CR).
       if (Password.Contains((char)13)) { 
           Fl_Eof = false ; 
        }

       // Valida a senha e informa operador       
       if ( Sem_Erro &&  Fl_Char  &&  Fl_CapsLockOn  &&  Fl_CapsLockOff && 
             Fl_Number && Fl_SpaceOk ) { 
          Console.WriteLine("Senha valida.");
       } else { 
          Console.WriteLine("Senha invalida.");
       }

      
      // obtem a proxima senha até o final de arquivo
       Password = Console.ReadLine();

       // linha nula
       if ( Password == null ) { 
           Fl_Eof = false ; 
           break ;
        }
       else  {
          //*   '\n' or '0x0A' (10 in decimal) -> This character is called "Line Feed" (LF).
          //*   '\r' or '0x0D' (13 in decimal) -> This one is called "Carriage return" (CR).
         if (Password.Contains((char)13)) { 
           Console.WriteLine(" 13 ");
            Fl_Eof = false ; 
          }
        
          if (Password.Contains((char)10)) { 
            Fl_Eof = false ; 
          }
        }
    }
  }
}
}