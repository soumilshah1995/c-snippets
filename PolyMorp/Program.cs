using System;
using System.Collections.Generic;


namespace PolyMorp
{

    public class Shape
    {
        public Shape()
        {
            System.Console.WriteLine("Shape  Constructor ..........");
        }

        // Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }

    class Circle : Shape
    {
        public Circle():base()
        {
            System.Console.WriteLine("Circle class Constructor ......");
        }

        public override void Draw()
        {
            // Code to draw a circle...
            Console.WriteLine("Drawing a circle");
            // base.Draw();
        }
    }

    public class Rectangle:Shape{
        public Rectangle()
        {
            System.Console.WriteLine("Rectangle class Constructor .........");
        }

        public override void  Draw()
        {
            System.Console.WriteLine("Drawing Rectangle .........");
        }

    }



    class Program
    {
        static void Main(string[] args)
        {

            // Condition for Polymorphism 
            //  It should be Base class
            // Method should be mark as virtual 
            // it should be overrided in Child Class 

            
           Shape f2 = new Circle();
           f2.Draw();


        }
    }
}
