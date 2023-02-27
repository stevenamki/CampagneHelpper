using CampagneHelpperInterface.Model;
using RoleGameData;

namespace CampagneHelpperInterface.Frontend.Command
{
	public class CreateCampagneElement : AbstracCommand
	{
		protected object[] args;
		protected CampagneModel campagne;
		Tuple<Type, string> infoElement;
		protected object element;

		public CreateCampagneElement(Type type, string path, CampagneModel campagne)
		{
			infoElement = new Tuple<Type, string>(type,path);
			this.campagne = campagne;
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
