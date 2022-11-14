using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    public class Loop
    {

        public void froloop()
        {
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void whileLoop()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void doWhileLoop()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);

        }
        //check out linq section for more example on foreach
    }
}
