using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Arrays
    {
        private static void InitializeArray(int count)
        {
            int[] myarray = new int[count];
            for (int i = 0; i < count; i++)
            {
                myarray[i] = i * 5;
            }
            myarray.ToList().ForEach(x => Console.WriteLine(x));
        }

        private static void CompareTwoArrays()
        {
            Console.WriteLine("input the length of 1st array");
            int.TryParse(Console.ReadLine(), out int array1Length);
            int[] myarray1 = new int[array1Length];

            for (int i = 0; i < array1Length; i++)
            {
                Console.WriteLine($"Enter {i + 1} value for index");
                myarray1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("input the length of 2nd array");
            int.TryParse(Console.ReadLine(), out int array2Length);
            int[] myarray2 = new int[array2Length];

            for (int i = 0; i < array2Length; i++)
            {
                Console.WriteLine($"Enter {i + 1} value for index");
                myarray2[i] = int.Parse(Console.ReadLine());
            }

            if (array1Length == array2Length)
            {
                for (int i = 0; i < array1Length; i++)
                {
                    if (myarray1[i] != myarray2[i])
                    {
                        Console.WriteLine($"Index {i} does not match");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"index {i} of both arrays are equal");
                    }
                }
            }
            else
            {
                Console.WriteLine("arrays length are not equal");
            }
        }

        private static void CompareLexicographicallyUsingCompareTo(string word1, string word2)
        {
            int result = word1.CompareTo(word2);
            if (result == 0)
            {
                Console.WriteLine("Both words are equal");
            }
            else if (result < 0)
            {
                Console.WriteLine(word1);
            }
            else
            {
                Console.WriteLine(word2);
            }
        }

        private static void CompareLexicographically(string word1, string word2)
        {
            char[] word1Char = word1.ToCharArray();
            char[] word2Char = word2.ToCharArray();

            int length = 0;
            int count = 0;
            string holder = string.Empty;

            if (word1Char.Length < word2Char.Length)
            {
                length = word1Char.Length;
                holder = word1;
            }
            else
            {
                length = word2Char.Length;
                holder = word2;
            }
            for (int i = 0; i < length; i++)
            {
                if (word1Char[i].CompareTo(word2Char[i]) == 0)
                {
                    count = count + 1;
                    if (count == length)
                    {
                        Console.WriteLine(holder);
                    }
                    continue;
                }
                else if (word1Char[i].CompareTo(word2Char[i]) < 0)
                {
                    Console.WriteLine(word1);
                }
                else
                {
                    Console.WriteLine(word2);
                }
            }
        }

        private static void PrintMaximalSequence()
        {
            int[] myarray = new int[] { 1, 1, 2, 3, 2, 2, 2, 1, 1, 1, 1, 1 };
            int sum = 0, index = 0;
            for (int i = 0; i < myarray.Length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < myarray.Length; j++)
                {
                    if (myarray[i] == myarray[j])
                    {
                        count += 1;
                        if (count > sum)
                        {
                            sum = count;
                            index = i;
                        }
                    }
                }
            }
            for (int i = 0; i < sum; i++)
            {
                Console.Write(myarray[index] + " ");
            }
        }

        private static void MaximalSequenceOfIncreasingNumber()
        {
            int[] myarray = new int[] { 3, 1, 2, 3, 4, 5, 2, 2, 4 };

            int sum = 0;
            int index = 0;
            for (int i = 0; i < myarray.Length; i++)
            {
                int count = 1;
                int decrement = 1;
                for (int j = i + 1; j < myarray.Length; j++)
                {
                    int a = myarray[i];
                    int b = myarray[j];
                    if (a == b - decrement)
                    {
                        count += 1;
                        if (count > sum)
                        {
                            sum = count;
                            index = i;
                        }
                        decrement += 1;
                    }
                    else { continue; }
                }
            }
            for (int i = 0; i < sum; i++)
            {
                Console.Write($"{index + i} ");
            }
        }

        private static void KMaximalSequence()
        {
            Console.WriteLine("Enter the value for N:");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for K (K<N)");
            int K = int.Parse(Console.ReadLine());

            int[] myarray = new int[] { 1, 2, 3, 10, 12, 3, 4 };
            int sum = 0;
            if (K < N)
            {
                for (int i = 0; i < myarray.Length; i++)
                {
                    if (myarray[i] < N)
                    {
                        int tempSum = myarray[i];
                        for (int j = i + 1; j < myarray.Length; j++)
                        {
                            if (myarray[j] < N)
                            {
                                tempSum += myarray[j];
                                if (tempSum > sum)
                                {
                                    sum = tempSum;
                                    //Console.WriteLine(sum);
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("K should be smaller than N");
            }
            Console.WriteLine(sum);
        }

        private static int[] SelectionSort(int[] numbs)
        {
            int[] numbers = numbs;

            for (int i = 0; i < numbers.Length; i++)
            {
                int holder = 0;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        holder = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = holder;
                    }
                }
            }
            return numbers;
        }

        private static int BinarySearch(int[] arr, int l,
                            int r, int x)
        {
            if (r > l)
            {
                int mid = l + (r - 1) / 2;

                if (arr[mid] == x)
                {
                    return mid;
                }
                if (x < arr[mid])
                {
                    return BinarySearch(arr, l, mid - 1, x);
                }
                if (x > arr[mid])
                {
                    return BinarySearch(arr, mid + 1, r, x);
                }
            }

            return -1;
        }

        private static void MergeSort()
        {

        }

        public static void Main(string[] args)
        {
            //InitializeArray(5);
            //CompareTwoArrays();
            //CompareLexicographically("lovely", "loveliness");
            //PrintMaximalSequence();
            //MaximalSequenceOfIncreasingNumber();
            //KMaximalSequence();
            int[] arr = { 10,9,8,7,6,5,4,3,2,1 };
            int[] sorted = SelectionSort(arr);
            int n = sorted.Length;
            int x = 10;

            int result = BinarySearch(sorted, 0, n - 1, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                  + result);
            Console.ReadLine();
        }
    }
}
