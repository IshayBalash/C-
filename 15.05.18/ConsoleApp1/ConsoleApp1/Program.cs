using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {   static int CheckInput(string str)
        {
            int result = ((str[0]>=48) && (str[0] <= 57)) ? Convert.ToInt32(str) :-1;
            return result;
        }
        static void Main(string[] args)
        {
            int[] NumArr = new int[8];
            for (int i = 0; i < NumArr.Length; i++)
            {
                Console.WriteLine($"enter a positiv number between 0-9  for the {i+1} time please");
                string str = Console.ReadLine();
                int num = CheckInput(str);
                if (num>=10||num<0)
                {
                    Console.WriteLine("why didn't you enterd what i wanted??!!!");
                    Console.WriteLine("lets try again");
                    i--;
                    continue;
                }
                else
                {
                    NumArr[i] = num;
                }
            }
            Console.WriteLine($"the arry is:");
            foreach (int item in NumArr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            for (int j = 0; j < NumArr.Length-1; j++)
            {
                if ((NumArr[j] + NumArr[j + 1]) % 2 != 0)
                {
                    Console.WriteLine($"if you add {NumArr[j]} and {NumArr[j+1]} you get an odd number");
                }
            }
        }
    }
}
