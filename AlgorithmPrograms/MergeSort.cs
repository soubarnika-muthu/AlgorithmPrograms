using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class MergeSort
    {
		// merge function take two intervals
		// one from start to mid
		// second from mid+1, to end
		// and merge them in sorted order

		public void merge(string[] Arr, int start, int mid, int end)
		{

			// create a temp array
			string[] temp = new string[end - start + 1];

			// crawlers for both intervals and for temp
			int i = start, j = mid + 1, k = 0;

			// traverse both arrays and in each iteration add smaller of both elements in temp 
			while (i <= mid && j <= end)
			{
				if (Arr[i].CompareTo(Arr[j])<=0)
				{
					temp[k] = Arr[i];
					k += 1; i += 1;
				}
				else
				{
					temp[k] = Arr[j];
					k += 1; j += 1;
				}
			}

			// add elements left in the first interval 
			while (i <= mid)
			{
				temp[k] = Arr[i];
				k += 1; i += 1;
			}

			// add elements left in the second interval 
			while (j <= end)
			{
				temp[k] = Arr[j];
				k += 1; j += 1;
			}

			// copy temp to original interval
			for (i = start; i <= end; i += 1)
			{
				Arr[i] = temp[i - start];
                
			}
			
		}
		
			

	// Arr is an array of integer type
	// start and end are the starting and ending index of current interval of Arr

	public void mergeSort(string[] Arr, int start, int end)
		{
			if(Arr.Length==0||Arr.Length==1)
            {
                Console.WriteLine("Elements are already in sorted order\n"+Arr);
            }

			if (start < end)
			{
				int mid = (start + end) / 2;
				mergeSort(Arr, start, mid);
				mergeSort(Arr, mid + 1, end);
				merge(Arr, start, mid, end);
			}
			
		}
		public void Display(string[] Arr)
        {
			for (int i = 0; i <Arr.Length ; i += 1)
			{
				Console.WriteLine(Arr[i]);

			}
		}
	}
}
