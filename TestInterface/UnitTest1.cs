using Microsoft.VisualStudio.TestTools.UnitTesting;
using CampagneHelpperInterface.Frontend.Command;
using RoleGameData;

namespace TestInterface
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestRefration()
		{
			CreateCampagneElement test = new CreateCampagneElement(typeof(Quest));
			test.Execute(null,null);
			object value = test.GetElement();
			Assert.IsNotNull(value);
			Assert.AreEqual(typeof(Quest), value.GetType());
		}
	}
}