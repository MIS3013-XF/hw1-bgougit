// HW1b Grade

// Your Name: Britten George
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name? ");
            string firstname = Console.ReadLine();

            Console.WriteLine("What is your last name? ");
            string lastname = Console.ReadLine();

            Console.WriteLine("What is your student id? ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            double homeworkgrade = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for participations?");
            double participationgrade = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for quizzes?");
            double quizgrade = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for Exam 1?");
            //added exam1 since sylabus weight has it
            double exam1 = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for the midterm? (Exam 2)");
            double midtermgrade = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for final?");
            double finalgrade = double.Parse(Console.ReadLine());

            //quiz grades are counted with participation

            double total = (homeworkgrade * .2) + (((participationgrade + quizgrade) / 2) * .15) + (exam1 * .15) + (midtermgrade * .25) + (finalgrade * .25);
            Console.WriteLine($"{firstname} {lastname} ({id}), your final grade is {total}%");
            Console.ReadKey();
            //DONE
        }
    }
}
