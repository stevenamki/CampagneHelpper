using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGameData
{
	public class Campagne : CampagneElement
	{
		private List<Chapter> chapters;
		private List<Person> character;
		private List<Object> objects;
		private List<Place> places;

		public Campagne()
		{
			chapters = new List<Chapter>();
			character = new List<Person>();
			objects = new List<Object>();
			places = new List<Place>();
		}

		public override void addChildNewElement(CampagneElement element, Tuple<Type, String> infoPath)
		{
			if (infoPath.Item1 == typeof(Chapter))
			{
				chapters.Add((Chapter)element);
			}
			else if (infoPath.Item1 == typeof(Person))
			{
				character.Add((Person)element);
			}
			else if (infoPath.Item1 == typeof(Object))
			{
				objects.Add((Object)element);
			}
			else if (infoPath.Item1 == typeof(Place))
			{
				places.Add((Place)element);
			}
			else
			{
				addChildNewElement(element, infoPath);
			}


		}

		public override void addNewElement(CampagneElement element, Tuple<Type, String> infoPath)
		{
			throw new NotImplementedException();
		}

		public override Dictionary<string, object> getData()
		{
			Dictionary<string, object> info = base.getData();
			info.Add("chapters", chapters);
			info.Add("person", character);
			info.Add("object", objects);
			info.Add("places", places);
			return info;
		}
	}
}
