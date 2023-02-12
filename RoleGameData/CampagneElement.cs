using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGameData
{
	public abstract class CampagneElement
	{
		String name;
		String description;

		//get set
		public String getName() { return name; }
		public String getDescription() { return description; }
		public void setName(String name) { this.name = name; }
		public void setDescription(String description) { this.description = description; }

		//methode
		public virtual Dictionary<string, object> getData()
		{
			Dictionary<string, object> info = new Dictionary<string, object>();
			info.Add("name", name);
			info.Add("description", description);
			return info;
		}

		public abstract void addNewElement(CampagneElement element, Tuple<Type,string>  infoPath);

		public abstract void addChildNewElement(CampagneElement element, Tuple<Type, string> infoPath);
	}
}
