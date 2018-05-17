using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2];
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("enter cher");
                string str = Console.ReadLine();
                if (str.Length > 1)
                {
                    Console.WriteLine("too much leeters for my");
                    Environment.Exit(0);
                }
                char cher = str[0];
                arr[i] = (int)cher;
            }
            int result = Calculate_Resulte(arr[0], arr[1]);
            Console.WriteLine(" the result is: {0}",result);
            }
        //function section//////
        public static int Calculate_Resulte(int num1, int num2)
        {
            int result1 = num1 - num2;
            return result1;
        }
    }
}
    

