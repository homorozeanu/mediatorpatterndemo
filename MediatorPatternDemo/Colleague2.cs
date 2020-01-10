using System;

namespace MediatorPatternDemo
{
	public class Colleague2 : Colleague
    {
		private Colleague1 colleague1;

		public void Register(Colleague1 colleague1)
		{
			this.colleague1 = colleague1;
		}

        public override void Send(string message)
		{
			colleague1.Receive(message);
		}

		public override void Receive(string message)
		{
			Console.WriteLine($"[{nameof(Colleague2)}] Received '{message}'");
		}
    }
}
