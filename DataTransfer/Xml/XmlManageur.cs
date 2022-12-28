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
		public AbstarcObjectData Load(string filePath)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(filePath);
			XmlNode MainNode = doc.DocumentElement;
			return readNode(MainNode);

		}

		public void Save(AbstarcObjectData data, string filePath)
		{

		}

		private DataNodes readNode(XmlNode nodeToread)
		{
			DataNodes dataNodes = new DataNodes();
			dataNodes.SetName(nodeToread.Name);
			readAllAttributteToNode(dataNodes, nodeToread);
			foreach (XmlNode node in nodeToread.ChildNodes)
			{
				if (node.HasChildNodes)
				{
					dataNodes.AddDataObject(readNode(node));
				}
				else
				{
					Node newNode = new Node();
					newNode.SetName(node.ParentNode.Name);
					newNode.SetData(node.Value);
					XmlAttributeCollection xmlAttribute = node.Attributes;
					readAllAttributteToNode(newNode, node);
					dataNodes.AddDataObject(newNode);
				}
				
			}
			return dataNodes;

		}

		private void readAllAttributteToNode(AbstarcObjectData node, XmlNode nodeToRead)
		{
			XmlAttributeCollection xmlAttribute = nodeToRead.Attributes;
			if (xmlAttribute != null)
			{
				foreach (XmlAttribute attribute in xmlAttribute)
				{
					node.AddAttribute(attribute.Name, attribute.Value);
				}
			}
		}
	}
}
