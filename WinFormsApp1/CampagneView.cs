using CampagneHelpperInterface.Model;
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
	public partial class campagneView : Form
	{
		public campagneView()
		{
			InitializeComponent();
		}

		public campagneView(CampagneModel campagne)
		{
			InitializeComponent();
		}
	}
}
