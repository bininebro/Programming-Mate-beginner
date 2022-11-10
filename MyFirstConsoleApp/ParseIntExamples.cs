using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    public  class ParseIntExamples
    {
        // parse int simple
        public int ParseInt(string num)
        {
            int conveted;

            conveted = Int32.Parse(num);
            return conveted;
        }
        // the abouve could throw an error if the string is not numbers

        //parse int with try catch
        public int ParseIntTryCatch(string text)
        {
            try
            {
                int conveted;

                conveted = Int32.Parse(text);
                return conveted;
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
                return 0;
            }
        }



        public int TryParseInt(string text)
        {
            bool isConveted;

            isConveted = Int32.TryParse(text,out int x);
            if (isConveted)
            {
                return x;
            }
            else
            {
                return 0;
            }
        }

        public int ConvertInt(string text)
        {

            int conveted;

            conveted = Convert.ToInt32(text);  //Convert will cause error if it is not a number
            return conveted;
        }


        // this will couse issues if  >32767 including nagatives
        public int Parseint32TryCatch(string text)
        {
            try
            {
                int conveted;

                conveted = Int16.Parse(text);
                return conveted;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

        }



        public int ParseNumberStyle(string text)
        {
            try
            {
                int conveted;

                conveted = Int32.Parse(text, NumberStyles.AllowCurrencySymbol);
                return conveted;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

        }
        public int ParseNumberStyleAllowParentheses(string text)
        {
            try
            {
                int conveted;

                conveted = Int32.Parse(text, NumberStyles.AllowParentheses);
                return conveted;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

        }
    }
}
