using System;

namespace MediatorPatternDemo
{
	public class Colleague2
    {
		private Colleague1 colleague1;

		public void Register(Colleague1 colleague1)
		{
			this.colleague1 = colleague1;
		}

        public void Send(string message)
		{
			colleague1.Receive(message);
		}

		public void Receive(string message)
		{
			Console.WriteLine($"[{nameof(Colleague2)}] Received '{message}'");
		}
    }
}
