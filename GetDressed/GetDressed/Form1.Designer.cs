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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TempTrackBar = new System.Windows.Forms.TrackBar();
            this.RainTrackBar = new System.Windows.Forms.TrackBar();
            this.SelectSpring = new System.Windows.Forms.PictureBox();
            this.SelectWinterSuit = new System.Windows.Forms.PictureBox();
            this.SelectSummer = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tempLabel = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TempTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RainTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectSpring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectWinterSuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectSummer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.body)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // TempTrackBar
            // 
            this.TempTrackBar.Location = new System.Drawing.Point(247, 100);
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
            this.RainTrackBar.Location = new System.Drawing.Point(247, 210);
            this.RainTrackBar.Name = "RainTrackBar";
            this.RainTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RainTrackBar.Size = new System.Drawing.Size(45, 104);
            this.RainTrackBar.TabIndex = 7;
            this.RainTrackBar.Scroll += new System.EventHandler(this.RainTrackBar_Scroll);
            // 
            // SelectSpring
            // 
            this.SelectSpring.BackColor = System.Drawing.Color.Transparent;
            this.SelectSpring.Image = global::GetDressed.Properties.Resources.sprcomf;
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
            this.SelectWinterSuit.Image = global::GetDressed.Properties.Resources.wincomf;
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
            this.SelectSummer.Image = global::GetDressed.Properties.Resources.sumcomf;
            this.SelectSummer.Location = new System.Drawing.Point(49, 337);
            this.SelectSummer.Name = "SelectSummer";
            this.SelectSummer.Size = new System.Drawing.Size(51, 92);
            this.SelectSummer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectSummer.TabIndex = 10;
            this.SelectSummer.TabStop = false;
            this.SelectSummer.Click += new System.EventHandler(this.SelectSummerSuit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::GetDressed.Properties.Resources.settings;
            this.pictureBox2.Location = new System.Drawing.Point(256, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // tempLabel
            // 
            this.tempLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.Location = new System.Drawing.Point(247, 65);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(49, 32);
            this.tempLabel.TabIndex = 12;
            this.tempLabel.Text = "0°";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.Transparent;
            this.body.Image = ((System.Drawing.Image)(resources.GetObject("body.Image")));
            this.body.Location = new System.Drawing.Point(93, 91);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(106, 240);
            this.body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.body.TabIndex = 13;
            this.body.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.body);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SelectSummer);
            this.Controls.Add(this.SelectWinterSuit);
            this.Controls.Add(this.SelectSpring);
            this.Controls.Add(this.RainTrackBar);
            this.Controls.Add(this.TempTrackBar);
            this.Controls.Add(this.comboBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.body)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar TempTrackBar;
        private System.Windows.Forms.TrackBar RainTrackBar;
        private System.Windows.Forms.PictureBox SelectSpring;
        private System.Windows.Forms.PictureBox SelectWinterSuit;
        private System.Windows.Forms.PictureBox SelectSummer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.PictureBox body;
    }
}

