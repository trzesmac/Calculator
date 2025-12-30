using System;

public class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Prosty kalkulator");
		Console.WriteLine($"10 + 5 = {Add(10, 5)}");
	}
	
	static int Add(int x, int y)
	{
		return x + y;
	}
}