using System;
using System.Data.Common;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Peter", "Whiskas");
            Animal dog = new Dog("Gunnar", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
