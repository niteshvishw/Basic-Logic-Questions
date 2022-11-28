using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string revString = " ";
            Console.WriteLine("Enter The String Values: ");
            str=Console.ReadLine();
            str.ToLower();
            for(int i =1; i<str.Length; i++)
            {
                revString = revString + str[i];
                Console.WriteLine("The Reverse String Is: "+revString);
            }
            Console.ReadLine();
        }
    }
}
