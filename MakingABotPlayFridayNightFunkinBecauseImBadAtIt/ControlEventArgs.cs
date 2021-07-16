using System;

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