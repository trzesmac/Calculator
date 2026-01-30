public class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Prosty kalkulator");
		Console.WriteLine($"10 + 5 = {Add(10, 5)}");
		Console.WriteLine($"10 - 5 = {Substract(25, 5)}");
		Console.WriteLine($"5 * 5 = {Multiply(25, 5)}");
		Console.WriteLine($"5 / 5 = {Divide(10, 5)}");
        Console.WriteLine($"3 pot 4 = {Power(3, 4)}");
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
		return x * y;
	}
	
	static int Divide(int x, int y)
	{
		if(y == 0)
			throw new DivideByZeroException("Nie można dzielić przez zero");
		
		return x / y;
	}

    static double Power(int x, int y)
    {
        return Math.Pow(x, y);
    }
}