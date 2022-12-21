using RoleGameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampagneHelpperInterface.Backend
{
	internal interface IDataManager
	{
		public Campagne loadCampagne(string filePath);
	}
}
