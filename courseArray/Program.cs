using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 3, 4 };
            //Course[] courses =
            //{
            //    new Course{Id=1,Name="C++", fees=3500},
            //    new Course{Id=2,Name="C#", fees=18000},
            //    new Course{Id=3,Name="React", fees=15000},
            //    new Course{Id=4,Name="Python", fees=13000},
            //};
            //foreach(Course c in courses)
            //{
            //    Console.WriteLine(c);
            //}

            int[] nums= {1,2,3,4,5};
            Department[] departments =
            {
                new Department{Id=1,Name="Mechanical", Location="pune"},
                new Department{Id=2,Name="civil", Location="kothrud"},
                new Department{Id=3,Name="E&Tc" ,Location="sangli"},
                new Department{Id=4,Name="comp", Location="mumbai"},
                new Department{Id=5,Name="IT" ,Location="nashik"},
            };
            foreach (Department d in departments)
            {
                Console.WriteLine(d);
            }
        }
    }
}
