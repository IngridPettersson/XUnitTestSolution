using System;
using CodeLibrary;

namespace MyExcellentApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodsCollection methods = new MethodsCollection();
            int result = methods.Add(1, 1);
            Console.WriteLine(result);
        }
    }
}
