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

        private static void CompareLexicographicallyUsingCompareTo(string word1,string word2)
        {
            int result = word1.CompareTo(word2);
            if (result == 0)
            {
                Console.WriteLine("Both words are equal");
            }else if (result < 0)
            {
                Console.WriteLine(word1);
            }
            else
            {
                Console.WriteLine(word2);
            }
        }

        private static void CompareLexicographically(string word1,string word2)
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
                if (word1Char[i].CompareTo(word2Char[i])==0)
                {
                    count = count + 1;
                    if (count == length)
                    {
                        Console.WriteLine(holder);
                    }
                    continue;
                }
                else if(word1Char[i].CompareTo(word2Char[i]) < 0)
                {
                    Console.WriteLine(word1);
                }
                else
                {
                    Console.WriteLine(word2);
                }
            }
        }

        public static void Main(string[] args)
        {
            //InitializeArray(5);
            //CompareTwoArrays();
            CompareLexicographically("lovely", "loveliness");
            Console.ReadLine();
        }
    }
}
