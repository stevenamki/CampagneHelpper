using System;
using System.Collections.Generic;
using System.Data;
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
			XmlDocument doc = xmlFileCreateur(data);
			doc.Save(filePath);
        }

		private DataNodes readNode(XmlNode nodeToread)
		{
			DataNodes dataNodes = new DataNodes();
			dataNodes.setName(nodeToread.Name);
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
		private XmlDocument xmlFileCreateur(IDataObject data)
		{
            XmlDocument doc = new XmlDocument();
            XmlNode rootNode = doc.CreateElement(data.getName());
            doc.AppendChild(rootNode);
			createAllChieldNodeXml(rootNode, doc, (List<IDataObject>)data.getData());

            return doc;
        }

		private void createAllChieldNodeXml(XmlNode parentNode,XmlDocument xmlDoc,List<IDataObject> datas)
		{
            for (int i =0;i< datas.Count;i++)
            {
                
				if(datas[i].GetType() == typeof(DataNodes)){
                    XmlNode childNode = xmlDoc.CreateElement(datas[i].getName());
                    createAllChieldNodeXml(childNode, xmlDoc, (List<IDataObject>)datas[i].getData());
                    parentNode.AppendChild(childNode);
                }
				else
				{
                    XmlNode childNode = xmlDoc.CreateTextNode(datas[i].getName());
                    childNode.Value = datas[i].getData().ToString();
                    parentNode.AppendChild(childNode);
                }
            }
        }

		private void xmlNodeFusion(XmlNode nodeToFusion,XmlNode parentNode)
		{
			parentNode.AppendChild(nodeToFusion);
		}
	}
}
