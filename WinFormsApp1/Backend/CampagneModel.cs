using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampagneHelpperInterface.Frontend.observeur;
using RoleGameData;

namespace CampagneHelpperInterface.Model
{

	public class CampagneModel : AbstractSubject
	{
		private Campagne campagne;

		public CampagneModel()
		{
			campagne = new Campagne();
		}

		public void AddElement(CampagneElement campagneElement, Tuple<Type, string> path)
		{

			campagne.addNewElement(campagneElement, path);
			notify();
		}

		public List<String> GetListChapterName()
		{
			Dictionary<String, object> data = campagne.getData();
			List<CampagneElement> chapters = (List<CampagneElement>)data.GetValueOrDefault("chapters");
			List<string> chapterNames = new List<string>();
			foreach (CampagneElement value in chapters)
			{
				chapterNames.Add(value.getName());
			}
			return chapterNames;
		}
	}
}
