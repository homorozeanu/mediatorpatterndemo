using System;

namespace MediatorPatternDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var colleague1 = new Colleague1();
			var colleague2 = new Colleague2();

			colleague1.Register(colleague2);
			colleague2.Register(colleague1);

			colleague1.Send("Hi from colleague 1");
			colleague2.Send("Hey there, I'm colleague 2");

			Console.ReadLine();
		}
	}
}
