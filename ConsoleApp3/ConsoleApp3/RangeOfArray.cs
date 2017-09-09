using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class RangeOfArray
    {

        private int[] rangeOfArray;

        public RangeOfArray()
        {
            rangeOfArray = new int[1];
        }

        public RangeOfArray(int size)
        {
            rangeOfArray = new int[size];
        }

        public int LowIndex
        {
            get;
            set;
        }
        public int HighIndex
        {
            get;
            set;
        }

        public int this[int i]
        {
            get
            {
                if (i < 0)
                {
                    return rangeOfArray[i - LowIndex];
                }
                else
                {
                    return rangeOfArray[i - LowIndex];
                }
            }
            set
            {
                if (i < 0)
                {
                    if (i >= LowIndex && i <= HighIndex)
                    {
                        rangeOfArray[i - LowIndex] = value;
                    }
                    else
                    {
                        Console.WriteLine("Выход за пределы");
                    }
                }

                else
                {
                    if (i >= LowIndex && i <= HighIndex)
                    {
                        rangeOfArray[i - LowIndex] = value;
                    }
                    else
                    {
                        Console.WriteLine("Выход за пределы");
                    }
                }

            }
        }
        
    }
}
