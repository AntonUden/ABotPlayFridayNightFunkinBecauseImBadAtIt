using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakingABotPlayFridayNightFunkinBecauseImBadAtIt
{
	public partial class ControlForm : Form
	{
		public delegate void MyEventHandler(object sender, ControlEventArgs e);

		public event MyEventHandler ControlEvent;

		public ControlForm()
		{
			InitializeComponent();
		}

		private void btn_start_Click(object sender, EventArgs e)
		{
			ControlEvent.Invoke(this, new ControlEventArgs(true));
		}

		private void btn_stop_Click(object sender, EventArgs e)
		{
			ControlEvent.Invoke(this, new ControlEventArgs(false));
		}

		private void ControlForm_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
		}
	}
}
