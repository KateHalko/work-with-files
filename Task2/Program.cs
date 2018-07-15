using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the name of folder: ");
            string folderName = Console.ReadLine();
            string path1 = "C:\\Users\\user\\Desktop\\Лаба 9\\Lab9\\Task2\\" + folderName;
            Directory.CreateDirectory(path1);
            Console.WriteLine("Input the name of first file in folder: ");
            string firstFileName = Console.ReadLine();
            string path2 = path1 + "\\" + firstFileName + ".txt";
            File.Create(path2).Close();
            Console.WriteLine("Input the name of second file in folder: ");
            string secondFileName = Console.ReadLine();
            string path3 = path1 + "\\" + secondFileName + ".txt";
            File.Create(path3).Close();
            Console.WriteLine("Input the text in first file: ");
            string text = Console.ReadLine();
            using (StreamWriter wtr1 = new StreamWriter(path2, true))
            {
                wtr1.WriteLine(text);
                wtr1.Close();
            }
            char[] reverse = text.Reverse().ToArray();
            using (StreamWriter wtr2 = new StreamWriter(path3, true))
            {
                wtr2.WriteLine(reverse);
                wtr2.Close();
            }
            StreamReader rdr1 = new StreamReader(path2);
            string file1 = rdr1.ReadToEnd();
            Console.Write("First file contents: "+ file1);
            rdr1.Close();
            StreamReader rdr2 = new StreamReader(path3);
            string file2 = rdr2.ReadToEnd();
            Console.Write("Second file contents: "+ file2);
            rdr2.Close();
            Console.ReadKey();
        }
    }
}
