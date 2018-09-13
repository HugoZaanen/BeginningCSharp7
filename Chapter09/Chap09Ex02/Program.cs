using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Ch09ClassLib;
namespace Chap09Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            MyExternalclass myObj = new MyExternalclass();
            WriteLine(myObj.ToString());
            ReadKey();
        }
    }
}
