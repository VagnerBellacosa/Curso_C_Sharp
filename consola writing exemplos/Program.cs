using System;

namespace consola_writing_exemplos {
    class Program    {
// This code example demonstrates the Console.WriteLine() method.
// Formatting for this example uses the "en-US" culture.
    enum Color {Yellow = 1, Blue, Green};
    static DateTime thisDate = DateTime.Now;

    public static void Main()    {
        Console.Clear();

        // Format a negative integer or floating-point number in various ways.
        Console.WriteLine("Standard Numeric Format Specifiers");
        Console.WriteLine(
            "(C) Currency: . . . . . . . . {0:C}\n" +
            "(D) Decimal:. . . . . . . . . {0:D}\n" +
            "(E) Scientific: . . . . . . . {1:E}\n" +
            "(F) Fixed point:. . . . . . . {1:F}\n" +
            "(G) General:. . . . . . . . . {0:G}\n" +
            "    (default):. . . . . . . . {0} (default = 'G')\n" +
            "(N) Number: . . . . . . . . . {0:N}\n" +
            "(P) Percent:. . . . . . . . . {1:P}\n" +
            "(R) Round-trip: . . . . . . . {1:R}\n" +
            "(X) Hexadecimal:. . . . . . . {0:X}\n",
            -123, -123.45f);

        // Format the current date in various ways.
        Console.WriteLine("Standard DateTime Format Specifiers");
        Console.WriteLine(
            "(d) Short date: . . . . . . . {0:d}\n" +
            "(D) Long date:. . . . . . . . {0:D}\n" +
            "(t) Short time: . . . . . . . {0:t}\n" +
            "(T) Long time:. . . . . . . . {0:T}\n" +
            "(f) Full date/short time: . . {0:f}\n" +
            "(F) Full date/long time:. . . {0:F}\n" +
            "(g) General date/short time:. {0:g}\n" +
            "(G) General date/long time: . {0:G}\n" +
            "    (default):. . . . . . . . {0} (default = 'G')\n" +
            "(M) Month:. . . . . . . . . . {0:M}\n" +
            "(R) RFC1123:. . . . . . . . . {0:R}\n" +
            "(s) Sortable: . . . . . . . . {0:s}\n" +
            "(u) Universal sortable: . . . {0:u} (invariant)\n" +
            "(U) Universal full date/time: {0:U}\n" +
            "(Y) Year: . . . . . . . . . . {0:Y}\n",
            thisDate);

        // Format a Color enumeration value in various ways.
        Console.WriteLine("Standard Enumeration Format Specifiers");
        Console.WriteLine(
            "(G) General:. . . . . . . . . {0:G}\n" +
            "    (default):. . . . . . . . {0} (default = 'G')\n" +
            "(F) Flags:. . . . . . . . . . {0:F} (flags or integer)\n" +
            "(D) Decimal number: . . . . . {0:D}\n" +
            "(X) Hexadecimal:. . . . . . . {0:X}\n",
            Color.Green);

//  
string[] lines = { "This is the first line.",
                   "This is the second line." };
// Output the lines using the default newline sequence.
Console.WriteLine("With the default new line characters:");
Console.WriteLine();
foreach (string line in lines)
   Console.WriteLine(line);

Console.WriteLine();

// Redefine the newline characters to double space.
Console.Out.NewLine = "\r\n\r\n";
// Output the lines using the new newline sequence.
Console.WriteLine("With redefined new line characters:");
Console.WriteLine();
foreach (string line in lines)
   Console.WriteLine(line);

// The example displays the following output:
//       With the default new line characters:
//
//       This is the first line.
//       This is the second line.
//
//       With redefined new line characters:
//
//
//
//       This is the first line.
//
//       This is the second line.


    enum Color {Yellow = 1, Blue, Green};
    static DateTime thisDate = DateTime.Now;


        // Format a negative integer or floating-point number in various ways.
        Console.WriteLine("Standard Numeric Format Specifiers");
        Console.WriteLine(
            "(C) Currency: . . . . . . . . {0:C}\n" +
            "(D) Decimal:. . . . . . . . . {0:D}\n" +
            "(E) Scientific: . . . . . . . {1:E}\n" +
            "(F) Fixed point:. . . . . . . {1:F}\n" +
            "(G) General:. . . . . . . . . {0:G}\n" +
            "    (default):. . . . . . . . {0} (default = 'G')\n" +
            "(N) Number: . . . . . . . . . {0:N}\n" +
            "(P) Percent:. . . . . . . . . {1:P}\n" +
            "(R) Round-trip: . . . . . . . {1:R}\n" +
            "(X) Hexadecimal:. . . . . . . {0:X}\n",
            -123, -123.45f);

        // Format the current date in various ways.
        Console.WriteLine("Standard DateTime Format Specifiers");
        Console.WriteLine(
            "(d) Short date: . . . . . . . {0:d}\n" +
            "(D) Long date:. . . . . . . . {0:D}\n" +
            "(t) Short time: . . . . . . . {0:t}\n" +
            "(T) Long time:. . . . . . . . {0:T}\n" +
            "(f) Full date/short time: . . {0:f}\n" +
            "(F) Full date/long time:. . . {0:F}\n" +
            "(g) General date/short time:. {0:g}\n" +
            "(G) General date/long time: . {0:G}\n" +
            "    (default):. . . . . . . . {0} (default = 'G')\n" +
            "(M) Month:. . . . . . . . . . {0:M}\n" +
            "(R) RFC1123:. . . . . . . . . {0:R}\n" +
            "(s) Sortable: . . . . . . . . {0:s}\n" +
            "(u) Universal sortable: . . . {0:u} (invariant)\n" +
            "(U) Universal full date/time: {0:U}\n" +
            "(Y) Year: . . . . . . . . . . {0:Y}\n",
            thisDate);

        // Format a Color enumeration value in various ways.
        Console.WriteLine("Standard Enumeration Format Specifiers");
        Console.WriteLine(
            "(G) General:. . . . . . . . . {0:G}\n" +
            "    (default):. . . . . . . . {0} (default = 'G')\n" +
            "(F) Flags:. . . . . . . . . . {0:F} (flags or integer)\n" +
            "(D) Decimal number: . . . . . {0:D}\n" +
            "(X) Hexadecimal:. . . . . . . {0:X}\n",
            Color.Green);

Random rnd = new Random();
// Generate five random Boolean values.
for (int ctr = 1; ctr <= 5; ctr++) {
   Boolean bln = Convert.ToBoolean(rnd.Next(0, 2));
   Console.WriteLine("True or False: {0}", bln);
}

// The example displays an output similar to the following:
//       True or False: False
//       True or False: True
//       True or False: False
//       True or False: False
//       True or False: True

Console.WriteLine("Today's date: {0:D}", DateTime.Now);




    }
}
/*
This code example produces the following results:

Standard Numeric Format Specifiers
(C) Currency: . . . . . . . . ($123.00)
(D) Decimal:. . . . . . . . . -123
(E) Scientific: . . . . . . . -1.234500E+002
(F) Fixed point:. . . . . . . -123.45
(G) General:. . . . . . . . . -123
    (default):. . . . . . . . -123 (default = 'G')
(N) Number: . . . . . . . . . -123.00
(P) Percent:. . . . . . . . . -12,345.00 %
(R) Round-trip: . . . . . . . -123.45
(X) Hexadecimal:. . . . . . . FFFFFF85

Standard DateTime Format Specifiers
(d) Short date: . . . . . . . 6/26/2004
(D) Long date:. . . . . . . . Saturday, June 26, 2004
(t) Short time: . . . . . . . 8:11 PM
(T) Long time:. . . . . . . . 8:11:04 PM
(f) Full date/short time: . . Saturday, June 26, 2004 8:11 PM
(F) Full date/long time:. . . Saturday, June 26, 2004 8:11:04 PM
(g) General date/short time:. 6/26/2004 8:11 PM
(G) General date/long time: . 6/26/2004 8:11:04 PM
    (default):. . . . . . . . 6/26/2004 8:11:04 PM (default = 'G')
(M) Month:. . . . . . . . . . June 26
(R) RFC1123:. . . . . . . . . Sat, 26 Jun 2004 20:11:04 GMT
(s) Sortable: . . . . . . . . 2004-06-26T20:11:04
(u) Universal sortable: . . . 2004-06-26 20:11:04Z (invariant)
(U) Universal full date/time: Sunday, June 27, 2004 3:11:04 AM
(Y) Year: . . . . . . . . . . June, 2004

Standard Enumeration Format Specifiers
(G) General:. . . . . . . . . Green
    (default):. . . . . . . . Green (default = 'G')
(F) Flags:. . . . . . . . . . Green (flags or integer)
(D) Decimal number: . . . . . 3
(X) Hexadecimal:. . . . . . . 00000003

*/

    }