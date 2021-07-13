using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingABotPlayFridayNightFunkinBecauseImBadAtIt
{
	public class ControlEventArgs : EventArgs
	{
		public bool Enabled { get; }

		public ControlEventArgs(bool enabled)
		{
			this.Enabled = enabled;
		}
	}
}
