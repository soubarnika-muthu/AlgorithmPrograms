using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of Algorithm Programs ");
            Console.WriteLine("1.Permutation of string");
            Console.WriteLine("2.Exit");
            Console.Write("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Permutation permutation = new Permutation();
                    Console.WriteLine("Permuations of given string are:");
                    String str = "ABC";
                    int n = str.Length;
                    permutation.Permute(str, 0, n - 1);
                    break;

               

                case 2:
                    break;
            }
            Console.Read();
        }
    }
}
