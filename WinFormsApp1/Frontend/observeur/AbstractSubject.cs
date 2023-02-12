using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampagneHelpperInterface.Frontend.observeur
{
	public class AbstractSubject
	{
		private List<IObserveur> subscribers;
		
		public AbstractSubject()
		{
			subscribers = new List<IObserveur>();
		}

		public void Subscribe(IObserveur observeur)
		{
			subscribers.Add(observeur);
		}

		public void UnSubscribe(IObserveur observeur)
		{
			subscribers.Remove(observeur);
		}

		protected void notify()
		{
			foreach (var subscriber in subscribers)
			{
				subscriber.notifyed(this);
			}
		}
	}
}
