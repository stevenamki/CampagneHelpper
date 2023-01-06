using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampagneHelpperInterface.Frontend.observeur;
using RoleGameData;

namespace CampagneHelpperInterface.Model
{
	
	public class CampagneModel:IObservable<Observeur>
	{
		#region observeur
		private class Unsubscriber : IDisposable
		{
			private List<IObserver<Observeur>> observers;
			private IObserver<Observeur> observer;

			public Unsubscriber(List<IObserver<Observeur>> observers, IObserver<Observeur> observer)
			{
				this.observers = observers;
				this.observer = observer;
			}

			public void Dispose()
			{
				if (observer != null && observers.Contains(observer))
					observers.Remove(observer);
			}
		}

		private Campagne campagne;
		private List<IObserver<Observeur>> observers;

		public CampagneModel()
		{
			observers = new List<IObserver<Observeur>>();
		}

		public IDisposable Subscribe(IObserver<Observeur> observer)
		{
			if (!observers.Contains(observer))
			{
				observers.Add(observer);
			}
			return new Unsubscriber(observers,observer);
		}
		#endregion observeur


	}
}
