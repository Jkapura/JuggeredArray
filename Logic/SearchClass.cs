using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class SearchClass
    {
        public static int[] summing(int[][] arr)
        {
            int[] summs = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    summs[i] += arr[i][j];
                }
            }
            return summs;
        }

        public static int[] findMaxs(int[][] arr)
        {
            int[] maxs = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                maxs[i] = arr[i][0];
                for (int j = 0; j < arr[i].Length-1; j++)
                {

                    if (maxs[i] < arr[i][j + 1])                  
                        maxs[i] = arr[i][j + 1];                    
                }
            }
            return maxs;
        }
        public static int[] findMins(int[][] arr)
        {
            int[] mins = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                mins[i] = arr[i][0];
                for (int j = 0; j < arr[i].Length - 1; j++)
                {

                    if (mins[i] > arr[i][j + 1])
                        mins[i] = arr[i][j + 1];
                }
            }
            return mins;
        }

    
    }
}
