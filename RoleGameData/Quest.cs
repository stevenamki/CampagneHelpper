namespace RoleGameData
{
    public class Quest : CampagneElement
    {
        float xp;

		public override void addChildNewElement(CampagneElement element, Tuple<Type, string> infoPath)
		{
			throw new NotImplementedException();
		}

		public override void addNewElement(CampagneElement element, Tuple<Type, string> infoPath)
		{
			throw new NotImplementedException();
		}

		public override Dictionary<string, object> getData()
		{
			Dictionary<string, object> info = base.getData();
			info.Add("xp", xp);
			return info;
		}
	}
}