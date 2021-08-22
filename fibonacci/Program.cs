/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/21/2021
 * Time: 17:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace fibonacci
{
	class Program
	{
		
			// A simple recursive
			// program to find n'th
			// fibonacci number
			static int fib(int n)
			{
				if (n <= 1)
					return n;
				return fib(n - 1) + fib(n - 2);
			}
		
			// Returns number of ways
			// to reach n'th stair
			static int countWays(int s)
			{
				return fib(s + 1);
			}
		
			// Driver Code
			public static void Main(string[] args)
			{
				Console.Write("Enter the size of stairs and program will tell you number of ways = ");
				int n = int.Parse(Console.ReadLine());  // make use enter n
				
				Console.WriteLine("Number of ways for the frog = " + countWays(n));
				
				Console.Write("Press any key to continue . . . ");
				Console.ReadKey(true);
			}
		

			
		}
	
}