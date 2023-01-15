using System;
using System.Collections.Generic;
using System.Linq;


namespace MyCustomExtensions
{
    public static class MyExtensions
    {
        
        public static void Display<T>(T t) => Console.WriteLine(t);
        public static void ProcessItems<T>(this IEnumerable<T> items)
        {
            switch (items)
            {
                case IEnumerable<int> ints:
                    Integers();
                    break;
                case IEnumerable<string> strings:
                    Strings();
                    break;
                default:
                    Display("Invalid input.");
                    break;
            }


            void Integers()
            {
                var positiveNumbers = items.OfType<int>().Where(x => x > 0);

                if (positiveNumbers.Any())
                {
                    var sum = positiveNumbers.Sum();

                    Display(sum);
                }
                else
                {
                    Display("No positive integers found!");
                }
            }


            void Strings()
            {
                foreach (var item in items)
                {
                    Display(item);
                }
            }

        }
    }
}
