#if RemoveToRun
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Animal
    {
        public virtual void Print()
        {
            Console.WriteLine("This is animal");
        }
    }
    class Lion : Animal
    {
        public override void Print()
        {
            Console.WriteLine("This is Lion");
            base.Print();
        }
    }
    abstract class Bird
    {
        protected abstract void Print();

        private void OMG()
        {
            Console.WriteLine("OMG");
        }
    }
    class Pigeon : Bird
    {
        protected override void Print()
        {
            throw new NotImplementedException();
        }
    }

    //using polymorphism
    public abstract class Mammal
    {
        public void PrintInformation()
        {
            Console.WriteLine($"I am a {GetType().Name}");
            Console.WriteLine(GetTypicalSound());
        }
        protected abstract string GetTypicalSound();
    }
    public class HumanBeing : Mammal
    {
        protected override string GetTypicalSound()
        {
            return "I will rise some day because I work hard";
        }
    }

    class checkingOverride
    {
        string _firstName, _lastName;
        public checkingOverride(string firstname, string lastname)
        {
            _firstName = firstname;
            _lastName = lastname;
        }
        public override string ToString()
        {
            return $"{_firstName} ||| {_lastName}";
        }
    }
    class OOP
    {
        public static void Main(string[] args)
        {
            //Mammal humanBeing = new HumanBeing();
            //humanBeing.PrintInformation();
            Console.WriteLine(new checkingOverride("Biraj", "Dhakal"));
            Console.ReadLine();
        }
    }
}
#endif