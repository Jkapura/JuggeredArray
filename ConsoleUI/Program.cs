using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace ConsoleUI
{
    class Program
    {
        enum Keys 
        {
            Sum, Max, Min
        }
        static void Main(string[] args)
        {
            int[][] juggArr = new int[][] 
            {
                new int[] { 6, 14, 8, 17, 20},  // sum 65 , max 20, min 6
                new int[] {25, 11, 7, 13, 5, 1},  // sum 62, max 25, min 1
                new int[] {9, 3, 2, 11},  // sum 25, max 11, min 2
                new int[] {20, 4, 12}  // sum 36, max 20, min 4
            };
            
            DisplayClass.display(juggArr);
            
            
            DisplayClass.display(juggArr);
        }        
    }
}
