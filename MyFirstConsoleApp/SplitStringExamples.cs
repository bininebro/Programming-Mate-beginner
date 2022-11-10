using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    public class SplitStringExamples
    {
        public string[] SplitText(string Text)
        {
            string[] splited = Text.Split(" ");
            return splited;
        }


        public string[] SplitCount(string Text)
        {
            string[] splited = Text.Split(" ",2, StringSplitOptions.None);
            return splited;
        }
        // out put option goes here

        public string[] SplitMultipleCharcters(string Text)
        {
            string[] splitarray = { " ", ",", "[", "]" ,".","&"};
            string[] splited = Text.Split(splitarray, StringSplitOptions.None);
            return splited;
        }
    }
}
