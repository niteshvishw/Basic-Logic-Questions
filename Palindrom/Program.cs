using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            // int number = 141;
          
            int number;
            Console.WriteLine("Enter The Number: ");
            number= Convert.ToInt32(Console.ReadLine());

            int result = 0;
            int rem;
            int temp = number;

            while(number!=0)
            {
                rem = number % 10;
                result = result * 10 + rem;
                number = number / 10;
            }

            number = temp;
            if(number == result)
            {
                Console.WriteLine("This is Palindrom!!");
            }
            else
            {
                Console.WriteLine("This is Not Palindrom!!!");
            }
            Console.ReadLine();
        }
    }
}
