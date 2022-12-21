using RoleGameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransfer.Xml;
using DataTransfer;

namespace CampagneHelpperInterface.Backend
{
	internal class DataManagerrXml : IDataManager
	{
		private XmlManageur xmlManageur = new XmlManageur();

		DataManagerrXml()
		{
			xmlManageur = new XmlManageur();
		}

		public Campagne loadCampagne(String filePath)
		{
			IObjectData campagne = xmlManageur.Load(filePath);
		}

	
	}
}
