using System;

namespace MediatorPatternDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var mediator = new ConcreteMediator();

			var colleague1 = mediator.CreateColleague<Colleague1>();
			var colleague2 = mediator.CreateColleague<Colleague2>();

			colleague1.Send("Hi from colleague 1");
			colleague2.Send("Hey there, I'm colleague 2");

			Console.ReadLine();
		}
	}
}
