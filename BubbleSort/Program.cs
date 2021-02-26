using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 11, 93, 45, 98, 13, 55 };

            BubbleSort(arr);
        }

        public static void BubbleSort(int[] myArray)
        {
            int temp;

            for (int i = 0; i < myArray.Length; i++)
            {
                bool ordered = true;

                for (int j = myArray.Length-1; j > i; j--)
                {
                    if (myArray[j-1] > myArray[j])
                    {
                        ordered = false;

                        temp = myArray[j - 1];
                        myArray[j - 1] = myArray[j];
                        myArray[j] = temp;
                    }
                }
                if (ordered)
                    break;
            }

            for ( int k = 0; k < myArray.Length; k++)
            {
                if (k == myArray.Length-1)
                    Console.Write(myArray[k]);
                else
                    Console.Write(myArray[k] + ", ");
            }
            Console.ReadLine();
        }
    }
}