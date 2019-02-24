//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Exercises
//{
//    class Chapter10
//    {
//        #region DoneSolns
//        static char[,] lab =
//        {
//            {' ', ' ', ' ', '*', ' ', ' ', ' '},
//            {'*', '*', ' ', '*', ' ', '*', ' '},
//            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
//            {' ', '*', '*', '*', '*', '*', ' '},
//            {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
//        };
//        private static void FindPath(int row,int col)
//        {
//            if ((col < 0) || (row < 0) || (col >= lab.GetLength(1)) || (row >= lab.GetLength(0))){
//                return;
//            }
//            if (lab[row, col] == 'e')
//            {
//                Console.WriteLine("Found the exit!");
//            }
//            if(lab[row,col]!=' ')
//            {
//                return;
//            }
//            lab[row, col] = 's';
//            FindPath(row, col - 1);
//            FindPath(row - 1, col);
//            FindPath(row + 1, col);
//            FindPath(row, col + 1);

//            lab[row, col] = ' ';
//        }
//        private static long fibonacci(int n)
//        {
//            if (0 == numbers[n])
//            {
//                numbers[n] = fibonacci(n - 2) + fibonacci(n - 1);
//            }
//            return numbers[n];
//        }
//        static long[] numbers;
//        static int numberOfLoops, numberOfIterations;
//        static int[] loops;
//        private static void NestedLoops(int currentLoop)
//        {
//            if (currentLoop == numberOfLoops)
//            {
//                PrintLoops();
//                return;
//            }
//            for (int i = 1; i <= numberOfIterations; i++)
//            {
//                loops[currentLoop] = i;
//                NestedLoops(currentLoop + 1);
//            }
//        }
//        private static void PrintLoops()
//        {
//            for (int i = 0; i < numberOfLoops; i++)
//            {
//                Console.Write(loops[i]);               
//            }
//            Console.WriteLine();
//        }

//        #endregion
//        static string[] words = new string[] { "test", "rock", "fun"};
//        static readonly int k = 2;
//        static int[] holder = new int[k];
//        static bool flag = true;
//        private static void GenerateSubsets(int initializer)
//        {
//            if (initializer == k)
//            {
//                //PrintWords();
//                PrintWords5();
//                return;
//            }
//            for (int i = 0; i < words.Length; i++)
//            {
//                holder[initializer] = i;
//                GenerateSubsets(initializer + 1);
//            }
//        }
//        private static void PrintWords()
//        {            
//            if (holder[0] < holder[1])
//            {
//                Console.Write("({0} {1}), ", words[holder[0]], words[holder[1]]);
//            }
//        }
//        private static void PrintWords5()
//        {
//            //prints (test),(rock),(fun)
//            if (holder[1] == 0)
//            {
//                Console.WriteLine("({0}),", words[holder[0]]);
//            }
//            //prints (test rock), (test fun), (rock fun)
//            if (holder[0] < holder[1])
//            {
//                Console.Write("({0} {1}), ", words[holder[0]], words[holder[1]]);
//            }

//            if (flag)
//            {
//                Console.Write("(");
//                for (int i = 0; i < words.Length; i++)
//                {
//                    Console.Write(words[i] + " ");
//                }
//                Console.Write("),");
//                flag = false;
//            }

//        }
//        public static void Main(String[] args)
//        {
//            #region Done Exercises
//            //Console.WriteLine("Please enter a number for fibonacci");
//            //int n = int.Parse(Console.ReadLine());

//            //numbers = new long[n + 2];
//            //numbers[1] = 1;
//            //numbers[2] = 1;
//            //long result = fibonacci(n);
//            //Console.WriteLine("Fibonacci for {0} is {1}", n, result);
//            //FindPath(0, 0);

//            //numberOfLoops = 2;
//            //numberOfIterations = 4;
//            //loops = new int[numberOfLoops];

//            //ex 1
//            //NestedLoops(0);

//            //ex 4

//            GenerateSubsets(0);
//            #endregion


//            Console.ReadLine();
//        }
//    }
//}
