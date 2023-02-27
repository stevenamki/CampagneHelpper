using CampagneHelpperInterface.Frontend.Command;
using CampagneHelpperInterface.Frontend.Command.AddRolePlayElement;
using CampagneHelpperInterface.Model;
using RoleGameData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampagneHelpperInterface
{
	public partial class AddChapter : Form
	{
		private CampagneModel campagne;
		public AddChapter(CampagneModel campagne)
		{
            this.campagne = campagne;
            InitializeComponent();
			AddChapterElement createCampagneElement = new AddChapterElement(typeof(Chapter), "Campagne",campagne);
			ExitForm exitForm = new ExitForm(this);

			BtnCreate.Click += new EventHandler(createCampagneElement.Execute);
			BtnCreate.Click += new EventHandler(exitForm.Execute);
			BtnCancel.Click += new EventHandler(exitForm.Execute);
			
		}
	}
}
