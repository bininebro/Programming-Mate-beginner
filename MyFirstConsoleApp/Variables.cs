using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    public class Variables
    {
        Variables()
        {
            int intiger = 0;
            float floatValue = 12.4f;
            double doubleValue = 34.56;
            bool boolValue = false;
            char charValue = 'c';
            string stringValue = "string";

            Console.WriteLine();
        }

        public void outvariables(out int outtest)
        {
            outtest = 5;
        }
        public void refVariables(ref int reftest)
        {
            reftest = 5;
        }

        //Return multiple characters from a function in c#/.net

        public Tuple<string, string, int> ReturnTuple()
        {
            return new Tuple<string, string, int>("programing", "mate", 344);
        }

        public CustomObject ReturnObject()
        {
            return new CustomObject()
            {
                myint = 32,
                mydouble = 343.3,
                mystring = "Programming mate"
            };
        }


    }
    public class CustomObject
    {
        public int myint { get; set; }
        public string mystring { get; set; }
        public double mydouble{ get; set; }

    }

}
