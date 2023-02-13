using CampagneHelpperInterface.Frontend.Command;
using CampagneHelpperInterface.Frontend.Command.AddRolePlayElement;
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
		public AddChapter()
		{
			InitializeComponent();
			AddChapterElement createCampagneElement = new AddChapterElement(typeof(Chapter), "Campagne");
			ExitForm exitForm = new ExitForm(this);

			BtnCreate.Click += new EventHandler(createCampagneElement.Execute);
			BtnCancel.Click += new EventHandler(exitForm.Execute);
		}
	}
}
