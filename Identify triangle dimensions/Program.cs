using System;

namespace Identify_triangle_dimensions
{
    class Program
    {
        public static void Main(string[] args)
        {
            string option;
            do
            {
                Console.WriteLine("Choose your Option : ");
                Console.WriteLine("1. Enter Triangle Dimension\n2. Exit\n");
                option = Console.ReadLine();
                if (option == "1")
                {
                    Console.Write("Side 1 :");
                    var side1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Side 2 :");
                    var side2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Side 3 :");
                    var side3 = Convert.ToInt32(Console.ReadLine());
                    var Result = Triangle_solver.Analyze(side1, side2, side3);
                    Console.WriteLine(Result);
                }
                if(option == "2")
                {
                    Environment.Exit(1);
                }
            } while (option != "2");
            Console.ReadKey();
        }

    }
}

