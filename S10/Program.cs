using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student's score: ");
            int score = int.Parse(Console.ReadLine());
            int deducted = 20 - score;
            Console.WriteLine("The student's deducted score is: " + deducted);
            Console.ReadKey();
        }
    }
}
