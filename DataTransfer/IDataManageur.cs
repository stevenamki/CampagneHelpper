namespace DataTransfer
{
	public interface IDataManageur
	{
		public IDataObject Load(string filePath);
		public void Save(IDataObject data, string filePath);
	}
}