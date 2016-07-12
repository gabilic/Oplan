namespace Prototip_OPPlan
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.ime_Mjesta = new System.Windows.Forms.TextBox();
            this.dodaj = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.izvj = new System.Windows.Forms.Button();
            this.konacno = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OP_Plan = new System.Windows.Forms.Button();
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.prviLink = new CodeVendor.Controls.Grouper();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.drugiLink = new CodeVendor.Controls.Grouper();
            this.panel1 = new System.Windows.Forms.Panel();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r4 = new System.Windows.Forms.RadioButton();
            this.MMarkeri = new System.Windows.Forms.Button();
            this.treciLink = new CodeVendor.Controls.Grouper();
            this.Clear = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.PictureBox();
            this.delete_mode = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            this.prviLink.SuspendLayout();
            this.drugiLink.SuspendLayout();
            this.panel1.SuspendLayout();
            this.treciLink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_mode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.animator1.SetDecoration(this.gMapControl1, AnimatorNS.DecorationType.None);
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 1);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1256, 504);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            this.gMapControl1.OnRouteClick += new GMap.NET.WindowsForms.RouteClick(this.gMapControl1_OnRouteClick);
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // ime_Mjesta
            // 
            this.animator1.SetDecoration(this.ime_Mjesta, AnimatorNS.DecorationType.None);
            this.ime_Mjesta.Location = new System.Drawing.Point(115, 59);
            this.ime_Mjesta.Name = "ime_Mjesta";
            this.ime_Mjesta.Size = new System.Drawing.Size(100, 20);
            this.ime_Mjesta.TabIndex = 1;
            // 
            // dodaj
            // 
            this.animator1.SetDecoration(this.dodaj, AnimatorNS.DecorationType.None);
            this.dodaj.Location = new System.Drawing.Point(115, 111);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(85, 23);
            this.dodaj.TabIndex = 3;
            this.dodaj.Text = "Idi";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // comboBox1
            // 
            this.animator1.SetDecoration(this.comboBox1, AnimatorNS.DecorationType.None);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // izvj
            // 
            this.animator1.SetDecoration(this.izvj, AnimatorNS.DecorationType.None);
            this.izvj.Location = new System.Drawing.Point(663, 1);
            this.izvj.Name = "izvj";
            this.izvj.Size = new System.Drawing.Size(75, 23);
            this.izvj.TabIndex = 7;
            this.izvj.Text = "izvještaj";
            this.izvj.UseVisualStyleBackColor = true;
            this.izvj.Click += new System.EventHandler(this.izvj_Click);
            // 
            // konacno
            // 
            this.animator1.SetDecoration(this.konacno, AnimatorNS.DecorationType.None);
            this.konacno.Location = new System.Drawing.Point(47, 40);
            this.konacno.Name = "konacno";
            this.konacno.Size = new System.Drawing.Size(328, 171);
            this.konacno.TabIndex = 9;
            this.konacno.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animator1.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Grad/mjesto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.animator1.SetDecoration(this.label3, AnimatorNS.DecorationType.None);
            this.label3.Location = new System.Drawing.Point(36, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Izaberi marker:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.animator1.SetDecoration(this.label4, AnimatorNS.DecorationType.None);
            this.label4.Location = new System.Drawing.Point(97, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Strana:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.animator1.SetDecoration(this.label5, AnimatorNS.DecorationType.None);
            this.label5.Location = new System.Drawing.Point(23, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Postaviti marker ili rutu:";
            // 
            // OP_Plan
            // 
            this.animator1.SetDecoration(this.OP_Plan, AnimatorNS.DecorationType.None);
            this.OP_Plan.Location = new System.Drawing.Point(136, 1);
            this.OP_Plan.Name = "OP_Plan";
            this.OP_Plan.Size = new System.Drawing.Size(75, 23);
            this.OP_Plan.TabIndex = 16;
            this.OP_Plan.Text = "Mjesto napada";
            this.OP_Plan.UseVisualStyleBackColor = true;
            this.OP_Plan.Click += new System.EventHandler(this.OP_Plan_Click);
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            // 
            // prviLink
            // 
            this.prviLink.BackgroundColor = System.Drawing.Color.White;
            this.prviLink.BackgroundGradientColor = System.Drawing.Color.White;
            this.prviLink.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.prviLink.BorderColor = System.Drawing.Color.Black;
            this.prviLink.BorderThickness = 1F;
            this.prviLink.Controls.Add(this.dodaj);
            this.prviLink.Controls.Add(this.ime_Mjesta);
            this.prviLink.Controls.Add(this.label1);
            this.prviLink.CustomGroupBoxColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.prviLink, AnimatorNS.DecorationType.None);
            this.prviLink.GroupImage = null;
            this.prviLink.GroupTitle = "";
            this.prviLink.Location = new System.Drawing.Point(136, 71);
            this.prviLink.Margin = new System.Windows.Forms.Padding(0);
            this.prviLink.Name = "prviLink";
            this.prviLink.Padding = new System.Windows.Forms.Padding(20);
            this.prviLink.PaintGroupBox = false;
            this.prviLink.RoundCorners = 10;
            this.prviLink.ShadowColor = System.Drawing.Color.DarkGray;
            this.prviLink.ShadowControl = false;
            this.prviLink.ShadowThickness = 3;
            this.prviLink.Size = new System.Drawing.Size(246, 172);
            this.prviLink.TabIndex = 18;
            this.prviLink.Visible = false;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.animator1.SetDecoration(this.r1, AnimatorNS.DecorationType.None);
            this.r1.Location = new System.Drawing.Point(21, 11);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(58, 17);
            this.r1.TabIndex = 19;
            this.r1.TabStop = true;
            this.r1.Text = "Prijatelj";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.animator1.SetDecoration(this.r2, AnimatorNS.DecorationType.None);
            this.r2.Location = new System.Drawing.Point(21, 34);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(71, 17);
            this.r2.TabIndex = 20;
            this.r2.TabStop = true;
            this.r2.Text = "Neprijatelj";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // drugiLink
            // 
            this.drugiLink.BackgroundColor = System.Drawing.Color.White;
            this.drugiLink.BackgroundGradientColor = System.Drawing.Color.White;
            this.drugiLink.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.drugiLink.BorderColor = System.Drawing.Color.Black;
            this.drugiLink.BorderThickness = 1F;
            this.drugiLink.Controls.Add(this.panel1);
            this.drugiLink.Controls.Add(this.comboBox1);
            this.drugiLink.Controls.Add(this.label3);
            this.drugiLink.Controls.Add(this.r3);
            this.drugiLink.Controls.Add(this.r4);
            this.drugiLink.Controls.Add(this.label4);
            this.drugiLink.Controls.Add(this.label5);
            this.drugiLink.CustomGroupBoxColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.drugiLink, AnimatorNS.DecorationType.None);
            this.drugiLink.GroupImage = null;
            this.drugiLink.GroupTitle = "";
            this.drugiLink.Location = new System.Drawing.Point(365, 71);
            this.drugiLink.Margin = new System.Windows.Forms.Padding(0);
            this.drugiLink.Name = "drugiLink";
            this.drugiLink.Padding = new System.Windows.Forms.Padding(20);
            this.drugiLink.PaintGroupBox = false;
            this.drugiLink.RoundCorners = 10;
            this.drugiLink.ShadowColor = System.Drawing.Color.DarkGray;
            this.drugiLink.ShadowControl = false;
            this.drugiLink.ShadowThickness = 3;
            this.drugiLink.Size = new System.Drawing.Size(354, 211);
            this.drugiLink.TabIndex = 21;
            this.drugiLink.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.r1);
            this.panel1.Controls.Add(this.r2);
            this.animator1.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(154, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 72);
            this.panel1.TabIndex = 24;
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.animator1.SetDecoration(this.r3, AnimatorNS.DecorationType.None);
            this.r3.Location = new System.Drawing.Point(176, 146);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(58, 17);
            this.r3.TabIndex = 22;
            this.r3.TabStop = true;
            this.r3.Text = "Marker";
            this.r3.UseVisualStyleBackColor = true;
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.animator1.SetDecoration(this.r4, AnimatorNS.DecorationType.None);
            this.r4.Location = new System.Drawing.Point(176, 169);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(48, 17);
            this.r4.TabIndex = 23;
            this.r4.TabStop = true;
            this.r4.Text = "Rutu";
            this.r4.UseVisualStyleBackColor = true;
            // 
            // MMarkeri
            // 
            this.animator1.SetDecoration(this.MMarkeri, AnimatorNS.DecorationType.None);
            this.MMarkeri.Location = new System.Drawing.Point(365, 1);
            this.MMarkeri.Name = "MMarkeri";
            this.MMarkeri.Size = new System.Drawing.Size(75, 23);
            this.MMarkeri.TabIndex = 24;
            this.MMarkeri.Text = "Markeri";
            this.MMarkeri.UseVisualStyleBackColor = true;
            this.MMarkeri.Click += new System.EventHandler(this.button1_Click);
            // 
            // treciLink
            // 
            this.treciLink.BackgroundColor = System.Drawing.Color.White;
            this.treciLink.BackgroundGradientColor = System.Drawing.Color.White;
            this.treciLink.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.None;
            this.treciLink.BorderColor = System.Drawing.Color.Black;
            this.treciLink.BorderThickness = 1F;
            this.treciLink.Controls.Add(this.konacno);
            this.treciLink.CustomGroupBoxColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.treciLink, AnimatorNS.DecorationType.None);
            this.treciLink.GroupImage = null;
            this.treciLink.GroupTitle = "";
            this.treciLink.Location = new System.Drawing.Point(665, 71);
            this.treciLink.Margin = new System.Windows.Forms.Padding(0);
            this.treciLink.Name = "treciLink";
            this.treciLink.Padding = new System.Windows.Forms.Padding(20);
            this.treciLink.PaintGroupBox = false;
            this.treciLink.RoundCorners = 10;
            this.treciLink.ShadowColor = System.Drawing.Color.DarkGray;
            this.treciLink.ShadowControl = false;
            this.treciLink.ShadowThickness = 3;
            this.treciLink.Size = new System.Drawing.Size(426, 252);
            this.treciLink.TabIndex = 22;
            this.treciLink.Visible = false;
            // 
            // Clear
            // 
            this.animator1.SetDecoration(this.Clear, AnimatorNS.DecorationType.None);
            this.Clear.Location = new System.Drawing.Point(1201, 35);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 28;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // load
            // 
            this.animator1.SetDecoration(this.load, AnimatorNS.DecorationType.None);
            this.load.Location = new System.Drawing.Point(1201, 1);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 29;
            this.load.Text = "load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // Pause
            // 
            this.animator1.SetDecoration(this.Pause, AnimatorNS.DecorationType.None);
            this.Pause.Image = global::Prototip_OPPlan.Properties.Resources.pause;
            this.Pause.Location = new System.Drawing.Point(1133, 1);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(72, 70);
            this.Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pause.TabIndex = 30;
            this.Pause.TabStop = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // save
            // 
            this.animator1.SetDecoration(this.save, AnimatorNS.DecorationType.None);
            this.save.Image = global::Prototip_OPPlan.Properties.Resources.disketica;
            this.save.Location = new System.Drawing.Point(0, 1);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(64, 70);
            this.save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.save.TabIndex = 27;
            this.save.TabStop = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            this.save.MouseLeave += new System.EventHandler(this.save_MouseLeave);
            this.save.MouseHover += new System.EventHandler(this.save_MouseHover);
            // 
            // delete_mode
            // 
            this.animator1.SetDecoration(this.delete_mode, AnimatorNS.DecorationType.None);
            this.delete_mode.Image = global::Prototip_OPPlan.Properties.Resources.kantica;
            this.delete_mode.Location = new System.Drawing.Point(63, 1);
            this.delete_mode.Name = "delete_mode";
            this.delete_mode.Size = new System.Drawing.Size(73, 70);
            this.delete_mode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.delete_mode.TabIndex = 26;
            this.delete_mode.TabStop = false;
            this.delete_mode.Click += new System.EventHandler(this.delete_mode_Click_1);
            this.delete_mode.MouseLeave += new System.EventHandler(this.delete_mode_MouseLeave);
            this.delete_mode.MouseHover += new System.EventHandler(this.delete_mode_MouseHover);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.play, AnimatorNS.DecorationType.None);
            this.play.Image = global::Prototip_OPPlan.Properties.Resources.play_flat2;
            this.play.Location = new System.Drawing.Point(1063, 1);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(70, 70);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play.TabIndex = 25;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click_1);
            this.play.MouseLeave += new System.EventHandler(this.play_MouseLeave);
            this.play.MouseHover += new System.EventHandler(this.play_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 860);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.load);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.delete_mode);
            this.Controls.Add(this.play);
            this.Controls.Add(this.treciLink);
            this.Controls.Add(this.MMarkeri);
            this.Controls.Add(this.drugiLink);
            this.Controls.Add(this.prviLink);
            this.Controls.Add(this.OP_Plan);
            this.Controls.Add(this.izvj);
            this.Controls.Add(this.gMapControl1);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.prviLink.ResumeLayout(false);
            this.prviLink.PerformLayout();
            this.drugiLink.ResumeLayout(false);
            this.drugiLink.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.treciLink.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_mode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TextBox ime_Mjesta;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button izvj;
        private System.Windows.Forms.RichTextBox konacno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OP_Plan;
        private AnimatorNS.Animator animator1;
        private CodeVendor.Controls.Grouper prviLink;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.RadioButton r2;
        private CodeVendor.Controls.Grouper drugiLink;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r4;
        private System.Windows.Forms.Button MMarkeri;
        private CodeVendor.Controls.Grouper treciLink;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox delete_mode;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.PictureBox Pause;
    }
}

