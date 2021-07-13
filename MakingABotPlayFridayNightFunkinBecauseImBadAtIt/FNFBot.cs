using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using InputManager;

namespace MakingABotPlayFridayNightFunkinBecauseImBadAtIt
{
	public partial class FNFBot : Form
	{
		public static Color LEFT_COLOR = Color.FromArgb(194, 75, 153);
		public static Color DOWN_COLOR = Color.FromArgb(21, 255, 255);
		public static Color UP_COLOR = Color.FromArgb(18, 250, 5);
		public static Color RIGHT_COLOR = Color.FromArgb(249, 57, 63);

		public static int TRIGGER_VAL = 75;

		public bool lastLeftState = false;
		public bool lastDownState = false;
		public bool lastUpState = false;
		public bool lastRightState = false;

		public int errorCount = 0;


		public bool BotActive { get; set; }

		public ControlForm ControlForm { get; set; }

		private Timer timer;

		public FNFBot()
		{
			InitializeComponent();

			this.Paint += FNFBot_Paint;

			ControlForm = new ControlForm();
			ControlForm.ControlEvent += ControlForm_ControlEvent;
			ControlForm.Show();

			timer = new Timer();

			timer.Tick += Timer_Tick;
			timer.Interval = 1;
			timer.Start();

			this.TopMost = true;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if(BotActive)
			{
				ProcessScreen();
			}
		}

		private void ControlForm_ControlEvent(object sender, ControlEventArgs e)
		{
			BotActive = e.Enabled;
			ForcePaint(this);

			Keyboard.KeyUp(Keys.Left);
			Keyboard.KeyUp(Keys.Down);
			Keyboard.KeyUp(Keys.Up);
			Keyboard.KeyUp(Keys.Right);
		}

		private const int WmPaint = 0x000F;

		[DllImport("User32.dll")]
		public static extern Int64 SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

		public static void ForcePaint(Form form)
		{
			SendMessage(form.Handle, WmPaint, IntPtr.Zero, IntPtr.Zero);
		}

		private void FNFBot_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = this.CreateGraphics();

			graphics.Clear(Color.White);

			if(BotActive)
			{
				return;
			}

			int x1 = 0;
			int x2 = this.ClientSize.Width;

			int height = this.ClientSize.Height;
			int y = height / 2;

			Pen xLinePen = new Pen(Color.Black, 5);

			graphics.DrawLine(xLinePen, x1, y, x2, y);

			Pen leftLinePen = new Pen(LEFT_COLOR, 5);
			graphics.DrawLine(leftLinePen, GetLeftX(), 0, GetLeftX(), height);

			Pen downLinePen = new Pen(DOWN_COLOR, 5);
			graphics.DrawLine(downLinePen, GetDownX(), 0, GetDownX(), height);

			Pen upLinePen = new Pen(UP_COLOR, 5);
			graphics.DrawLine(upLinePen, GetUpX(), 0, GetUpX(), height);

			Pen rightLinePen = new Pen(RIGHT_COLOR, 5);
			graphics.DrawLine(rightLinePen, GetRightX(), 0, GetRightX(), height);

			//Console.WriteLine("Painted. Y: " + y + " Height: " + this.Height + " ClientSize.Height: " + this.ClientSize.Height);
		}

		private int GetLeftX()
		{
			return this.Width / 4 - ((this.Width / 4) / 2);
		}

		private int GetDownX()
		{
			return (this.Width / 4) * 2 - ((this.Width / 4) / 2);
		}

		private int GetUpX()
		{
			return (this.Width / 4) * 3 - ((this.Width / 4) / 2);
		}

		private int GetRightX()
		{
			return (this.Width / 4) * 4 - ((this.Width / 4) / 2);
		}

		private void FNFBot_Load(object sender, EventArgs e)
		{

		}

		public void ProcessScreen()
		{
			try
			{
				Rectangle rect = new Rectangle(this.Location.X + 7, this.Location.Y + 1, this.Width - 14, this.Height - 7);

				//Console.WriteLine("X: " + this.Location.X + " Y: " + this.Location.Y+ " W: " + this.Width + " H: " + this.Height + " Rect: " + rect.X + ", " + rect.Y+ ", " + rect.Width + ", " + rect.Height);

				Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
				Graphics g = Graphics.FromImage(bmp);
				g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);

				Color leftPixelColor = bmp.GetPixel(GetLeftX(), bmp.Height / 2);
				Color downPixelColor = bmp.GetPixel(GetDownX(), bmp.Height / 2);
				Color upPixelColor = bmp.GetPixel(GetUpX(), bmp.Height / 2);
				Color rightPixelColor = bmp.GetPixel(GetRightX(), bmp.Height / 2);

				int leftValue = CompareColors(leftPixelColor, LEFT_COLOR);
				int downValue = CompareColors(downPixelColor, DOWN_COLOR);
				int upValue = CompareColors(upPixelColor, UP_COLOR);
				int rightValue = CompareColors(rightPixelColor, RIGHT_COLOR);


				/*Console.SetCursorPosition(0,0);
				Console.WriteLine("Left: " + leftPixelColor + "         ");
				Console.WriteLine("Down: " + downPixelColor + "         ");
				Console.WriteLine("Up: " + upPixelColor + "         ");
				Console.WriteLine("Right: " + rightPixelColor + "         ");
				Console.WriteLine(" ");
				Console.WriteLine("Left val: " + leftValue + "     ");
				Console.WriteLine("Down val: " + downValue + "     ");
				Console.WriteLine("Up val: " + upValue + "     ");
				Console.WriteLine("Right val: " + rightValue + "     ");*/

				if (lastLeftState == false && leftValue > TRIGGER_VAL)
				{
					lastLeftState = true;
					Keyboard.KeyDown(Keys.Left);
				}
				else if (lastLeftState == true && leftValue < TRIGGER_VAL)
				{
					lastLeftState = false;
					Keyboard.KeyUp(Keys.Left);
				}

				if (lastDownState == false && downValue > TRIGGER_VAL)
				{
					lastDownState = true;
					Keyboard.KeyDown(Keys.Down);
				}
				else if (lastDownState == true && downValue < TRIGGER_VAL)
				{
					lastDownState = false;
					Keyboard.KeyUp(Keys.Down);
				}

				if (lastUpState == false && upValue > TRIGGER_VAL)
				{
					lastUpState = true;
					Keyboard.KeyDown(Keys.Up);
				}
				else if (lastUpState == true && upValue < TRIGGER_VAL)
				{
					lastUpState = false;
					Keyboard.KeyUp(Keys.Up);
				}

				if (lastRightState == false && rightValue > TRIGGER_VAL)
				{
					lastRightState = true;
					Keyboard.KeyDown(Keys.Right);
				}
				else if (lastRightState == true && rightValue < TRIGGER_VAL)
				{
					lastRightState = false;
					Keyboard.KeyUp(Keys.Right);
				}
			}catch(Exception e)
			{
				Console.WriteLine(e.Message);
				errorCount++;
				this.Text = "Overlay. Error Count: " + errorCount;
			}
		}

		public static int CompareColors(Color a, Color b)
		{
			return 100 * (int)(
				1.0 - ((double)(
					Math.Abs(a.R - b.R) +
					Math.Abs(a.G - b.G) +
					Math.Abs(a.B - b.B)
				) / (256.0 * 3))
			);
		}
	}
}
