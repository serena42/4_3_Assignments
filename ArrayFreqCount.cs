using System;
using System.Collections.Generic;
using System.Text;

namespace _4_3_Assignments
{
    internal class ArrayFreqCount
    {
        public ArrayFreqCount() {
            Random rnd = new Random();
            int arraySize = rnd.Next(10, 21);
            int[] numbers = new int[arraySize];
            foreach (var i in Enumerable.Range(0, arraySize))
            {
                numbers[i] = rnd.Next(10, 19);
            }
            Console.WriteLine($"Array elements: [{string.Join("][", numbers)}]");
            Dictionary<int, int> freqCount = new Dictionary<int, int>();
            foreach (var num in numbers)
            {
                if (freqCount.ContainsKey(num))
                {
                    freqCount[num]++;
                }
                else
                {
                    freqCount[num] = 1;
                }
            }
            Console.WriteLine("The unique elements found in the array are:");
            foreach (var key in freqCount)
            {
                if (key.Value == 1)
                {
                    Console.WriteLine($"{key.Key} occurs {key.Value} time");
                }else { Console.WriteLine($"{key.Key} occurs {key.Value} times"); }
                    
            }
            Console.WriteLine("The total number of elements in the array is: " + numbers.Length);
            Console.WriteLine("The number of unique elements in the array is: " + freqCount.Count);
        }
    }
}
