using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class DisplayClass
    {
        public static void display(int[][] arr)
        {
            
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void display(int[] arr)
        {

            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
