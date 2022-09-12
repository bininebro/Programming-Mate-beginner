using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    public class SubStringExamples
    {
        public string SubStringNumber(string text)
        {
            string finalstring;
            finalstring = text.Substring(3);
            return finalstring;
        }

        // if the text is short  
        // change the discription latter
        public string SubStringNumberTryCatch(string text)
        {
            try
            {
                string finalstring;
                finalstring = text.Substring(3);
                return finalstring;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "String Is to short";
            }
        }

        public string SubStringWithLegth(string text)
        {
            string finalstring;
            finalstring = text.Substring(3,5);  // 5 is not the end index it is how many text it will return
            return finalstring;
        }


        // find the index with index of
        public string SubStringWithIndex(string text)
        {
            string finalstring;
            int index = text.IndexOf(",");
            finalstring = text.Substring(index);
            return finalstring;
        }

        // find the index and the last index and also escape charcters
        public string SubStringWithIndexs(string text)
        {
            string finalstring;
            int index = text.IndexOf("\"");
            int endIndex = text.LastIndexOf("\"");
            int lenght = endIndex - index;
            finalstring = text.Substring(index, lenght);
            return finalstring;
        }
    }
}
