using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Chapter19
    {
        public static void GeneratingSubsetsV1()
        {
            string[] words = { "ocean", "beer", "money", "happiness" };

            Queue<HashSet<string>> subsetsQueue = new Queue<HashSet<string>>();
            HashSet<string> emptySet = new HashSet<string>();
            subsetsQueue.Enqueue(emptySet);
            while (subsetsQueue.Count > 0)
            {
                HashSet<string> subset = subsetsQueue.Dequeue();
                Console.Write("{");
                foreach (string word in subset)
                {
                    Console.Write($"{word} ");
                }
                Console.Write("}");
                Console.WriteLine();

                foreach (string element in words)
                {
                    if (!subset.Contains(element))
                    {
                        HashSet<string> newSubset = new HashSet<string>();
                        newSubset.UnionWith(subset);
                        newSubset.Add(element);
                        subsetsQueue.Enqueue(newSubset);
                    }
                }
            }
        }
        static string[] words = { "ocean", "beer", "money", "happiness" };
        public static void GeneratingSubsetsV2()
        {
            Queue<List<int>> subsetsQueue = new Queue<List<int>>();
            List<int> emptyList = new List<int>();
            subsetsQueue.Enqueue(emptyList);
            while (subsetsQueue.Count > 0)
            {
                List<int> subset = subsetsQueue.Dequeue();
                Print(subset);
                int start = -1;
                if (subset.Count > 0)
                {
                    start = subset[subset.Count - 1];
                }
                for (int i = start+1; i < words.Length; i++)
                {
                    List<int> newSubset = new List<int>();
                    newSubset.AddRange(subset);
                    newSubset.Add(i);
                    subsetsQueue.Enqueue(newSubset);
                }
            }
        }
        static void Print(List<int> subset)
        {
            Console.Write("[ ");
            for (int i = 0; i < subset.Count; i++)
            {
                int index = subset[i];
                Console.Write("{0} ", words[index]);
            }
            Console.WriteLine("]");
        }

        class Student:IComparable<Student>
        {
            private readonly string _firstName;
            private readonly string _lastName;

            public Student(string firstName,string lastName)
            {
                _firstName = firstName;
                _lastName = lastName;
            }
            //CompareTo is invoked when the sort function is called
            //due to IComparable<Student>
            public int CompareTo(Student student)
            {
                int result = _lastName.CompareTo(student._lastName);
                if (result == 0)
                {
                    result = _firstName.CompareTo(student._firstName);
                }
                return result;
            }
            public override string ToString()
            {
                return _firstName+" "+_lastName;
            }
        }
        static void CoursesStudents()
        {
            Dictionary<string, List<Student>> courses = new Dictionary<string, List<Student>>();
            StreamReader reader = new StreamReader("../../Files/Courses.txt");
            using (reader)
            {                
                while (reader.Peek() >= 0)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        return;
                    }
                    string[] entry = line.Split('|');
                    string firstName = entry[0].Trim();
                    string lastName = entry[1].Trim();
                    string course = entry[2].Trim();
                    List<Student> students;
                    //if there does not exist the course then create new one
                    if (! courses.TryGetValue(course,out students)){
                        students = new List<Student>();
                        courses.Add(course, students);
                    }
                    Student student = new Student(firstName, lastName);
                    students.Add(student);                   
                }
            }
            foreach (string c in courses.Keys)
            {
                Console.WriteLine("Course " + c + ":");
                List<Student> stds = courses[c];
                stds.Sort();
                foreach (var std in stds)
                {
                    Console.WriteLine("\t{0}", std);
                }
            }
        }

        static void PhoneBook()
        {
            SortedDictionary<string, SortedDictionary<string, string>> phoneBook =
                new SortedDictionary<string, SortedDictionary<string, string>>();

            StreamReader reader = new StreamReader("../../Files/Phonebook.txt");

            while (reader.Peek() >= 0)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    return;
                }
                string[] entry = line.Split('|');
                string name = entry[0];
                string city = entry[1];
                string phone = entry[2];

                SortedDictionary<string, string> value;
                if(! phoneBook.TryGetValue(city,out value))
                {
                    value = new SortedDictionary<string, string>();
                    phoneBook.Add(city, value);
                }
                value.Add(name,phone);                
            }
            foreach (var pB in phoneBook)
            {
                Console.WriteLine($"City: {pB.Key}");
                foreach (var value in pB.Value)
                {
                    Console.WriteLine($"{value.Key}:{value.Value}");
                }
            }
        }
        public static void Main(string[] args)
        {
            //GeneratingSubsetsV1();
            //GeneratingSubsetsV2();
            //CoursesStudents();
            //PhoneBook();
            Console.ReadLine();
        }        
    }
}
