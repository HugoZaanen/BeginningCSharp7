﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ch11Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(new Person("Raul", 30));
            list.Add(new Person("Donna", 25));
            list.Add(new Person("Mary", 27));
            list.Add(new Person("Ben", 44));
            Console.WriteLine("unsorted people: ");
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{(list[i] as Person).Name} ({(list[i] as Person).Name})");
            }
            Console.WriteLine();
            Console.WriteLine(
                "People sorted with default comparer (by age):");
            list.Sort();
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{(list[i] as Person).Name} ({(list[i] as Person).Age})");
            }
            Console.WriteLine();
            Console.WriteLine(
                "People sorted with nondefualt comparer (by name):");
            list.Sort(PersonComparerName.Default);
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{(list[i] as Person).Name}({(list[i] as Person).Age})");
            }
            Console.ReadKey();
        }
    }
}
