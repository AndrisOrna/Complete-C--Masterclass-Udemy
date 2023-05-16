namespace helloworld
{
	class DecisionMaking
	{
		static void Main(string[] args)
		{
			WriteSomething();
			WriteSomethingSpecific("my name");
			Console.Read();
		}
		// access modifier (static) return type method name(parameter 1, parameter2)
		public static void WriteSomething()
		{
			Console.WriteLine("hello, i am called from method");
			//console.read(); // need to call from main method
		}
		public static void WriteSomethingSpecific(string mytext)
		{
			Console.WriteLine(mytext);
			//console.read();
		}
	}
}
