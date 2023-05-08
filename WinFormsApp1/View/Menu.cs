namespace WinFormsApp1
{
	using CampagneHelpperInterface.Frontend.Command;
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
			Exit exit = new Exit();
			LoadCampagne loadCampagne = new LoadCampagne();
			CreateNewCampagne createNewCampagne = new CreateNewCampagne();


			btnClose.Click += new EventHandler(exit.Execute);
			btnLoadCampagne.Click += new EventHandler(loadCampagne.Execute);
			btnNewCampagne.Click += new EventHandler(createNewCampagne.Execute);

		}
	}
}