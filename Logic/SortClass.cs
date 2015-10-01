using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class SortClass
    {
        public static void InsertionSortUp(int[][] arr, int key)
        {
            int[] choisedKeys = null;
            switch (key)
            {
                case 0:
                    choisedKeys = SearchClass.summing(arr);
                    break;
                case 1:
                    choisedKeys = SearchClass.findMaxs(arr);
                    break;
                case 2:
                    choisedKeys = SearchClass.findMins(arr);
                    break;
                default:
                    Console.WriteLine("unknown key");
                    break;
            }
            
            int i, j;
            for (j = 1; j < choisedKeys.Length; j++)
            {
                int tempK = choisedKeys[j];
                int[] tempA = arr[j];
                i = j;
                while (i > 0 && choisedKeys[i - 1] >= tempK )
                {                    
                    arr[i] = arr[i - 1];
                    choisedKeys[i] = choisedKeys[i - 1];                  
                    --i;                    
                }
                arr[i] = tempA;
                choisedKeys[i] = tempK;
            }
            }
            
        }
   
        //public static void InsertionSortDown(int[] arr)
        //{
        //    int i, j;
        //    for (j = 1; j < arr.Length; j++)
        //    {
        //        int temp = arr[j];
        //        i = j;
        //        while (i > 0 && arr[i - 1] <= temp)
        //        {
        //            arr[i] = arr[i - 1];
        //            --i;

        //        }
        //        arr[i] = temp;
        //    }
           
        //}
    }

