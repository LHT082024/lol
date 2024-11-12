using System.Collections;

namespace lol;

class Program
{
    static void Main(string[] args)
    {
        ArrayList phantom = new ArrayList();
        phantom.Add("phantom");
        phantom.Add(1);
        phantom.Add(2.2);

        for (int i = 0; i < phantom.Count; i++)
        {
            Console.WriteLine(phantom[i]);
        }


    }
}
