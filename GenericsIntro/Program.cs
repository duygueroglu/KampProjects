using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>(); //create reference in memory
            
            names.Add("Duygu");
            Console.WriteLine(names.Length);
            names.Add("Dilek");
            Console.WriteLine(names.Length);

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
        }
    }
}
