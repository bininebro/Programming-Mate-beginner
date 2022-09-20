using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    public class StringInterpulation
    {
        public string UsingAdd(string firstTest, string secondText)
        {
            return "this is a concatnated text " + firstTest + " " + secondText;
        }
        public string UsingStringFormat(string firstTest, string secondText)
        {
            return string.Format("this is a concatnated text {0} {1}", firstTest, secondText);
        }

        public string UsingStringInterpulation(string firstTest, string secondText)
        {
            return $"this is a concatnated text {firstTest}  {secondText}";
        }
    }
}
