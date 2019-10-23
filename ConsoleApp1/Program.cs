using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            VariousArray<object> array = new VariousArray<object>();

            array.Add("str");
            array.Add(3);

          
           
            foreach (var item in array)
            {
                Console.WriteLine($"{item} ");
            }
            Console.ReadKey();
        }
    }
}
