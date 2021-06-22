using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkLessonFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0,25);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

            List<string> list = new List<string>();
            list.Add("abc");
            list.Add(" fef");
            list.Add("fsdfe");
            list.Add("fsdfwe");
            list.Add("wefgwefsdfe");
            list.RemoveAt(1);
            var newlist = list.Where(t => t.ToUpper().StartsWith("a"));
            Console.WriteLine(newlist);
            Console.ReadKey();
        }
    }
}
