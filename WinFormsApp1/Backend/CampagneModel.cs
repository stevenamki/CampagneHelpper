using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampagneHelpperInterface.Frontend.observeur;
using RoleGameData;

namespace CampagneHelpperInterface.Model
{
	
	public class CampagneModel:AbstractSubject
	{
		private Campagne campagne;

		public void AddElement(CampagneElement campagneElement, Tuple<Type, string> path)
		{
			
				campagne.addNewElement(campagneElement,path);
				notify();
		}
	}
}
