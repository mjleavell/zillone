using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("yoyoyoyoyo");
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            // blue = part of C#, green = .Net library version
            // short - 16 byte; int = 32 byte; long = 64 byte
            // short;
            // int x = 1;
            int? x = 0;
            // long;

            Int32 x1 = 1;
            bool y = true;
            DateTime z = new DateTime(2019, 7, 12);
            string s = "hi";
            // double is more precise than decimal
            double f = 12.34;
            decimal d = 12.34m;

            object o = new { MyProperty = 1234 };
            // below is how you define an array of strings
            string[] stringArray = new[] { "asdf", "dfa", "asdfsadf" };

            // default value for reference type is null
            // default value for value types depends on the type

            // var (below is a type initializer)
            var sam = new string[] { "asdf", "dfa", "asdfsadf" };

            // we will use lists instead of arrays
            // list is a collection; similar to array but different
            var myList = new List<int> { 1,1,1,1 };
            myList.Add(1);
            myList.Add(1);
            myList.Add(1);
            myList.Remove(1); // only removes first 1

            // can input whatever because it boxes values but really only storing objects
            // below is a collection initializer
            // {} is the initializer
            var secondList = new List<int> { 1, 1, 1, 1, 1 };

            /// ****************************CONTROL FLOW**************************
            // C# only uses == because it already knows the type
            if (x == 0)
            {
                Console.WriteLine("yep, it's zero");
            }
            else if (x == 1)
            {
                Console.WriteLine("yep, its one");
            }
            else
            {
                Console.WriteLine("nope");
            }

            // SWITCH FUNCTIONS
            switch (x)
            {
                case 0:
                    Console.WriteLine("its zero");
                    break;
                case 1:
                    Console.WriteLine("yep its one");
                    break;
                case 2:
                    Console.WriteLine("yep its two");
                    break;
                default:
                    Console.WriteLine("none of those things");
                    break;
            }

            var myNumberIsOne = x == 1 ? true : false;

            // for each integer in my list, do this thing
            foreach(var currentNumber in myList)
            {
                Console.WriteLine($"none of {currentNumber} those things");
            }


            try
            {
                x = null;
                x.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // throw;
            }
        }
    }
}
