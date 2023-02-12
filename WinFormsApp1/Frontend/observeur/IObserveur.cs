using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampagneHelpperInterface.Frontend.observeur
{
	public interface IObserveur
	{
		public void notifyed(in AbstractSubject subject);
	}
}
