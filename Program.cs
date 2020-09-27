using System;

namespace c_windowfrom1
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[] arrString;
            int value = 5;
            System.Console.WriteLine($"Value before {value}");
            increase(ref value);
            System.Console.WriteLine($"Value after {value}" );
            swap();
            System.Console.WriteLine("Print Array");
            int [] arr = new int[]{1,2,3,4,5};
            arrString = new string[6];
            if(5>6){

            }
            arrString[0] = "dser";
            System.Console.ReadKey();
        }
        static void swap(){
            int b = 6;
            increase(ref b);
            System.Console.WriteLine($"value from swap {b}");
            
        }
        static void increase(ref int a){
            a++;
        }
    }
}
