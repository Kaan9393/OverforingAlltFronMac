using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod_CodeAlong
{
    static class ExtensionMethods       //Extension method can only exist in a static class.
    {
        static public bool IsOdd(this int i) //En vanlig statisk method
        {   
            //För att göra till Extension method lägger man till "this"
            return i % 2 == 1;
        }

        //---------------------------------------------------------------------

        static public int ToInt(this string s)
        {
            int.TryParse(s, out int i);     //Returnerar true eller false.
            return i;       //Gick det dåligt så får vi 0, går det bra får vi tillbaka det riktiga heltalet.
        
        }
    }
}
