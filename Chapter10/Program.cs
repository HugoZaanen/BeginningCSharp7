using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter10
{
    class Program
    {
        public static void Main(String[] args)
        {
            WriteLine("Creating object myObj...");
            MyClass myObj = new MyClass("My Object");
            WriteLine("myObj created");
            for(int i = -1; i <= 0;i++)
            {
                try
                {
                    WriteLine($"\nAttempting to assign {i} to myObj.Val");
                    myObj.Val = i;
                    WriteLine($"Value {myObj.Val} assigned to myObj.Val.");
                }
                catch(Exception e)
                {
                    WriteLine($"Exception {e.GetType().FullName} thrown");
                    WriteLine($"Value {myObj.Val} assigned to myObj.Val.");
                }
            }
            WriteLine("\nOutputting myObj.TiString()...");
            WriteLine(myObj.ToString());
            WriteLine("myObj.ToString() Output");
            WriteLine("\nmydoubleIntProp = 5");
            WriteLine($"getting myDoubleIntProp of 5 is {myObj.myDoubledIntProp}");
            ReadKey();
        }
    }
}
