using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            string word1 = "Hello";
            string word2 = "Word";
            string space = " ";
            object sentence = "";

            //concatenating strings
            sentence = word1 + space + word2;
            string str = (string)sentence;

            //showing the message
            Console.WriteLine(str);
            
            Console.ReadKey();
        }
    }
}
