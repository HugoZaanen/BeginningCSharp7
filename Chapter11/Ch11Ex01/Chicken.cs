using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex01
{
    class Chicken : Animal
    {
        public void Milk() => Console.WriteLine($"{name} has been milked.");
        public Chicken(string newName) : base(newName) { }
    }
}
