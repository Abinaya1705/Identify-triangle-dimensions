using System;

namespace Identify_triangle_dimensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            do
            {
                Console.WriteLine("Choose your Option : ");
                Console.WriteLine("1. Enter Triangle Dimension\n2. Exit\n");
                option = Console.ReadLine();
                if (option == "1")
                {
                    Console.Write("a:");
                    var a= Convert.ToInt32(Console.ReadLine());
                    Console.Write("b:");
                    var b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("c:");
                    var c = Convert.ToInt32(Console.ReadLine());
                    var Result = TriangleSolver.Analyze(a, b, c);
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

