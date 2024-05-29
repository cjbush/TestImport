using System.Runtime.InteropServices;

internal class Program
{

	[DllImport("TestExport.dll")]
	public static extern int Add(int a, int b);

	private static void Main(string[] args)
	{
		Console.WriteLine(Add(2, 3));
	}
}