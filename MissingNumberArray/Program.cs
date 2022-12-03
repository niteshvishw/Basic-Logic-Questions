using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 5, 6,8 };
            int MisNumber = 0;

            for(int i=0;i<array.Length-1;i++)
            {
                if (array[i] != array[i+1]-1)
                {
                    MisNumber = array[i] + 1;
                }
            }
            Console.WriteLine("The Missing Number Is = {0}", MisNumber);
            Console.ReadLine();
            
        }
       
    }
}
