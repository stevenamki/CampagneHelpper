using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
	internal class Node: AbstarcObjectData
	{
		Object data;
		public override object GetData()
		{
			return data;
		}

		public void SetData(Object data)
		{
			this.data = data;
		}

	}
}
