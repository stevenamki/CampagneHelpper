using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
	internal class Node: IDataObject
	{
		String name;
		Object data;
		public object getData()
		{
			return data;
		}

		public void setData(Object data)
		{
			this.data = data;
		}

		public object getName()
		{
			return name;
		}

		public void setName(string name)
		{
			this.name = name;
		}

	}
}
