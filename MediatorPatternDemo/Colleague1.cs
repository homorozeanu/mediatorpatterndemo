using System;

namespace MediatorPatternDemo
{
	public class Colleague1 : Colleague
    {
		private readonly ConcreteMediator mediator;

		public Colleague1(ConcreteMediator mediator)
		{
			this.mediator = mediator;
			mediator.Register(this);
		}

		public override void Send(string message)
		{
			this.mediator.Send(this, message);
		}

		public override void Receive(string message)
		{
			Console.WriteLine($"[{nameof(Colleague1)}] Received '{message}'");
		}
	}
}
