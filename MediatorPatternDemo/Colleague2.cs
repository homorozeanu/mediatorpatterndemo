using System;

namespace MediatorPatternDemo
{
	public class Colleague2 : Colleague
    {
		private readonly ConcreteMediator mediator;

		public Colleague2(ConcreteMediator mediator)
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
			Console.WriteLine($"[{nameof(Colleague2)}] Received '{message}'");
		}
    }
}
