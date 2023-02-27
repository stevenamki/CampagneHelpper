using CampagneHelpperInterface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampagneHelpperInterface.Frontend.Command.AddRolePlayElement
{
	public class AddChapterElement : CreateCampagneElement
	{
		public AddChapterElement(Type type, string path,CampagneModel campagne) : base(type, path, campagne)
		{
		}

		public override void Execute(object sender, EventArgs e)
		{
			string description = ((Button)sender).Parent.Controls.Find("RDescription", false).FirstOrDefault().Text;
			string Title = ((Button)sender).Parent.Controls.Find("TxtTitle", false).FirstOrDefault().Text;
			args = new object[] {Title,description};
			base.Execute(sender, e);
		}
	}
}
