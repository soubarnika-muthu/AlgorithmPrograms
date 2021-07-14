using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of Algorithm Programs ");
            Console.WriteLine("1.Permutation of strings");
            Permutation permutation = new Permutation();
            String str = "ABC";
            int n = str.Length;
            permutation.Permute(str, 0, n - 1);
        }
    }
}
