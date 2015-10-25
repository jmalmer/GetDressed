using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace GetDressed
{
    public partial class Form1 : Form
    {

        Image _coldAndDry, _coldAndSnowy, _warmAndDry, _warmAndRainy;

        Image _perfectShortsTshirt, _coldShortsTshirt;

        int _temp = 20;
        bool _persipitation = false;

        public Form1()
        {
            //_model = new Model();
            InitializeComponent();
            this.TempTrackBar.Value = _temp;
            this.tempLabel.Text = _temp + "°";
            this.RainTrackBar.Value = 0;

            //SetWeather();
            //SetComfort();
        }

        private void SetWeather()
        {
            if (_temp < 0)
            {
                if (_persipitation)
                {
                    this.BackgroundImage = _coldAndSnowy;
                }
                else
                {
                    this.BackgroundImage = _coldAndDry;
                }
            }
            else
            {
                if (_persipitation)
                {
                    this.BackgroundImage = _warmAndRainy;
                }
                else
                {
                    this.BackgroundImage = _warmAndDry;
                }
            }
        }

        private void SetComfort()
        {
            if (_temp < 10 || _persipitation)
            {
                this.body.Image = _coldShortsTshirt;
            }
            else
            {
                this.body.Image = _perfectShortsTshirt;
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            _coldAndDry = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.cold.PNG"));
            _coldAndSnowy = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.snow_cold.PNG"));
            _warmAndDry = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.Sunny.PNG"));
            _warmAndRainy = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.rain.PNG"));

            _perfectShortsTshirt = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.perfect.PNG"));
            _coldShortsTshirt = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.kall.PNG"));

        }

        private void HeadPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void RainTrackBar_Scroll(object sender, EventArgs e)
        {
            _persipitation = (this.RainTrackBar.Value > 5);
            this.SetWeather();

            SetComfort();

        }

        private void LegsPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void TorsoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void TempTrackBar_Scroll(object sender, EventArgs e)
        {
            _temp = this.TempTrackBar.Value;
            this.tempLabel.Text = _temp + "°";
            this.SetWeather();

            SetComfort();
        }

        private void tempLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
