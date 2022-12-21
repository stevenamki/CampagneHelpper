using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
	public class DataNodes:IObjectData
	{
		private List<IObjectData> dataObjects;

		public DataNodes()
		{
			dataObjects = new List<IObjectData>();
		}

		public override object getData()
		{
			return dataObjects;
		}

		public void addDataObject(IObjectData data)
		{
			dataObjects.Add(data);
		}

		public void removeDataObject(int index)
		{
			dataObjects.RemoveAt(index);
		}
	}
}
