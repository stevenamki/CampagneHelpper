﻿using CampagneHelpperInterface.Frontend.Command;
using CampagneHelpperInterface.Frontend.observeur;
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
	public partial class campagneView : Form, IObserveur
	{

		public campagneView()
		{
			InitializeComponent();
		}

		public campagneView(CampagneModel campagne)
		{
			InitializeComponent();
			campagne.Subscribe(this);

			CreateNewForm CreatorformChapter = new CreateNewForm(new AddChapter());

			BtnNewChapter.Click += new EventHandler(CreatorformChapter.Execute);

		}

		public void notifyed(in AbstractSubject subject)
		{
			throw new NotImplementedException();
		}
	}
}
