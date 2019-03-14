#if RemoveToRun
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class ConditionalStatements
    {
        private static void ExchangeTwoNums(int a, int b)
        {
            int c = a;
            if (a > b)
            {
                a = b;
                Console.WriteLine($"Swaped from a={c} to a={a}");
            }
        }

        private static void BiggestAmongThreeNums(int a,int b,int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a is greatest");
                }
                else
                {
                    Console.WriteLine("c is greatest");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("b is greatest");
                }
                else
                {
                    Console.WriteLine("c is greatest");
                }
            }
        }

        private static void DescendingOrder(int a,int b,int c)
        {
            int temp=0;
           
            if(b>a && b > c)
            {
                temp = a;
                a = b;
                b = temp;            
            }
            else if(c>a && c>b)
            {
                temp = a;
                a = c;
                c = temp;
            }

            if (c > b)
            {
                temp = b;
                b = c;
                c = temp;
            }

            Console.WriteLine($"a={a}, b={b}, c={c}");
        }

        private static void IncreaseOneOrMultiply(object input)
        {
            var result = input.GetType();
        
            if (result.Equals(typeof(Int32)) || result.Equals(typeof(Double)))
            {
                var output = (int)input + 1;
                Console.WriteLine(output);
            }
            else if(result.Equals(typeof(String)))
            {
                var output = (string)input + "*";
                Console.WriteLine(output);
            }
        }

        private static void SubsetEqualsFive(int a, int b, int c,int d,int e,int f)
        {
            int[] arr = new int[] { a, b, c, d, e,f};
            const int THRESHOLD = 0;           
            
            for(int i = 0; i < arr.Length; i++)
            {
                string subset = string.Empty;
                int sum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    subset += arr[j]+" ";
                    if (sum == THRESHOLD)
                    {
                        Console.WriteLine($"subset found {subset}");                        
                    }                    
                }

            }
        }

        private static int BonusPoints(int input)
        {
            if(input >=1 && input <= 3)
            {
                return input * 10;
            }
            else if(input >=4 && input <= 6)
            {
                return input * 100;
            }
            else if(input >=7 && input <=9)
            {
                return input * 1000;
            }
            else
            {
                return 0;
            }
        }

        private static HashSet<int> fixedNums = new HashSet<int>
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,30,40,50,60,70,80,90
        };
        private static string ConvertFixedNumbers(int number)
        {
            string words = string.Empty;

            switch (number)
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
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "ninteen";
                case 20: return "twenty";
                case 30: return "thirty";
                case 40: return "fourty";
                case 50: return "fifty";
                case 60: return "sixty";
                case 70: return "seventy";
                case 80: return "eighty";
                case 90: return "ninety";
                default: return "invalid";
            }
        }
        private static string ConvertTwoDigit(int a,int b)
        {
            return $"{ConvertFixedNumbers(a)} {ConvertFixedNumbers(b)}";
        }
        private static string ConvertNumsToWords(int number)
        {
            string words = string.Empty;
            if (!fixedNums.Contains(number)){
                var result = number.ToString().ToCharArray();
                if (result.Length == 2)
                {
                    int first = int.Parse(result[0].ToString() + "0");
                    int second = int.Parse(result[1].ToString());
                    words = ConvertTwoDigit(first,second);
                }
                else if (result.Length == 3)
                {
                    words = ConvertFixedNumbers(int.Parse(result[0].ToString()))+" hundred ";
                    int second = int.Parse(result[1].ToString() + "0");
                    int third = int.Parse(result[2].ToString());
                    words += ConvertTwoDigit(second, third);
                }
                else
                {
                    words = "un recognizable";
                }
            }
            else
            {
                words= ConvertFixedNumbers(number);
            }
            return words;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(typeof(ConditionalStatements).Name);
            //ExchangeTwoNums(7, 6);
            //BiggestAmongThreeNums(7, 5, 4);
            //DescendingOrder(4, 6, 5);
            //DescendingOrder(4, 5, 6);
            //IncreaseOneOrMultiply(2);
            //IncreaseOneOrMultiply("hello");
            //SubsetEqualsFive(3,-2,1,1,8,-8);

            //int result = BonusPoints(5);
            //if (result == 0)
            //{
            //    Console.WriteLine("Error");
            //}
            //else
            //{
            //    Console.WriteLine(result);
            //}            
            Console.WriteLine("Enter any number from 0-999");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertNumsToWords(input));
            Console.ReadLine();
        }
    }
}
#endif