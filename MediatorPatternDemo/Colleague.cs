namespace MediatorPatternDemo
{
	public abstract class Colleague
	{
		public abstract void Send(string message);
		public abstract void Receive(string message);
	}
}
