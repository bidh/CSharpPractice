#if RemoveToRun
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class DictionariesHasTablesSets
    {
        #region Exercise1
        private static void Exercise1()
        {
            int[] array = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            SortedDictionary<int, int> dic = new SortedDictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (dic.TryGetValue(array[i], out int value))
                {
                    dic[array[i]] = value + 1;
                }
                else
                {
                    dic.Add(array[i], 1);
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + "---" + item.Value);
            }
        }
        #endregion
        private static void Exercise2()
        {
            int[] array = new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {

                if (dic.TryGetValue(array[i], out int value))
                {
                    dic[array[i]] = value + 1;
                }
                else
                {
                    dic.Add(array[i], 1);
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (dic[array[i]] % 2 == 0)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }

        private static void Exercise3()
        {
            StreamReader reader = new StreamReader("../../Files/Words.txt");
            Dictionary<string, int> keyValues = new Dictionary<string, int>();
            using (reader)
            {
                string text = reader.ReadLine();
                char[] splits = { ' ', '.', ',', '–', '!', '?' };

                string[] words = text.Split(splits, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    string item = word.ToLower();
                    if (keyValues.TryGetValue(item, out int value))
                    {
                        keyValues[item] = value + 1;
                    }
                    else
                    {
                        keyValues.Add(item, 1);
                    }
                }

                var result = keyValues.OrderBy(x => x.Value);

                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Key} --> {item.Value}");
                }

            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(typeof(DictionariesHasTablesSets).Name);
            Exercise3();
            Console.ReadLine();
        }
    }
}

#endif