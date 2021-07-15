using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class MagicNumber
    {
        public int startPoint = 1;
        public int endPoint = 100;

        public int FindMid()
        {
            int mid = (startPoint + endPoint) / 2;
            return mid;
        }

        public void TakeUserInput(int midNumber)
        {
            //get the user opinion
            Console.WriteLine("1.Is your Number{0}\n2.Number is greater than {0}\n3.Number is less than equal to {0}", midNumber, midNumber, midNumber);
            Console.Write("enter your option");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Magic Number Found:"+midNumber);
                    break;
                case 2:
                    startPoint = midNumber + 1;
                    break;
                case 3:
                    endPoint = midNumber-1;
                    break;
                default:
                    Console.WriteLine("enter valid option");
                    break;
            }
        }
        //calling think number method 
        public void ThinkNumber()
        {
            //run until startpoint will be equal to end point
            while (startPoint != endPoint)
            {
                //find mid
                int mid = FindMid();
                //pass mid to binary search method
                TakeUserInput(mid);
            }
            //if start == end point then the number guessed is that
            if (startPoint == endPoint)
            {
                Console.WriteLine("the number you guess is {0}", startPoint);
            }
        }
    }
}
