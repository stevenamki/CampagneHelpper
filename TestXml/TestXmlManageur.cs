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
			AbstarcObjectData dataObject = xml.Load(@"F:\projet\d&d\CampagneHelpper\test.xml");
			Assert.IsTrue(dataObject != null);
		}

        [TestMethod]
        public void TestMethod2()
        {
            XmlManageur xml = new XmlManageur();
			DataNodes data = (DataNodes)xml.Load(@"F:\projet\d&d\CampagneHelpper\test.xml");
            xml.Save(data, @"F:\projet\d&d\CampagneHelpper\Test1.xml");
        }
    }
}