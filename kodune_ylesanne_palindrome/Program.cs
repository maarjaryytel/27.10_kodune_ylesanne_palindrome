using System;

namespace kodune_ylesanne_palindrome
{
	class Program
	{
		static void Main(string[] args)
		{
			string userChoice;

			Console.WriteLine("Enter your word or name: ");
			userChoice = Console.ReadLine();
			Console.WriteLine("\n");

			string reverseName;
			char[] ch = userChoice.ToCharArray();
			
			Array.Reverse(ch);
			reverseName = new string(ch);

			if (reverseName.ToLower() == userChoice.ToLower())
			{
				Console.WriteLine("Palindrome!");
			}
			else
			{
				Console.WriteLine("It is not Palindrome!");
			}
			Console.ReadLine();
		}
	}
}
