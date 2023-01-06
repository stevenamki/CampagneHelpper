using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampagneHelpperInterface.Frontend.Command
{
	internal class Exit : AbstracCommand
	{
		public override void Execute(Object sender,
						   EventArgs e)
		{
			Application.Exit();
		}
	}
}
