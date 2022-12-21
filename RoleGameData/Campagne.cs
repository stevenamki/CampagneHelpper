using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGameData
{
    public class Campagne : CampagneElement
    {
        private List<Campagne> campagnes;
        private List<Chapter> chapters;
        private List<Person> persons;
        private List<Object> objects;
        private List<Place> places;

		public override Dictionary<string, object> getData()
		{
			 Dictionary<string,object> info =base.getData();
            info.Add("campagnes",campagnes);
            info.Add("chapters", chapters);
            info.Add("person", persons);
            info.Add("object", objects);
            info.Add("places", places);
            return info;
        }
	}
}
