using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace lab10
{
    class Program
    {
        
            static void Main(string[] args)
        {
            string line;
           
            StreamReader Reader = new StreamReader("...\\input.txt");
            List<int> array = new List<int>();
            while ((line = Reader.ReadLine()) != null)
            {
                array.Add(Convert.ToInt32(line));
            }
            foreach (int i in array)
            {
                Console.WriteLine(string.Join(" ", i));
            }


            Remover newArray = new Remover(array);
            StreamWriter sw = new StreamWriter("...\\output.txt");
            foreach (int i in newArray.Delete())
            {
                sw.Write(i + " ");
            }
            sw.Close();
            Console.ReadLine();
        }
        }
    }

