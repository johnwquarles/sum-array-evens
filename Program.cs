using System;
using System.Linq;
using System.Collections.Generic;

namespace array_sum_evens
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("What number do you want to choose?");
			int upperBound = int.Parse(Console.ReadLine());
			IEnumerable<int> arr = Enumerable.Range (1, (int)Math.Floor((decimal)(upperBound / 2))).Select(i => 2 * i);
			Console.WriteLine ("Here are the evens:");
			foreach (int num in arr) {
				Console.WriteLine (num);
			}
			Console.WriteLine ("Here is the sum of the evens " + arr.Sum());
		}
	}
}
