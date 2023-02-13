using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampagneHelpperInterface.Frontend.Command
{
	public class ExitForm : AbstracCommand
	{
		Form form;
		public ExitForm(Form form)
		{
			this.form = form;
		}
		public override void Execute(Object sender,
						   EventArgs e)
		{
			form.Close();
		}
	}
}
