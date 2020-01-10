using System;

namespace MediatorPatternDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var mediator = new ConcreteMediator();

			var colleague1 = new Colleague1(mediator);
			var colleague2 = new Colleague2(mediator);

			colleague1.Send("Hi from colleague 1");
			colleague2.Send("Hey there, I'm colleague 2");

			Console.ReadLine();
		}
	}
}
