namespace DataTransfer
{
	public interface IDataManageur
	{
		public AbstarcObjectData Load(string filePath);
		public void Save(AbstarcObjectData data, string filePath);
	}
}