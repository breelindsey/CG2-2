using System;

namespace CG2_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("This program will calculate the area of a rectangle for you.");
            Console.Write("Enter the length of side A: ");
            string sideA = Console.ReadLine();
            Console.Write("Enter the length of the side B: ");
            string sideB = Console.ReadLine();

            int sideAnumber = int.Parse(sideA);
            int sideBnumber = int.Parse(sideB);

            int area = sideAnumber * sideBnumber;

            Console.WriteLine("The area of the rectangle is:" + area);
            Console.ReadLine();
        }
    }
}
