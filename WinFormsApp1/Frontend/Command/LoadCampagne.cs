using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampagneHelpperInterface.Frontend.Command
{
	internal class LoadCampagne:AbstracCommand
	{
		private string filePath;

		public override void Execute(Object sender,
						   EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Filter ="text files|*.XML";

			
			if(fileDialog.ShowDialog() == DialogResult.OK)
			{
				filePath = fileDialog.FileName;
			}
		}
	}
}
