using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter File Name");
            string name;
            name = Console.ReadLine();



            string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\Glen Sanborn\OneDrive\Desktop\Test1.csv");
            

            var first = new List<string>();
            var last = new List<string>();
            var mail = new List<string>();

            for (int i = 0; i < csvLines.Length; i++)
            {
                string[] rowData = csvLines[i].Split(',');
                first.Add(rowData[0]);
                last.Add(rowData[1]);
                mail.Add(rowData[2]);
            }
            
            for (int i = 0; i < mail.Count; i++)
            {
                Console.WriteLine(mail[i]);
            }
          Console.ReadKey();
        }
    }
    
}
