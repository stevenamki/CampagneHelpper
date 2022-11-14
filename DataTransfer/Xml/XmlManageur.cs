using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataTransfer.Xml
{
	public class XmlManageur : IDataManageur
	{
		public IDataObject Load(string filePath)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(filePath);
			XmlNode MainNode = doc.DocumentElement;
			return readNode(MainNode);
			
		}

		public void Save(IDataObject data,string filePath)
		{
			
		}

		private DataNodes readNode(XmlNode nodeToread)
		{
			DataNodes dataNodes = new DataNodes();
			foreach (XmlNode node in nodeToread.ChildNodes)
			{
				if (node.HasChildNodes)
				{
					dataNodes.addDataObject(readNode(node));
				}
				else
				{
					Node newNode = new Node();
					newNode.setName(node.ParentNode.Name);
					newNode.setData(node.Value);
					dataNodes.addDataObject(newNode);
				}
			}
			return dataNodes;

		}
	}
}
