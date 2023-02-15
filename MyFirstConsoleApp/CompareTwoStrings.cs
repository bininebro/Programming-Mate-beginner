using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    public class CompareTwoStrings
    {
        public CompareTwoStrings()
        {
            string text1 = "I am a string";
            string text2 = "I am a string";
            Console.WriteLine( text1 == text2); // true

            Console.WriteLine(text1.Equals(text2)); // true

            string text3 = "I am a string";
            string text4 = "i am a string";
            Console.WriteLine(text3.Equals(text4, StringComparison.InvariantCultureIgnoreCase));  // true


            Console.WriteLine(text3== text4);  // false
            Console.WriteLine(text3.ToUpperInvariant()== text4.ToUpperInvariant()); // true
            Console.WriteLine(text3.ToLowerInvariant()== text4.ToLowerInvariant()); // true

        }
    }
}
