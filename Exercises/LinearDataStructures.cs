#if RemoveToRun
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    //Linear Data Structures
    class LinearDataStructures
    {

        #region Exercise1
        static List<int> nums = new List<int>();
        private static void Exercise1()
        {
            Console.WriteLine("Enter the number");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    PrintAvg();
                }
                else
                {
                    nums.Add(Math.Abs(int.Parse(input)));
                }
            }
        }
        private static void PrintAvg()
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }
            int avg = sum / nums.Count;
            Console.WriteLine($"The sum is {sum} and the average is {avg}");
        }
        #endregion

        #region Exercise2
        public static void Exercise2()
        {
            const int REP = 5;
            Console.WriteLine("Please enter 5 nos.");
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < REP; i++)
            {
                stack.Push(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Printing in reverse order");
            for (int i = 0; i < REP; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        #endregion

        #region Exercise3
        private static void Exercise3()
        {
            List<int> lst = new List<int>();
            Console.WriteLine("Enter some numbers");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    lst.Sort();
                    foreach (var item in lst)
                    {
                        Console.WriteLine(item);
                    }
                    return;
                }
                else
                {
                    lst.Add(Math.Abs(int.Parse(input)));
                }
            }
        }
        #endregion

        #region Exercise4
        private static void Exercise4()
        {
            List<int> lstNumbers = new List<int> { 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4 };
            List<int> subSequence = new List<int>();
            int prev = lstNumbers[0];
            subSequence.Add(prev);
            int count = 1;
            for (int i = 1; i < lstNumbers.Count; i++)
            {
                if (prev == lstNumbers[i])
                {
                    count++;
                }
                else
                {
                    if (count > subSequence.Count)
                    {
                        subSequence.Clear();
                        for (int j = 0; j < count; j++)
                        {
                            subSequence.Add(prev);
                        }
                    }
                    prev = lstNumbers[i];
                    count = 1;
                }
            }
            foreach (var item in subSequence)
            {
                Console.Write(item + " ");
            }
        }
        #endregion

        #region Exercise5
        private static void Exercise5()
        {
            int[] arr = { 19, -10, 12, -6, -3, 34, -2, 5 };
            List<int> posArr = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                char[] numChar = arr[i].ToString().ToCharArray();
                if (numChar[0] != '-')
                {
                    posArr.Add(arr[i]);
                }

            }
            foreach (var item in posArr)
            {
                Console.Write(item + " ");
            }
        }
        #endregion

        #region Exercise6
        private static void Exercise6()
        {
            int[] arr = { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (num == arr[j])
                    {
                        count++;
                    }
                }
                if (count % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
        #endregion

        #region Exercise7
        private static void Exercise7()
        {
            int[] arr = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            SortedDictionary<int, int> repetitionDic = new SortedDictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                if (repetitionDic.TryGetValue(arr[i], out int value))
                {
                    repetitionDic[arr[i]] = value + 1;
                }
                else
                {
                    repetitionDic.Add(arr[i], count + 1);
                }
            }
            foreach (var item in repetitionDic)
            {
                Console.WriteLine($"{ item.Key} - {item.Value}");
            }
            //int count = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int num = arr[i];
            //    count = 0;

            //    bool flag = true;
            //    if (i != 0)
            //    {
            //        for (int k = i; k >= 0; k--)
            //        {
            //            if (arr[i] == arr[k])
            //            {
            //                flag = false;
            //            }
            //        }
            //        if (flag)
            //        {
            //            for (int j = 0; j < arr.Length; j++)
            //            {
            //                if (num == arr[j])
            //                {
            //                    count++;
            //                }
            //            }
            //            Console.WriteLine(num + " - " + count);
            //        }                   
            //    }              

            //}
        }
        #endregion

        #region Exercise9
        private static void Exercise9()
        {
            Console.WriteLine("Please enter the value of N");
            int N = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            int s1 = N, s2, s3, s4;
            queue.Enqueue(s1);
            for (int i = 0; i < 50; i++)
            {
                s2 = s1 + 1;
                s3 = 2 * s1 + 1;
                s4 = s1 + 2;
                queue.Enqueue(s2);
                queue.Enqueue(s3);
                queue.Enqueue(s4);
                s1 = s2;
            }
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
        #endregion
        public static void Main(string[] args)
        {
            Console.WriteLine(typeof(LinearDataStructures).Name);
            Exercise9();
            Console.ReadLine();
        }
    }
}
#endif