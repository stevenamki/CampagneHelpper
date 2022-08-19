using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataTransfer.Xml;
using DataTransfer;

namespace TestXml
{
	[TestClass]
	public class TestXmlManageur
	{
		[TestMethod]
		public void TestMethod1()
		{
			XmlManageur xml = new XmlManageur();
			IDataObject dataObject = xml.Load(@"F:\projet\d&d\Exemple.xml");
			Assert.IsTrue(dataObject != null);
		}
	}
}