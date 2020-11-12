using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SumOfDigits
{
	public class SumOfDigits
	{
		/* 
			Given n, take the sum of the digits of n.If that value has more than one digit, 
			continue reducing in this way until a single-digit number is produced.
			This is only applicable to the natural numbers. 

			examples:

			16-- > 1 + 6 = 7
			 942-- > 9 + 4 + 2 = 15-- > 1 + 5 = 6
			132189-- > 1 + 3 + 2 + 1 + 8 + 9 = 24-- > 2 + 4 = 6
			493193-- > 4 + 9 + 3 + 1 + 9 + 3 = 29-- > 2 + 9 = 11-- > 1 + 1 = 2 
			*/
		public static long sumMethod(long input)
		{
			long result = 0;
			if (input != Math.Abs(input)) // if the input is not a natural number; through an exeption.
            {
				throw new System.ArgumentException("The Input Should be a Natural Number", "input");
            }
            else // else continue
            {
				
				string number = input.ToString(); // convert the input from a long type into a string.
				if (number.Length == 1) // if the length of the string is one, then it means there are not any ather digits to add to; thus...
				{
					result = Convert.ToInt64(number); // convert it into long again and return the result.
				}
				else // else...
				{
					while (number.Length > 1) // while the length is larger than 1...
					{
						for (int i=0; i < number.Length; i++) // foreach character in the string...
						{
							
							result += Convert.ToInt64(number[i].ToString()); // convert that character to string and then to long and add it to the result.
							

						}
						number = result.ToString(); // replace the string with the new result
						if (number.Length > 1) { result = 0; } // if there are more than 1 character in to the new string then set the result back to 0, else return the result.

					}
				}
            }
			return result;

		}
	}
}
