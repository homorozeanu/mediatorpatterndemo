using System.Collections.Generic;
using System.Linq;

namespace MediatorPatternDemo
{
	public class ConcreteMediator
    {
		private IList<Colleague> colleagues = new List<Colleague>();

		public void Register(Colleague colleague)
		{
			colleagues.Add(colleague);
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
