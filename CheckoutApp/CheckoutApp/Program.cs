using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutApp;

namespace CheckoutApp
{
     public class Program
    {
        static void Main(string[] args)
        {
            CheckoutProducts();
        }
        public static void CheckoutProducts()
        {
            Console.WriteLine("Your products have been checked out without any shipping fee.");
        }
    }
}
