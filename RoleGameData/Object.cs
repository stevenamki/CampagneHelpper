using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoleGameData.Stats;

namespace RoleGameData
{
    public class Object : CampagneElement
    {
        StatsObject stats;

		public override void addChildNewElement(CampagneElement element, Tuple<Type, string> infoPath)
		{
			throw new NotImplementedException();
		}

		public override void addNewElement(CampagneElement element, Tuple<Type, string> infoPath)
		{
			throw new NotImplementedException();
		}

		public override Dictionary<string, object> getData()
		{
			Dictionary<string, object> info = base.getData();
			info.Add("stats", stats);
			return info;
		}
	}
}
