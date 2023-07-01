using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionProject
{
    internal class Calculater
    {
        public void AdditionOfTwoNumbers()
        {
            Console.WriteLine("Please enter first number");
            int firstNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int secondNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum:" + (firstNumb + secondNumb));

    }
    }
}
