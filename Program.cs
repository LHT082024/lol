using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace lol;

class Program
{
    static void Main(string[] args)
    {

        //en arrayList er en type liste som hvor man kan printe ut forskjellige type variabler.
        //som med de fleste lister så må man bruke en loop for å printe den ut.
        ArrayList phantom = new ArrayList();
        phantom.Add("phantom");
        phantom.Add(1);
        phantom.Add(2.2);

        for (int i = 0; i < phantom.Count; i++)
        {
            Console.WriteLine(phantom[i]);
        }

        //difference between a list and an arraylist is in a list you need to define its variable type 
        //while arraylist you need to define the type first and can only lists objects
        //of that type.
        List<int> numbers = new List<int>
        {
            489,
            563,
            629,
            756
        };






    }
}
