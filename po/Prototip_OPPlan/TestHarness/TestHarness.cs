using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestHarness
{
	/// <summary>This is a test harness form for the Grouper Control.</summary>
	public class TestHarness : System.Windows.Forms.Form
	{
		#region Variables

		private System.ComponentModel.Container components = null;
		private CodeVendor.Controls.Grouper groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Visit;
		private CodeVendor.Controls.Grouper groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox1;

		#endregion

		#region Constructor

		public TestHarness()
		{
			InitializeComponent();
		}

		#endregion

		#region DeConstructor

		/// <summary>DeConstructor</summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


		#endregion

		#region Initialization

		/// <summary>Initialization</summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TestHarness));
			this.groupBox1 = new CodeVendor.Controls.Grouper();
			this.label2 = new System.Windows.Forms.Label();
			this.Visit = new System.Windows.Forms.Button();
			this.groupBox2 = new CodeVendor.Controls.Grouper();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackgroundColor = System.Drawing.Color.White;
			this.groupBox1.BackgroundGradientColor = System.Drawing.SystemColors.Desktop;
			this.groupBox1.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.Vertical;
			this.groupBox1.BorderColor = System.Drawing.SystemColors.Desktop;
			this.groupBox1.BorderThickness = 1F;
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.Visit);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.CustomGroupBoxColor = System.Drawing.Color.White;
			this.groupBox1.DockPadding.All = 20;
			this.groupBox1.GroupImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.GroupImage")));
			this.groupBox1.GroupTitle = "The Grouper";
			this.groupBox1.Location = new System.Drawing.Point(24, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.PaintGroupBox = false;
			this.groupBox1.RoundCorners = 15;
			this.groupBox1.ShadowColor = System.Drawing.Color.DarkGray;
			this.groupBox1.ShadowControl = true;
			this.groupBox1.ShadowThickness = 5;
			this.groupBox1.Size = new System.Drawing.Size(488, 240);
			this.groupBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(368, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Version: 1.0a";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Visit
			// 
			this.Visit.BackColor = System.Drawing.SystemColors.Desktop;
			this.Visit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Visit.ForeColor = System.Drawing.Color.White;
			this.Visit.Location = new System.Drawing.Point(320, 176);
			this.Visit.Name = "Visit";
			this.Visit.Size = new System.Drawing.Size(96, 23);
			this.Visit.TabIndex = 2;
			this.Visit.Text = "Visit Website";
			this.Visit.Click += new System.EventHandler(this.Visit_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackgroundColor = System.Drawing.Color.White;
			this.groupBox2.BackgroundGradientColor = System.Drawing.Color.White;
			this.groupBox2.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
			this.groupBox2.BorderColor = System.Drawing.Color.Black;
			this.groupBox2.BorderThickness = 1F;
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.pictureBox2);
			this.groupBox2.Controls.Add(this.linkLabel1);
			this.groupBox2.Controls.Add(this.pictureBox3);
			this.groupBox2.CustomGroupBoxColor = System.Drawing.Color.White;
			this.groupBox2.DockPadding.All = 20;
			this.groupBox2.GroupImage = null;
			this.groupBox2.GroupTitle = "";
			this.groupBox2.Location = new System.Drawing.Point(16, 32);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.PaintGroupBox = false;
			this.groupBox2.RoundCorners = 10;
			this.groupBox2.ShadowColor = System.Drawing.SystemColors.Desktop;
			this.groupBox2.ShadowControl = true;
			this.groupBox2.ShadowThickness = 3;
			this.groupBox2.Size = new System.Drawing.Size(232, 184);
			this.groupBox2.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(96, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 64);
			this.label3.TabIndex = 2;
			this.label3.Text = "The control can paint borders, dropshadows, gradient and solid backgrounds, custo" +
				"m text and custom icons.";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(96, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 56);
			this.label1.TabIndex = 0;
			this.label1.Text = "The grouper is a special groupbox control that is rounded and fully customizable." +
				"";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(8, 16);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(85, 160);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(120, 160);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(100, 16);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Read More...";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(99, 80);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(110, 4);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(248, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(230, 120);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// TestHarness
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(534, 279);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "TestHarness";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "The Grouper Test Harness (Beta)";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}


		#endregion

		#region Main Entry Point

		/// <summary>The main entry point for the application.</summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new TestHarness());
		}


		#endregion

		#region Private Methods

		private void Visit_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("IExplore.exe", @"http://www.ebadgeman.com/software.html");
		}

		private void linkLabel1_LinkClicked_1(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("IExplore.exe", @"http://www.ebadgeman.com/software.html");
		}

		
		#endregion
	}
}
