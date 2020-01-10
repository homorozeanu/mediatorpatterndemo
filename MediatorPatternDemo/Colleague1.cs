using System;

namespace MediatorPatternDemo
{
	public class Colleague1
    {
		private Colleague2 colleague2;

		public void Register(Colleague2 colleague2) => this.colleague2 = colleague2;

		public void Send(string message)
		{
			colleague2.Receive(message);
		}

		public void Receive(string message)
		{
			Console.WriteLine($"[{nameof(Colleague1)}] Received '{message}'");
		}
    }
}
