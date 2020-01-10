using System;

namespace MediatorPatternDemo
{
	public class Colleague2 : Colleague
    {
		public override void Receive(string message)
		{
			Console.WriteLine($"[{nameof(Colleague2)}] Received '{message}'");
		}
    }
}
