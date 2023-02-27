using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGameData
{
	public class Campagne : CampagneElement
	{
		private Dictionary<Type, List<CampagneElement>> campagneElement;

		public Campagne()
		{
			campagneElement = new Dictionary<Type, List<CampagneElement>>();
			campagneElement.Add(typeof(Chapter), new List<CampagneElement>());
			campagneElement.Add(typeof(Person), new List<CampagneElement>());
			campagneElement.Add(typeof(Object), new List<CampagneElement>());
			campagneElement.Add(typeof(Place), new List<CampagneElement>());
		}

		public override void addChildNewElement(CampagneElement element, Tuple<Type, String> infoPath)
		{
			List<CampagneElement> listToAdd = campagneElement.GetValueOrDefault(infoPath.Item1);
			if (listToAdd == null)
			{
				addChildNewElement(element, infoPath);
			}
			else
			{
				listToAdd.Add(element);
			}

		}

		public override void addNewElement(CampagneElement element, Tuple<Type, String> infoPath)
		{
			if (infoPath.Item2 == "Campagne")
			{
				addChildNewElement((CampagneElement)element, infoPath);
			}
		}

		public override Dictionary<string, object> getData()
		{
			Dictionary<string, object> info = base.getData();
			info.Add("chapters", campagneElement.GetValueOrDefault(typeof(Chapter)));
			info.Add("person", campagneElement.GetValueOrDefault(typeof(Person)));
			info.Add("object", campagneElement.GetValueOrDefault(typeof(Object)));
			info.Add("places", campagneElement.GetValueOrDefault(typeof(Place)));
			return info;
		}
	}
}
