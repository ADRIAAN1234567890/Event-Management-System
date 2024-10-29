using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageClick
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageDisplayer displayer = new ImageDisplayer();
            Console.WriteLine("Enter command:");
            string command = Console.ReadLine();
            Console.WriteLine(displayer.DisplayImage(command));
        }
    }
}
