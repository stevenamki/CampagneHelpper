using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
	public class DataNodes:AbstarcObjectData
	{
		private List<AbstarcObjectData> dataObjects;

		public DataNodes()
		{
			dataObjects = new List<AbstarcObjectData>();
		}

		public override object GetData()
		{
			return dataObjects;
		}

		public void AddDataObject(AbstarcObjectData data)
		{
			dataObjects.Add(data);
		}

		public void RemoveDataObject(int index)
		{
			dataObjects.RemoveAt(index);
		}
	}
}
