using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader rdr = new StreamReader("file.txt");
            string text = rdr.ReadToEnd();
            Console.WriteLine("File contents: ");
            Console.WriteLine(text);
            rdr.Close();
            Console.WriteLine("Input new file contents: ");
            string newText = Console.ReadLine();
            StreamWriter wtr = new StreamWriter("file.txt");
            wtr.WriteLine(newText);
            wtr.Close();
            StreamReader rdr2 = new StreamReader("file.txt");
            string text2 = rdr2.ReadToEnd();
            Console.WriteLine("New file contents: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text2);
            rdr2.Close();
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
