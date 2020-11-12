using System;
using System.Collections.Generic;
using System.Text;

namespace SumDiv3or5
{
	public class SumDiv3or5Calc
	{
		
		//Your task is to write a method forSum. 
		//This method should taken the int(n) and add up all 
		//mutiples of 3 and 5 up to and including n
		public static int sumMethod(int n)
		{
			int sum = 0;
          
            for (int i =0; i<=n;i++)
            {
				if (i % 3 == 0 || i % 5==0)
				{ 
					sum += i;
				}
            }
			return sum;
		}
	}
}


