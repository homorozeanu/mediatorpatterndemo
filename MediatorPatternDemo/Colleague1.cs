using System;

namespace MediatorPatternDemo
{
	public class Colleague1 : Colleague
    {
		public override void Receive(string message)
		{
			Console.WriteLine($"[{nameof(Colleague1)}] Received '{message}'");
		}
	}
}
