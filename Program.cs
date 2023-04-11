using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_PolessUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4. Учитывая целочисленный массив nums, вернуть третье максимальное число в этом массиве.
               Если третьего максимума не существует, вернуть максимальное число.
            */

            int[] nums = new int[] { 1, 98, 44, 2};
            int Max = nums[0]; // Максимальное число
            int Max2 = nums[0]; // Второе по максиммуму число
            int Max3 = nums[0]; // Третье по максимуму число


            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > Max)
                    Max = nums[i];
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (Max > nums[i] && nums[i] > Max2)
                    Max2 = nums[i];
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (Max > nums[i] && Max2 > nums[i] && nums[i] > Max3)
                    Max3 = nums[i];
            }

            if(nums.Length < 3)
            {
                Console.WriteLine(Max);
            }    
            else
            {
                Console.WriteLine(Max);
                Console.WriteLine(Max2);
                Console.WriteLine(Max3);
            }


            Console.ReadLine();
        }
    }
}
