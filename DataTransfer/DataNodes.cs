using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
	public class DataNodes:IDataObject
	{
		private List<IDataObject> dataObjects;

		public DataNodes()
		{
			dataObjects = new List<IDataObject>();
		}

		public override object getData()
		{
			return dataObjects;
		}

		public void addDataObject(IDataObject data)
		{
			dataObjects.Add(data);
		}

		public void removeDataObject(int index)
		{
			dataObjects.RemoveAt(index);
		}
	}
}
