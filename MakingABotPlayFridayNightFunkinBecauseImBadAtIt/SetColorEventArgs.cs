using System;
using System.Drawing;

namespace MakingABotPlayFridayNightFunkinBecauseImBadAtIt
{
	public class SetColorEventArgs : EventArgs
	{
		public Color Color { get; }
		public Direction Direction { get; }

		public SetColorEventArgs(Color color, Direction direction)
		{
			this.Color = color;
			this.Direction = direction;
		}
	}
}