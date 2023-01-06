using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampagneHelpperInterface.Frontend
{
	internal abstract class AbstracCommand
	{
		private String state;
		public abstract void Execute(Object sender,
						   EventArgs e);

	}
}
