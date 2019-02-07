using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Chapter9
    {
        //ex 1
        private static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}", name);
        }
        public static T GetMax<T>(T a,T b) where T: IComparable<T>
        {
            if (a.CompareTo(b) < 0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        private static string IntToWord(string number)
        {
            var numberChar = number.ToCharArray();
            var lastNumber = char.GetNumericValue(numberChar[numberChar.Length - 1]);

            switch (lastNumber)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "invalid";
            }
        }
        private static int CountNumsInArr(int num,params int[] myarray)
        {
            int result = 0;
            for (int i = 0; i < myarray.Length; i++)
            {
                if (num == myarray[i])
                {
                    result++;
                }
            }

            return result;
        }
        private static bool neighbour(int pos, params int[] myarray)
        {
            if (pos == 0)
            {
                if (myarray[pos] > myarray[1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (myarray[pos] > myarray[pos - 1] && myarray[pos] > myarray[pos + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //private static decimal reverse(decimal number)
        //{
        //    if(number != 0)
        //    {

        //    }
        //}
        public static void Main(String[] args)
        {
            //ex1
            //Console.WriteLine("type ur name");
            //string name = Console.ReadLine();
            //PrintName(name);
            //Console.ReadLine();

            //ex2
            //Console.WriteLine("Enter 3 nos sequentially");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //int big = GetMax(GetMax(a,b), c);
            //Console.WriteLine(big);

            //ex3
            //Console.WriteLine("Enter the number in words");
            //string number = Console.ReadLine();
            //Console.WriteLine(IntToWord(number));

            //ex4
            //Console.WriteLine(CountNumsInArr(3, 2, 3, 4, 5, 6, 3));

            //ex5
            //if (neighbour(4,1,2,3,4,5,4))
            //{
            //    Console.WriteLine("Yuppy its greater than neighbours");
            //}
            //else
            //{
            //    Console.WriteLine("Oh shit neighbour(s) are greater");
            //}
            Console.ReadLine();
        }        
    }
}
