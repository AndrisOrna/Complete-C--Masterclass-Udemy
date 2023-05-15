using System;
namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
		WriteSomething();

        }
		// access modifier (static) return type method name(parameter 1, parameter2)
		public static void WriteSomething()
		{
			Console.WriteLine("Hello");
			Console.Read();
		}
	}
}
