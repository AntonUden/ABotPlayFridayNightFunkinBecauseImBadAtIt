
namespace MakingABotPlayFridayNightFunkinBecauseImBadAtIt
{
	partial class ControlForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_start = new System.Windows.Forms.Button();
			this.btn_stop = new System.Windows.Forms.Button();
			this.SelectColor = new System.Windows.Forms.ColorDialog();
			this.btn_leftColor = new System.Windows.Forms.Button();
			this.btn_rightColor = new System.Windows.Forms.Button();
			this.btn_upColor = new System.Windows.Forms.Button();
			this.btn_downColor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_start
			// 
			this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_start.Location = new System.Drawing.Point(12, 12);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(213, 26);
			this.btn_start.TabIndex = 0;
			this.btn_start.Text = "Start";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
			// 
			// btn_stop
			// 
			this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_stop.Location = new System.Drawing.Point(12, 44);
			this.btn_stop.Name = "btn_stop";
			this.btn_stop.Size = new System.Drawing.Size(213, 26);
			this.btn_stop.TabIndex = 1;
			this.btn_stop.Text = "Stop";
			this.btn_stop.UseVisualStyleBackColor = true;
			this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
			// 
			// btn_leftColor
			// 
			this.btn_leftColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_leftColor.Location = new System.Drawing.Point(12, 76);
			this.btn_leftColor.Name = "btn_leftColor";
			this.btn_leftColor.Size = new System.Drawing.Size(213, 23);
			this.btn_leftColor.TabIndex = 2;
			this.btn_leftColor.Text = "Set left color";
			this.btn_leftColor.UseVisualStyleBackColor = true;
			this.btn_leftColor.Click += new System.EventHandler(this.btn_leftColor_Click);
			// 
			// btn_rightColor
			// 
			this.btn_rightColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_rightColor.Location = new System.Drawing.Point(12, 105);
			this.btn_rightColor.Name = "btn_rightColor";
			this.btn_rightColor.Size = new System.Drawing.Size(213, 23);
			this.btn_rightColor.TabIndex = 3;
			this.btn_rightColor.Text = "Set right color";
			this.btn_rightColor.UseVisualStyleBackColor = true;
			this.btn_rightColor.Click += new System.EventHandler(this.btn_rightColor_Click);
			// 
			// btn_upColor
			// 
			this.btn_upColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_upColor.Location = new System.Drawing.Point(12, 134);
			this.btn_upColor.Name = "btn_upColor";
			this.btn_upColor.Size = new System.Drawing.Size(213, 23);
			this.btn_upColor.TabIndex = 4;
			this.btn_upColor.Text = "Set up color";
			this.btn_upColor.UseVisualStyleBackColor = true;
			this.btn_upColor.Click += new System.EventHandler(this.btn_upColor_Click);
			// 
			// btn_downColor
			// 
			this.btn_downColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_downColor.Location = new System.Drawing.Point(12, 163);
			this.btn_downColor.Name = "btn_downColor";
			this.btn_downColor.Size = new System.Drawing.Size(213, 23);
			this.btn_downColor.TabIndex = 5;
			this.btn_downColor.Text = "Set down color";
			this.btn_downColor.UseVisualStyleBackColor = true;
			this.btn_downColor.Click += new System.EventHandler(this.btn_downColor_Click);
			// 
			// ControlForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(237, 198);
			this.Controls.Add(this.btn_downColor);
			this.Controls.Add(this.btn_upColor);
			this.Controls.Add(this.btn_rightColor);
			this.Controls.Add(this.btn_leftColor);
			this.Controls.Add(this.btn_stop);
			this.Controls.Add(this.btn_start);
			this.Name = "ControlForm";
			this.Text = "FNF Bot";
			this.Load += new System.EventHandler(this.ControlForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.Button btn_stop;
		private System.Windows.Forms.ColorDialog SelectColor;
		private System.Windows.Forms.Button btn_leftColor;
		private System.Windows.Forms.Button btn_rightColor;
		private System.Windows.Forms.Button btn_upColor;
		private System.Windows.Forms.Button btn_downColor;
	}
}