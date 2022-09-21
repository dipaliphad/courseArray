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
            int[] nums = { 1, 2, 3, 4 };
            Course[] courses =
            {
                new Course{Id=1,Name="C++", fees=3500},
                new Course{Id=2,Name="C#", fees=18000},
                new Course{Id=3,Name="React", fees=15000},
                new Course{Id=4,Name="Python", fees=13000},
            };
            foreach(Course c in courses)
            {
                Console.WriteLine(c);
            }
        }
    }
}
