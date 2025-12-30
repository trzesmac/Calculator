using System;

public class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Prosty kalkulator");
		Console.WriteLine($"10 + 5 = {Add(10, 5)}");
		Console.WriteLine($"10 - 5 = {Substract(25, 5)}");
		Console.WriteLine($"5 * 5 = {Multiply(25, 5)}");
	}
	
	static int Add(int x, int y)
	{
		return x + y;
	}
	
	static int Substract(int x, int y)
	{
		return x - y;
	}
	
	static int Multiply(int x, int y)
	{
		return x - y;
	}
}