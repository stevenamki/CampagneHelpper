using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampagneHelpperInterface.Frontend.observeur
{
	public class Observeur : IObserver<Observeur>
	{
		public void OnCompleted()
		{
			throw new NotImplementedException();
		}

		public void OnError(Exception error)
		{
			throw new NotImplementedException();
		}

		public void OnNext(Observeur value)
		{
			throw new NotImplementedException();
		}
	}
}
