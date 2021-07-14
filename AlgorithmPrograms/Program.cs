using System;
using System. IO;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of Algorithm Programs ");
            Console.WriteLine("1.Permutation of string");
            Console.WriteLine("2.Binary search for word");
            Console.WriteLine("3.Exit");
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
                    string filepath = @"C:\Users\hp\source\repos\AlgorithmPrograms\AlgorithmPrograms\TextFile.txt";
                    string text = File.ReadAllText(filepath);
                    string[] textArray = text.Split(" ");
                    BinarySearchWord Search = new BinarySearchWord(textArray);
                    Console.WriteLine("Enter the word to search:");
                    string searchElement = Console.ReadLine();
                    int found = Search.binarysearch(textArray,searchElement);
                    if (found == -1)
                    {
                        Console.WriteLine("element is not found");
                    }
                    else
                    {
                        Console.WriteLine("The Element {0} is Present", searchElement);
                    }
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("enter valid choice");
                    break;
            }
            Console.Read();
        }
    }
}
