using System;

namespace CountNumberOfZerosInString
{
    class Program
    {
		static String NumberOfZerosUsingCounter(String s)
		{
			//Keep two variables for counting zeros and ones.
			int countForZero = 0;
			int countForOne = 0;

			//Loop through the characters of the string, and when a zero is found,
			//increment countForZero. When a one is found, increment countForOne
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == '0')
					countForZero++;

				else
					countForOne++;
			}

			//return the count in a string
			return "The string " + s + " has" + " " + countForZero + " zeros" + " and"
				+ " " + countForOne + " ones";
		}

		static String NumberOfZerosWithoutUsingCounter(String s)
		{
			//Keep a sum variable initialized with value zero
			int sum = 0;

			//Loop through the characters of string and take the sum of all the characters
			for (int i = 0; i < s.Length; i++)
			{
				//The sum of a character of a string which contains zero and one will
				//always be equal to the number of 1's
				//e.g 0011001 : 0+0+1+1+0+0+1 = 3 = number of 1's

				sum += Convert.ToInt32(s[i].ToString());
				//OR sum += Int32.Parse(s[i].ToString());

				//OR if(Int32.TryParse(s[i].ToString(), out int summation))
					//sum += summation;


			}

			//And the number of zeroes = length of string - number of 1's
			int numOfZeros = s.Length - sum;
			return "The string " + s + " has" + " " + sum + " ones" + " and"
				+ " " + numOfZeros + " ones";
		}
		static void Main(string[] args)
        {
			String str = "011001110";
			Console.Write(NumberOfZerosUsingCounter(str) + "\n");
			Console.WriteLine(NumberOfZerosWithoutUsingCounter(str));
		}
    }
}
