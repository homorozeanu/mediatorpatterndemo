namespace MediatorPatternDemo
{
	public abstract class Colleague
	{
		protected ConcreteMediator mediator;

		internal void SetMediator(ConcreteMediator mediator)
		{
			this.mediator = mediator;
		}

		public virtual void Send(string message)
		{
			this.mediator.Send(this, message);
		}
		
		public abstract void Receive(string message);
	}
}
