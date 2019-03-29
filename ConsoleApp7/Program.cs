using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Anil";
            string lName = "Srivastava";
            string statement = "Hello, my name is ";
            string sentence = statement + fName + " " + lName + "!";
            Console.WriteLine(sentence);

            sentence = sentence.ToUpper();
            Console.WriteLine(sentence);

            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("\nHello, my name is Anil.");
            paragraph.Append(" I enjoy coding using C#.");
            paragraph.Append(" It has been an excellent language to learn.");
            paragraph.Append(" I think stringBuilder is better than string!");
            Console.WriteLine(paragraph);


            Console.ReadLine();
        }
    }
}
