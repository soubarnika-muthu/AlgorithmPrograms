using System;
using System.IO;

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
            Console.WriteLine("5.Merge Sort");
            Console.WriteLine("6.Anagram");
            Console.WriteLine("7.PrimeNumbers");
            Console.WriteLine("8.PrimeNumbersPalindrome and Anagram");
            Console.WriteLine("9.Exit");
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
                    BinarySearchWord<string> Search = new BinarySearchWord<string>(textArray);
                    Console.WriteLine("Enter the word to search:");
                    string searchElement = Console.ReadLine();
                    int found = Search.binarysearch(textArray, searchElement);
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
                    InsertionSort<string> insertionSort = new InsertionSort<string>();
                    insertionSort.Sort(textArray);
                    insertionSort.Display(textArray);
                    break;
                case 4:
                    int[] intArray = { 45, 67, 21, 99, 54, 6 };
                    BubbleSort<int> bubbleSort = new BubbleSort<int>();
                    intArray = bubbleSort.Sort(intArray);
                    bubbleSort.Display(intArray);
                    break;
                case 5:
                    int start = 0;
                    int end = textArray.Length;
                    MergeSort<string> mergeSort = new MergeSort<string>();
                    mergeSort.mergeSort(textArray, start, end - 1);
                    mergeSort.Display(textArray);

                    break;
                case 6:
                    Anagram anagram = new Anagram();
                    Console.WriteLine("Enter two strings :");
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();

                    int result = anagram.CheckAnagram(str1.ToLower(), str2.ToLower());
                    if (result == 1)
                    {
                        Console.WriteLine("Two strings are anagram");
                    }
                    else
                    {
                        Console.WriteLine("the strings are not anagram");
                    }
                    break;
                case 7:
                    PrimeNumbers primeNumbers = new PrimeNumbers();
                    primeNumbers.PrintPrime();
                    primeNumbers.display();
                    break;
                case 8:
                    PrimeNumbers primeNumbers1 = new PrimeNumbers();
                    primeNumbers1.PrintPrime();
                    primeNumbers1.PrintPalindrome();
                    primeNumbers1.CheckAnagramPrime();
                    break;
                case 9:
                    break;
                default:
                    Console.WriteLine("enter valid choice");
                    break;
            }
            Console.Read();
        }
    }
}
