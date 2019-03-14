#if RemoveToRun
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class LambdaAndLINQ
    {
        public LambdaAndLINQ()
        {
            Initialize();
        }

        private void Initialize()
        {
            //students.Add(new Student()
            //{
            //    FirstName = "John",
            //    LastName = "Stefens",
            //    Age = 15
            //});
            //students.Add(new Student()
            //{
            //    FirstName = "Rafi",
            //    LastName = "Jensen",
            //    Age = 16
            //});
            //students.Add(new Student()
            //{
            //    FirstName = "Peter",
            //    LastName = "Nielsen",
            //    Age = 17
            //});
            //students.Add(new Student()
            //{
            //    FirstName = "Lars",
            //    LastName = "Helemp",
            //    Age = 25
            //});
        }

        private class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }
        //List<Student> students = new List<Student>();
        private void lambdas()
        {
            //var result=students.OrderBy(x => x.FirstName);
            //var result1 = students.FindAll(x => x.Age > 15 && x.Age < 20);


        }

        private void takewhile()
        {
            string[] fruits = { "apple", "banana", "mango", "orange",
                      "passionfruit", "grape" };


            var query = fruits.TakeWhile(x => string.Compare(x, "orange", true) != 0);

            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }
        }

        class Package
        {
            public string Company { get; set; }
            public double Weight { get; set; }
            public long TrackingNumber { get; set; }
        }

        public static void ChangeToDictionary()
        {
            List<Package> packages =
                new List<Package>
                { new Package { Company = "Coho Vineyard", Weight = 25.2, TrackingNumber = 89453312L },
                  new Package { Company = "Lucerne Publishing", Weight = 18.7, TrackingNumber = 89112755L },
                  new Package { Company = "Wingtip Toys", Weight = 6.0, TrackingNumber = 299456122L },
                  new Package { Company = "Adventure Works", Weight = 33.8, TrackingNumber = 4665518773L }
                };

            var result = packages.ToDictionary(x => x.TrackingNumber);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} --> {item.Value.Company} {item.Value.Weight}");
            }
        }

        public static void Grouping()
        {
            List<Student> students = new List<Student>
            {
                new Student{ FirstName="Ram", LastName="Dahal", Age=12},
                new Student{ FirstName="Suraj", LastName="Acharya", Age=11},
                new Student{ FirstName="Hari", LastName="Dangol", Age=13},
                new Student{ FirstName="Shyam", LastName="Stha", Age=11},
                new Student{ FirstName="Biraj", LastName="Pariyar", Age=12},
                new Student{ FirstName="Anuj", LastName="Acharya", Age=13},
                new Student{ FirstName="Rita", LastName="Dhakal", Age=12},
                new Student{ FirstName="Gita", LastName="Rijal", Age=11},
            };

            var result = students.GroupBy(x => x.Age);

            foreach (var item in result)
            {
                Console.WriteLine(item.Key);

                foreach (var student in item)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                }
            }
        }

        class Department
        {
            public int DepartmentId { get; set; }
            public string Name { get; set; }
        }
        class Employee
        {
            public int EmployeeId { get; set; }
            public string EmployeeName { get; set; }
            public int DepartmentID { get; set; }
        }
        private static void EmpDept()
        {
            Employee emp1 = new Employee { EmployeeId = 1, EmployeeName = "Hari", DepartmentID = 101 };
            Employee emp2 = new Employee { EmployeeId = 2, EmployeeName = "Shyam", DepartmentID = 101 };
            Employee emp3 = new Employee { EmployeeId = 3, EmployeeName = "Suraj", DepartmentID = 101 };
            Employee emp4 = new Employee { EmployeeId = 4, EmployeeName = "Mohan", DepartmentID = 102 };
            Employee emp5 = new Employee { EmployeeId = 5, EmployeeName = "Dipen", DepartmentID = 102 };
            Employee emp6 = new Employee { EmployeeId = 6, EmployeeName = "Suman", DepartmentID = 102 };

            Department ITDepartment = new Department
            {
                DepartmentId = 101,
                Name = "IT"
            };
            Department AdminDepartment = new Department
            {
                DepartmentId = 102,
                Name = "Admin"
            };
            List<Department> departments = new List<Department> { ITDepartment, AdminDepartment };
            List<Employee> employees = new List<Employee> { emp1, emp2, emp3, emp4, emp5, emp6 };
            //var result = employees.Join(departments,                
            //    e=>e.DepartmentID,
            //    d=>d.DepartmentId,
            //    (e,d) => new  EmpDeptClass
            //    {
            //        Id=e.EmployeeId, Name=e.EmployeeName, Department=d.Name
            //    }).ToList();

            var result = departments.Join(employees,
                d => d.DepartmentId,
                e => e.DepartmentID,
                (d, e) => new EmpDeptClass
                {
                    Id = e.EmployeeId,
                    Name = e.EmployeeName,
                    Department = d.Name
                }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.Department + " " + item.Name + " " + item.Id);
            }
        }
        class EmpDeptClass
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
        }
        private static int factorial(int n)
        {
            if (n <= 0)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(typeof(LambdaAndLINQ).Name);
            //Grouping();
            //ChangeToDictionary();
            //EmpDept();
            Console.WriteLine(factorial(5));
            Console.ReadLine();
        }
    }
}
#endif