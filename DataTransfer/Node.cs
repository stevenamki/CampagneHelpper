using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
	internal class Node: IObjectData
	{
		Object data;
		public override object getData()
		{
			return data;
		}

		public void setData(Object data)
		{
			this.data = data;
		}

	}
}
