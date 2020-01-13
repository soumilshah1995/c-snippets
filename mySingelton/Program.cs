using System;

namespace mySingelton
{

    class Foo{
        private Foo(){}
        
        private static Foo _instance;

        public static Foo getInstance()
        {
            if(_instance == null)
            {
                _instance = new Foo();
            }
            
            return _instance;
            
        }

        public void SomeFunc()
        {
            System.Console.WriteLine("Some code ");
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Foo obj  = Foo.getInstance();
            obj.SomeFunc();

        }
    }
}
