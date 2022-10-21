using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int evenNumber = 0;
            int oddNumber = 0;
            int count = 0;
            int sumOdd = 0;
            int sumEven = 0;

            Console.WriteLine("Введите лимит!");

            int limit = int.Parse(Console.ReadLine());
            while(count < limit)
            {
                Console.WriteLine(count);
                

                if(count%2 == 0)
                {
                    evenNumber++;
                    sumEven = sumEven + count;
                }
                else
                {
                    oddNumber++;
                    sumOdd = sumOdd + count;
                }
                count++;
            }
            Console.WriteLine("Количество четных чисел = " + evenNumber + " при лимите " + limit + " и сумма четных ровна " + sumEven);
            Console.WriteLine("Количество не четных чисел = " + oddNumber + " при лимите " + limit + " и сумма не четных ровна " + sumOdd);
        }
    }
}
