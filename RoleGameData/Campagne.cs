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

		public override Dictionary<string, object> getData()
		{
			 Dictionary<string,object> info =base.getData();
            info.Add("chapters", chapters);
            info.Add("person", character);
            info.Add("object", objects);
            info.Add("places", places);
            return info;
        }
	}
}
