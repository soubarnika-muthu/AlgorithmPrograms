using System;
using System. IO;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\hp\source\repos\AlgorithmPrograms\AlgorithmPrograms\TextFile.txt";
            string text = File.ReadAllText(filepath);
            string[] textArray = text.Split(" ");
            Console.WriteLine("Implementation of Algorithm Programs ");
            Console.WriteLine("1.Permutation of string");
            Console.WriteLine("2.Binary search for word");
            Console.WriteLine("3.Insertion Sort");
            Console.WriteLine("4.Bubble Sort");
            Console.WriteLine("5.Exit");
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
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.Sort(textArray);
                    insertionSort.Display(textArray);
                    break;
                case 4:
                    int[] intArray = { 45,67,21,99,54,6 };
                    BubbleSort bubbleSort = new BubbleSort();
                    intArray = bubbleSort.Sort(intArray);
                    bubbleSort.Display(intArray);
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("enter valid choice");
                    break;
            }
            Console.Read();
        }
    }
}
