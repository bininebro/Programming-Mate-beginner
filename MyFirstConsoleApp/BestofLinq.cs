using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    public class BestofLinq
    {
        public void Creation()
        {
            List<int> list = new List<int>();
            List<string> list2 = new List<string>();

            list = new List<int> { 1,2,3};
            list.Add(1)
            list.Sort();
            list.Remove(1);
            list.Clear();

            list.ForEach(x => Console.WriteLine(x.ToString()));
        }

        public void Search()
        {
            List<int> list =new List<int> { 1, 2, 3 };
            list.Where(x => x == 1);
             //Select(y=>y ==2);            

        }
    }
}
