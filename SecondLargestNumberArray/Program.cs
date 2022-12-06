using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] {12,34,12,53,76,45,68,100};
            int largest = int.MinValue;
            int second = int.MinValue;
            foreach (int i in myArray)
            {
                if (i > largest)
                {
                    second = largest;
                    largest = i;
                }
                else if (i > second)
                    second = i;
            }

            Console.WriteLine("The Second Largest Number: "+second);
            Console.ReadLine();
        }
   
    }
}
