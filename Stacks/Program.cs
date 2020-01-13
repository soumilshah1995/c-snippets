

using System;
using System.Collections.Generic;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var stack  = new Stacks<int>();
            stack.Add(1);
            stack.Add(2);
            stack.Add(3);
            stack.Add(4);
            stack.Add(5);

            System.Console.WriteLine(String.Format("Stack size {0}", stack.Size()));
            System.Console.WriteLine(String.Format("IS Empty Stack {0}", stack.isEmpty()));

            while(!stack.isEmpty())
            {
                System.Console.WriteLine(stack.Pop());
            }



        }
    }



        public class Stacks<T>
    {
        
        // STL Template 
        public List<T> Data;

        public Stacks(){
            this.Data = new List<T>();
        }

        public void Add(T elem){
            this.Data.Add(elem);
        
        }

        public int Size(){
            return this.Data.Count;
        }

        public bool isEmpty(){
            if(this.Size() == 0){
                return true;
            }else{
                return false;
            }
        }

        public T Pop(){
            /*
                Pop the Last item in Stack 
            */

            int index = this.Data.Count - 1;
            if (index < 0)
            {
                throw new InvalidOperationException("The stack is empty and there are no items to remove");
            }else{

                T item = this.Data[index];
                this.Data.RemoveAt(index);
                return item;
            }    
        }
        public T Peek(){
            /*
                Peek allows to get the last elements in stacks 
            */

            int index = this.Data.Count - 1;
            if (this.Data.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty !  ");

            }else{
                T tem = this.Data[index];
                return tem;
            }
        }

        public void print(){

            foreach(var x in this.Data){
                System.Console.WriteLine(x);
                System.Console.WriteLine("\n");
            }

        }


    }
}
