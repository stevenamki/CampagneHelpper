namespace RoleGameData
{
    public class Quest : CampagneElement
    {
        float xp;

		public override Dictionary<string, object> getData()
		{
			Dictionary<string, object> info = base.getData();
			info.Add("xp", xp);
			return info;
		}
	}
}