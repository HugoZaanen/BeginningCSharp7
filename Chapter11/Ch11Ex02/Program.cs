﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex02
{
    class Program
    {
        public static void Main(string[] args)
        {
            Animals animalCollection = new Animals();
            animalCollection.Add(new Cow("Donna"));
            animalCollection.Add(new Chicken("Mary"));
            foreach(Animal myAnimal in animalCollection)
            {
                myAnimal.Feed();
            }
            Console.ReadKey();
        }
    }
}
