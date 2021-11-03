using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Double SideA = 0;
            Double SideB = 0;
            Double SideC = 0;
            Double S = 0;
            Double Area = 0;
            Console.WriteLine("Please enter the length of the first side");
            SideA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the length of the second side");
            SideB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the length of the final side");
            SideC = Convert.ToDouble(Console.ReadLine());
            S = (SideA + SideB + SideC) / 2;
            Area = Math.Sqrt(S * (S - SideA) * (S - SideB) * (S - SideC));
            Console.WriteLine("The area of this triangle is {0}", Area);
            Console.ReadLine();




        }
    }
}
