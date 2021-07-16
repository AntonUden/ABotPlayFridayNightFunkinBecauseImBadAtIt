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
		public delegate void ControlEventHandler(object sender, ControlEventArgs e);
		public delegate void ColorEventHandler(object sender, SetColorEventArgs e);

		public event ControlEventHandler ControlEvent;
		public event ColorEventHandler ColorEvent;

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

		private void btn_leftColor_Click(object sender, EventArgs e)
		{
			SelectColor.ShowDialog();
			ColorEvent?.Invoke(this, new SetColorEventArgs(SelectColor.Color, Direction.LEFT));
		}

		private void btn_rightColor_Click(object sender, EventArgs e)
		{
			SelectColor.ShowDialog();
			ColorEvent?.Invoke(this, new SetColorEventArgs(SelectColor.Color, Direction.RIGHT));
		}

		private void btn_upColor_Click(object sender, EventArgs e)
		{
			SelectColor.ShowDialog();
			ColorEvent?.Invoke(this, new SetColorEventArgs(SelectColor.Color, Direction.UP));
		}

		private void btn_downColor_Click(object sender, EventArgs e)
		{
			SelectColor.ShowDialog();
			ColorEvent?.Invoke(this, new SetColorEventArgs(SelectColor.Color, Direction.DOWN));
		}
	}
}