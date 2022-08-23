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
			IDataObject dataObject = xml.Load(@"C:\Users\Steven Labelle\source\repos\stevenamki\CampagneHelpper\test.xml");
			Assert.IsTrue(dataObject != null);
		}

        [TestMethod]
        public void TestMethod2()
        {
            XmlManageur xml = new XmlManageur();
			DataNodes data = (DataNodes)xml.Load(@"C:\Users\Steven Labelle\source\repos\stevenamki\CampagneHelpper\test.xml");
            xml.Save(data, @"C:\Users\Steven Labelle\source\repos\stevenamki\test\Test1.xml");
        }
    }
}