namespace DataTransfer
{
	public interface IDataManageur
	{
		public IObjectData Load(string filePath);
		public void Save(IObjectData data, string filePath);
	}
}