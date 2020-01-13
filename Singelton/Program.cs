using System;

namespace Singelton
{

    public class Person{

        public string Name{
            get;
            set;
        }

        public int Age 
        {
            get;
            set;

        }


        public Person(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
            System.Console.WriteLine("Base class Constructor ........");
        }


    }


    public class Students:Person
    {
        public int ID {
            get;
            set;
        }
       public Students(string name, int age , int id):base(name, age)
       {
           this.ID = id;
           System.Console.WriteLine("Child class ......");

       }

       public void introduce()
       {
           System.Console.WriteLine("Hi ! I am Student my name is {0} and age is {1} an ID {2}", Name, Age, ID);
       }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // var p1 = new Person("Soumil", 24);
            var s1 = new Students("Soumil", 24, 1031686);
            s1.introduce();

        }
    }
}
