using System;

namespace HomeworkDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "tree");
            myDictionary.Add(2, "apple");
            myDictionary.Add(3, "hungry");

            myDictionary.Keys(1);
            myDictionary.Keys(3);
            myDictionary.Keys(19);
        }
    }
}
