namespace GetDressed
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
                _coldDry.Dispose();
                _coldSnowy.Dispose();
                _warmDry.Dispose();
                _warmRainy.Dispose();
                _summerSuitCold.Dispose();
                _summerSuitComfort.Dispose();
                _springSuitCold.Dispose();
                _springSuitComfort.Dispose();
                _springSuitWarm.Dispose();
                _winterSuitComfort.Dispose();
                _winterSuitWarm.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TempTrackBar = new System.Windows.Forms.TrackBar();
            this.RainTrackBar = new System.Windows.Forms.TrackBar();
            this.SelectSpring = new System.Windows.Forms.PictureBox();
            this.SelectWinterSuit = new System.Windows.Forms.PictureBox();
            this.SelectSummer = new System.Windows.Forms.PictureBox();
            this.SettingsIcon = new System.Windows.Forms.PictureBox();
            this.TempLabel = new System.Windows.Forms.Label();
            this.Body = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TempTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RainTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectSpring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectWinterSuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectSummer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TempTrackBar
            // 
            this.TempTrackBar.Location = new System.Drawing.Point(247, 58);
            this.TempTrackBar.Maximum = 40;
            this.TempTrackBar.Minimum = -20;
            this.TempTrackBar.Name = "TempTrackBar";
            this.TempTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TempTrackBar.Size = new System.Drawing.Size(45, 104);
            this.TempTrackBar.TabIndex = 5;
            this.TempTrackBar.TickFrequency = 5;
            this.TempTrackBar.Value = 10;
            this.TempTrackBar.Scroll += new System.EventHandler(this.TempTrackBar_Scroll);
            // 
            // RainTrackBar
            // 
            this.RainTrackBar.Location = new System.Drawing.Point(247, 227);
            this.RainTrackBar.Name = "RainTrackBar";
            this.RainTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RainTrackBar.Size = new System.Drawing.Size(45, 104);
            this.RainTrackBar.TabIndex = 7;
            this.RainTrackBar.Scroll += new System.EventHandler(this.RainTrackBar_Scroll);
            // 
            // SelectSpring
            // 
            this.SelectSpring.BackColor = System.Drawing.Color.Transparent;
            this.SelectSpring.Image = ((System.Drawing.Image)(resources.GetObject("SelectSpring.Image")));
            this.SelectSpring.Location = new System.Drawing.Point(118, 337);
            this.SelectSpring.Name = "SelectSpring";
            this.SelectSpring.Size = new System.Drawing.Size(63, 92);
            this.SelectSpring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectSpring.TabIndex = 8;
            this.SelectSpring.TabStop = false;
            this.SelectSpring.Click += new System.EventHandler(this.SelectSpringSuit_Click);
            // 
            // SelectWinterSuit
            // 
            this.SelectWinterSuit.BackColor = System.Drawing.Color.Transparent;
            this.SelectWinterSuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelectWinterSuit.Image = ((System.Drawing.Image)(resources.GetObject("SelectWinterSuit.Image")));
            this.SelectWinterSuit.Location = new System.Drawing.Point(198, 337);
            this.SelectWinterSuit.Name = "SelectWinterSuit";
            this.SelectWinterSuit.Size = new System.Drawing.Size(55, 92);
            this.SelectWinterSuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectWinterSuit.TabIndex = 9;
            this.SelectWinterSuit.TabStop = false;
            this.SelectWinterSuit.Click += new System.EventHandler(this.SelectWinterSuit_Click);
            // 
            // SelectSummer
            // 
            this.SelectSummer.BackColor = System.Drawing.Color.Transparent;
            this.SelectSummer.Image = ((System.Drawing.Image)(resources.GetObject("SelectSummer.Image")));
            this.SelectSummer.Location = new System.Drawing.Point(49, 337);
            this.SelectSummer.Name = "SelectSummer";
            this.SelectSummer.Size = new System.Drawing.Size(51, 92);
            this.SelectSummer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectSummer.TabIndex = 10;
            this.SelectSummer.TabStop = false;
            this.SelectSummer.Click += new System.EventHandler(this.SelectSummerSuit_Click);
            // 
            // SettingsIcon
            // 
            this.SettingsIcon.BackColor = System.Drawing.Color.Transparent;
            this.SettingsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingsIcon.Image = global::GetDressed.Properties.Resources.settings;
            this.SettingsIcon.Location = new System.Drawing.Point(12, 12);
            this.SettingsIcon.Name = "SettingsIcon";
            this.SettingsIcon.Size = new System.Drawing.Size(40, 40);
            this.SettingsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsIcon.TabIndex = 11;
            this.SettingsIcon.TabStop = false;
            this.SettingsIcon.Click += new System.EventHandler(this.settingsIcon_click);
            // 
            // TempLabel
            // 
            this.TempLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TempLabel.BackColor = System.Drawing.Color.Transparent;
            this.TempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempLabel.Location = new System.Drawing.Point(192, 58);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(49, 32);
            this.TempLabel.TabIndex = 12;
            this.TempLabel.Text = "0°";
            this.TempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TempLabel.Click += new System.EventHandler(this.TempLabel_Click);
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.Transparent;
            this.Body.Image = ((System.Drawing.Image)(resources.GetObject("Body.Image")));
            this.Body.Location = new System.Drawing.Point(93, 91);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(106, 240);
            this.Body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Body.TabIndex = 13;
            this.Body.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(247, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 38);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.SettingsIcon);
            this.Controls.Add(this.SelectSummer);
            this.Controls.Add(this.SelectWinterSuit);
            this.Controls.Add(this.SelectSpring);
            this.Controls.Add(this.RainTrackBar);
            this.Controls.Add(this.TempTrackBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Get Dressed prototype";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TempTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RainTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectSpring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectWinterSuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectSummer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar TempTrackBar;
        private System.Windows.Forms.TrackBar RainTrackBar;
        private System.Windows.Forms.PictureBox SelectSpring;
        private System.Windows.Forms.PictureBox SelectWinterSuit;
        private System.Windows.Forms.PictureBox SelectSummer;
        private System.Windows.Forms.PictureBox SettingsIcon;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.PictureBox Body;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

