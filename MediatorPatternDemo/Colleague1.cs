using System;

namespace MediatorPatternDemo
{
	public class Colleague1 : Colleague
    {
		private Colleague2 colleague2;

		public void Register(Colleague2 colleague2) => this.colleague2 = colleague2;

		public override void Send(string message)
		{
			colleague2.Receive(message);
		}

		public override void Receive(string message)
		{
			Console.WriteLine($"[{nameof(Colleague1)}] Received '{message}'");
		}
	}
}
