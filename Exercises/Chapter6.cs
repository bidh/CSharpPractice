//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Exercises
//{
//    class Chapter6
//    {
//        public static void Main(String[] args)
//        {
//            Console.WriteLine(typeof(Chapter6).Name);
//            //new Exercise1().Worker();
//            //new Exercise2().Worker();
//            //new Exercise3().Worker();
//            //new Exercise4().Worker();
//            //new Exercise5().Worker();
//            //new Exercise6().Worker();
//            Console.ReadLine();
//        }        
//    }
//    class Exercise1
//    {
//        public void Worker()
//        {
//            Console.WriteLine("Please enter a number.");
//            int threshold = int.Parse(Console.ReadLine());
//            for (int i = 1; i <= threshold; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }        
//    }
//    class Exercise2
//    {
//        public void Worker()
//        {
//            Console.WriteLine("Please enter a number.");
//            int threshold = int.Parse(Console.ReadLine());

//            for (int i = 1; i <= threshold; i++)
//            {
//                if(i%(3*7) == 0)
//                {
//                    continue;
//                }
//                Console.WriteLine(i);
//            }
//        }
//    }
//    class Exercise3
//    {
//        public void Worker()
//        {
//            int[] myarray = new int[10];
//            Console.WriteLine("Please enter 10 numbers");
//            for (int i = 0; i < myarray.Length; i++)
//            {
//                myarray[i] = int.Parse(Console.ReadLine());
//            }
//            Console.WriteLine("Mininum "+myarray.Min());
//            Console.WriteLine("Maximum "+myarray.Max());
//        }
//    }
//    class Exercise4
//    {
//        public void Worker()
//        {
//            string[] NumberOfCards = new string[13] { "2","3","4","5","6","7","8","9","10","J","Q","K","A"};
//            string[] NumberOfSuits = new string[4] {"club","spades","diamond","heart"};

//            for(int i = 0; i < NumberOfSuits.Length; i++)
//            {
//                for (int j = 0; j < NumberOfCards.Length; j++)
//                {
//                    switch (NumberOfSuits[i])
//                    {
//                        case "club":
//                            switch (NumberOfCards[j])
//                            {
//                                case "2": Console.WriteLine("Club of 2");break;
//                                case "3": Console.WriteLine("Club of 3");break;
//                                case "4": Console.WriteLine("Club of 4");break;
//                                case "5": Console.WriteLine("Club of 5");break;
//                                case "6": Console.WriteLine("Club of 6");break;
//                                case "7": Console.WriteLine("Club of 7");break;
//                                case "8": Console.WriteLine("Club of 8");break;
//                                case "9": Console.WriteLine("Club of 9");break;
//                                case "10": Console.WriteLine("Club of 10");break;
//                                case "J": Console.WriteLine("Club of J");break;
//                                case "Q": Console.WriteLine("Club of Q");break;
//                                case "K": Console.WriteLine("Club of K");break;
//                                case "A": Console.WriteLine("Club of A");break;                                
//                            }
//                            break;
//                        case "spades":
//                            switch (NumberOfCards[j])
//                            {
//                                case "2": Console.WriteLine("Spades of 2"); break;
//                                case "3": Console.WriteLine("Spades of 3"); break;
//                                case "4": Console.WriteLine("Spades of 4"); break;
//                                case "5": Console.WriteLine("Spades of 5"); break;
//                                case "6": Console.WriteLine("Spades of 6"); break;
//                                case "7": Console.WriteLine("Spades of 7"); break;
//                                case "8": Console.WriteLine("Spades of 8"); break;
//                                case "9": Console.WriteLine("Spades of 9"); break;
//                                case "10": Console.WriteLine("Spades of 10"); break;
//                                case "J": Console.WriteLine("Spades of J"); break;
//                                case "Q": Console.WriteLine("Spades of Q"); break;
//                                case "K": Console.WriteLine("Spades of K"); break;
//                                case "A": Console.WriteLine("Spades of A"); break;
//                            }
//                            break;

//                        case "diamond":
//                            switch (NumberOfCards[j])
//                            {
//                                case "2": Console.WriteLine("diamond of 2"); break;
//                                case "3": Console.WriteLine("diamond of 3"); break;
//                                case "4": Console.WriteLine("diamond of 4"); break;
//                                case "5": Console.WriteLine("diamond of 5"); break;
//                                case "6": Console.WriteLine("diamond of 6"); break;
//                                case "7": Console.WriteLine("diamond of 7"); break;
//                                case "8": Console.WriteLine("diamond of 8"); break;
//                                case "9": Console.WriteLine("diamond of 9"); break;
//                                case "10": Console.WriteLine("diamond of 10"); break;
//                                case "J": Console.WriteLine("diamond of J"); break;
//                                case "Q": Console.WriteLine("diamond of Q"); break;
//                                case "K": Console.WriteLine("diamond of K"); break;
//                                case "A": Console.WriteLine("diamond of A"); break;
//                            }
//                            break;

//                        case "heart":
//                            switch (NumberOfCards[j])
//                            {
//                                case "2": Console.WriteLine("heart of 2"); break;
//                                case "3": Console.WriteLine("heart of 3"); break;
//                                case "4": Console.WriteLine("heart of 4"); break;
//                                case "5": Console.WriteLine("heart of 5"); break;
//                                case "6": Console.WriteLine("heart of 6"); break;
//                                case "7": Console.WriteLine("heart of 7"); break;
//                                case "8": Console.WriteLine("heart of 8"); break;
//                                case "9": Console.WriteLine("heart of 9"); break;
//                                case "10": Console.WriteLine("heart of 10"); break;
//                                case "J": Console.WriteLine("heart of J"); break;
//                                case "Q": Console.WriteLine("heart of Q"); break;
//                                case "K": Console.WriteLine("heart of K"); break;
//                                case "A": Console.WriteLine("heart of A"); break;
//                            }
//                            break;

//                        default: Console.WriteLine("default");break;
//                    }
                        
//                }
//            }
//        }
//    }
//    class Exercise5
//    {
//        public void Worker()
//        {
//            Console.WriteLine("Please enter a number.");
//            int threshold = int.Parse(Console.ReadLine());
//            int oldstate = 0;
//            int newstate = 0;
//            int holder = 0;
//            for (int i = 0; i < threshold; i++)
//            {
//                if (i == 0)
//                {
//                    Console.WriteLine(i);
//                    continue;
//                }
//                else if(i==1)
//                {
//                    Console.WriteLine(i);
//                    newstate = 1;
//                    continue;
//                }
//                else
//                {
//                    holder = newstate;
//                    newstate += oldstate;
//                    Console.WriteLine(newstate);
//                    oldstate = holder;
//                }
//            }            
//        }
//    }
//    class Exercise6
//    {
//        public void Worker()
//        {
//            Console.WriteLine("Enter 2 numbers K and N sequentially. K should be smaller than N but bigger than 1");
//            Console.WriteLine("Like (1<K<N)");
//            int K = int.Parse(Console.ReadLine());
//            int N = int.Parse(Console.ReadLine());
//            if(1<K && K < N)
//            {
//                int KF=1, NF = 1;
//                for(int i = 0; i < K; i++)
//                {
//                    KF *= K - i;
//                }
//                for (int i = 0; i < N; i++)
//                {
//                    NF *= N - i;
//                };
//                Console.WriteLine("N! = " + NF);
//                Console.WriteLine("K! = " + KF);
//                Console.WriteLine("N1/K! = "+(NF/KF));
//            }
//            else
//            {
//                Console.WriteLine("Condition not meet");
//            }
//        }
//    }
//}
