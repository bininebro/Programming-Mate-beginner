using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    public class ArrayExamples
    {
        // how to intalize an array
        public void CreateAnArray()
        {
            int[] ints = new int[10];
            char[] chars = new char[10];
            string[] array = new string[10];
            double[] doubles = new double[10];


            // creating empity arrays
            string[] arrays = new string[] { };


            // initalized arrays

            int[] intinitalized = { 1, 2, 3, 54 };
            char[] charsinitalized ={'P','R','O','G','R','A', 'M', 'M','I','N','G',' ', 'M','A','T','E'};
            string[] arrayinitalized = { "Programming"," " ,"mate"};
            bool[] bools = { true, false, false, false, false, false, false, false, false, false, };
            
        }
        //How to print an array
        public void DisplayAnArray()
        {
            char[] chars = { 'P', 'R', 'O', 'G', 'R', 'A', 'M', 'M', 'I', 'N', 'G', ' ', 'M', 'A', 'T', 'E' };
            for(int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }
        }

        public void ReverseAnArray()
        {
            char[] chars = { 'P', 'R', 'O', 'G', 'R', 'A', 'M', 'M', 'I', 'N', 'G', ' ', 'M', 'A', 'T', 'E' };
            for (int i = chars.Length - 1; i > 0; i--)
            {
                Console.WriteLine(chars[i]);
            }
        }

        public void ClearAnArray()
        {
            char[] chars = { 'P', 'R', 'O', 'G', 'R', 'A', 'M', 'M', 'I', 'N', 'G', ' ', 'M', 'A', 'T', 'E' };
            chars = new char[] { };
            
            for (int i = chars.Length - 1; i > 0; i--)
            {
                Console.WriteLine(chars[i]);
            }
        }
        public void AddIteminArray()
        {
            char[] chars= { 'P', 'R', 'O', 'G', 'R', 'A', 'M', 'I', 'N', 'G', ' ', 'M', 'A', 'T', 'E' };
            chars.Append('E');
        }

        public void RemoveIteminArray()
        {

            char[] chars = { 'P', 'R', 'O', 'G', 'R', 'A', 'M', 'I', 'N', 'G', ' ', 'M', 'A', 'T', 'E' };
            chars.Except(new char[2]);
            chars[3] = 'a';            
        }

       

        public void SortAnArray()
        {
            // for data structure and anlgoriths future
        }
    }
}
