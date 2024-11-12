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

        foreach (var spook in phantom)
        {
            Console.WriteLine(spook);
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

        foreach (var spooky in numbers)
        {
            Console.WriteLine(spooky);
        }

        //A dictonary seems to be able to take two Datatypes at the same time after each ohter. 
        //Both of the types can be the same like example 1 or they can be of two different types like example 2

        //example 1
        Dictionary<string, string> theBooks = new Dictionary<string, string>
        {
            {"book one","Twilight"},
            {"book two", "New Moon"},
            {"book three", "Eclipse"},
            {"book four", "Breaking Dawn"}
        };

        //example 2
        Dictionary<string, int> PageCount = new Dictionary<string, int>
        {
            {"Twilight", 489},
            { "New Moon", 563},
            {"Eclipse", 629},
            {"Breaking Dawn", 756}
        };











    }
}
