using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGameData
{
    public class Chapter : CampagneElement
    {
        List<Chapter> chapters;
        List<Quest> quests;

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
			info.Add("chapters", chapters);
			info.Add("quests", quests);
			return info;
		}
	}
}
