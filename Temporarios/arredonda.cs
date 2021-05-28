using System;
using System.Diagnostics;

int  v1, v2, Ct_Media;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
class Classe {
    static void Main() {
        string[] line = Console.ReadLine().Split(" ");
                v1 = valores[0];
                v2 = valores[1];
                Ct_Media = v1 / v2 ; 

                Console.WriteLine( Ct_Media);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}