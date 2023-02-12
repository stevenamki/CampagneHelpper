using CampagneHelpperInterface.Model;
using RoleGameData;

namespace CampagneHelpperInterface.Frontend.Command
{
	public class CreateCampagneElement : AbstracCommand
	{
		private object[] args;
		private CampagneModel campagne;
		Tuple<Type, string> infoElement;
		private object element;

		public CreateCampagneElement(Type type, string path)
		{
			infoElement = new Tuple<Type, string>(type,path);
		}

		public override void Execute(object sender, EventArgs e)
		{
			element = Activator.CreateInstance(infoElement.Item1, args);
			campagne.AddElement((CampagneElement)element,infoElement);
			
		}

		public object GetElement()
		{
			return element;
		}
	}
}
