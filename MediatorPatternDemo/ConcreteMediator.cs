using System.Collections.Generic;
using System.Linq;

namespace MediatorPatternDemo
{
	public class ConcreteMediator
    {
		private IList<Colleague> colleagues = new List<Colleague>();

		public T CreateColleague<T>() where T : Colleague, new()
		{
			var c = new T();
			c.SetMediator(this);
			this.colleagues.Add(c);
			return c;
		}

		public void Send(Colleague colleague, string message)
		{
			colleagues
				.Where(x => x != colleague)
				.ToList()
				.ForEach(x => x.Receive(message));
		}
	}
}
