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

		public override Dictionary<string, object> getData()
		{
			Dictionary<string, object> info = base.getData();
			info.Add("chapters", chapters);
			info.Add("quests", quests);
			return info;
		}
	}
}
