using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int highIndex, lowIndex;
            int helper;

            Console.WriteLine("Введите нижнюю границу");
            str = Console.ReadLine();

            for (; ; )
            {
                if (Int32.TryParse(str, out lowIndex))
                {
                    lowIndex = Int32.Parse(str);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Недопустимый символ! Пожалуйста убедитесь, что вводите целое число");
                    Console.WriteLine("Введите нижнюю границу");
                    str = Console.ReadLine();
                }
            }

            Console.WriteLine("Введите верхнюю границу");
            str = Console.ReadLine();

            for (; ; )
            {
                if (Int32.TryParse(str, out highIndex))
                {
                    highIndex = Int32.Parse(str);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Недопустимый символ! Пожалуйста убедитесь, что вводите целое число");
                    Console.WriteLine("Введите верхнюю границу");
                    str = Console.ReadLine();
                }
            }
           
            if(lowIndex > highIndex)
            {
                helper = lowIndex;
                lowIndex = highIndex;
                highIndex = helper;
            }
            
            RangeOfArray rangeOfArray = new RangeOfArray(highIndex-lowIndex+1);
            rangeOfArray.LowIndex = lowIndex;
            rangeOfArray.HighIndex = highIndex;
            
            rangeOfArray[rangeOfArray.LowIndex] = 10;
            rangeOfArray[rangeOfArray.HighIndex] = 19;

            Console.WriteLine(rangeOfArray[rangeOfArray.LowIndex]);
            Console.WriteLine(rangeOfArray[rangeOfArray.HighIndex]);

            Console.ReadLine();
        }

    }
}

