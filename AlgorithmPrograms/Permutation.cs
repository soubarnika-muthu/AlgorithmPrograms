using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class Permutation
    {
        public void Permute(string str, int start, int end)
        {
            //if start and end point equals then the new string is formed
            if (start == end)
            {
                Console.WriteLine(str);
            }
            //else repeat the below process
            else
            {
                //iterate using for loop
                for (int i = start; i <= end; i++)
                {
                    //swap the start position with ith position
                    str = Swap(str, start, i);
                    //call permutate method with start as next position
                    Permute(str, start + 1, end);
                    //again swap the string with new start and ith position
                    str = Swap(str, start, i);
                }
            }
        }
        public string Swap(string value, int i, int j)
        {
            //convert the string to char array
            char[] charArray = value.ToCharArray();
            char temp;
            //swap the item at two position
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string str = new string(charArray);
            //return the string
            return str;
        }
    }
}

