using CampagneHelpperInterface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampagneHelpperInterface.Frontend.Command
{
	public class CreateNewCampagne : AbstracCommand
	{
		public override void Execute(object sender, EventArgs e)
		{
			CampagneModel newCampagne = new CampagneModel();

			campagneView view = new campagneView(newCampagne);

			view.ShowDialog();
		}
	}
}
