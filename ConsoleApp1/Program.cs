using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void mydel(string name);
    //public delegate int mydel(int n1, int n2);
    //public class calculator
    //{
    //    public int Add(int a,int b)
    //    {
    //        return a + b;
    //    }
    //    public int Sub(int a, int b)
    //    {
    //        return a - b;
    //    }
    //    public int product(int a, int b)
    //    {
    //        return a * b;
    //    }
    //}
    public class name
    {
        
        public void name1(string a)
        {
            
           Console.WriteLine(a.ToLower());
        }
        public void name2(string b)
        {
            Console.WriteLine(b.ToUpper());
        }
    }
    internal class Program
    { 
        static void Main(string[] args)

        {
            //calculator c=new calculator();
            //mydel del = new mydel(c.Add);
            //int sum = del.Invoke(20, 30);
            //Console.WriteLine(sum);

            //calculator c=new calculator();
            //mydel del = new mydel(c.Add);
            //del += new mydel(c.Sub);
            //del += new mydel(c.product);
            //Delegate[] list = del.GetInvocationList();
            //foreach(Delegate d in list)
            //{
            //    Console.WriteLine(d.Method);
            //    Console.WriteLine(d.DynamicInvoke(12, 30));
            //}

            name n = new name();
            mydel del = new mydel(n.name1);
            del+= new mydel(n.name2);
            Delegate[] list= del.GetInvocationList();
            foreach(Delegate a in list)
            {
                Console.WriteLine(a.DynamicInvoke("Rahul"));
            }
          
             
            
          














        }
    }
}
