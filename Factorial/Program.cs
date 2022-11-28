using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int fact = 1;
            //int num = 5;
            int num;
            Console.WriteLine("Enter The Number: ");
            num = Convert.ToInt32(Console.ReadLine());  


            for(i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
