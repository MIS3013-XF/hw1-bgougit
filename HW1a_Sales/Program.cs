// HW1a Sales Total

// Your Name: Britten George
// Did you seek help ? If yes, specify the helper or web link here: I used the slides to remember how to do a horizontal tab

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the product name of the item you're purchasing?");
            string itemname = Console.ReadLine();

            Console.WriteLine($"How many {itemname}'s would you like to buy? ");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"What is the price for each {itemname}?");
            double price = double.Parse(Console.ReadLine());

            double subtotal = quantity * price;
            const double salestax = .085;
            double salestaxtotal = salestax * quantity;
            double Total = subtotal + salestaxtotal;

                Console.WriteLine($"\tYour subtotal for you bill is ${subtotal}.");
                Console.WriteLine($"\tYour sales tax for your bill is ${salestaxtotal}.");
                Console.WriteLine($"\tYour total for your bill is ${Total}.");


            Console.ReadKey();
            //DONE
         }
    }
}
