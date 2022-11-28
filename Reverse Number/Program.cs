using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            //int num = 154;
            int num;
            Console.WriteLine("Enter The Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int rem;

            while(num!=0)
            { 
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("The Reverse Number Is: " +result);
            Console.ReadLine();
        }
    }
}
