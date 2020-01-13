using System;
using Newtonsoft.Json;

namespace objtojson
{
    class Person{
        public string FirstName 
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public Dates dates
        {
            get;
            set;
        }


    }

    class Dates
    {
        public string Birthday
        {
            get;
            set;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            var obj = new Person{
                FirstName = "Soumil",
                LastName = "Shah",
                dates = new Dates
                {
                    Birthday = "12/08/1995"
                }
            };
  
            var jsonString = JsonConvert.SerializeObject(obj);
            System.Console.WriteLine(jsonString);
            
            System.Console.WriteLine("=========");
            
            dynamic json  = JsonConvert.DeserializeObject(jsonString);
            System.Console.WriteLine(json);
        }
    }
}
