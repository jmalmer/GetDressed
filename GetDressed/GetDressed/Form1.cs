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
        Image _coldDry, _coldSnowy, _warmDry, _warmRainy;

        Image _summerSuitComfort, _summerSuitCold;
        Image _springSuitCold, _springSuitComfort, _springSuitWarm;
        Image _winterSuitComfort, _winterSuitWarm;

        int _temp = 20;
        bool _rain = false;
        int _suit = 0; // 0 = summer suit, 1 = spring suit, 2 = winter suit

        public Form1()
        {
            InitializeComponent();
            this.TempTrackBar.Value = _temp;
            this.tempLabel.Text = _temp + "°";
            this.RainTrackBar.Value = 0;
        }

        // Updates the GUI-background according to weather conditions.
        private void UpdateWeather()
        {
            if (_temp < 0)
            {
                if (_rain)
                {
                    this.BackgroundImage = _coldSnowy;
                }
                else
                {
                    this.BackgroundImage = _coldDry;
                }
            }
            else
            {
                if (_rain)
                {
                    this.BackgroundImage = _warmRainy;
                }
                else
                {
                    this.BackgroundImage = _warmDry;
                }
            }
        }

        // Updates the appearance of the person in GUI according to
        // weather conditions and selected suit.
        private void UpdatePerson()
        {
            switch (_suit)
            {
                case 0: UseSummerSuit();
                    break;
                case 1: UseSpringSuit();
                    break;
                case 2: UseWinterSuit();
                    break;
            }
        }

        // Selects summer suit
        private void SelectSummerSuit_Click(object sender, EventArgs e)
        {
            _suit = 0;
            UpdatePerson();
        }

        // Selects spring suit
        private void SelectSpringSuit_Click(object sender, EventArgs e)
        {
            _suit = 1;
            UpdatePerson();
        }

        // Selects winter suit
        private void SelectWinterSuit_Click(object sender, EventArgs e)
        {
            _suit = 2;
            UpdatePerson();
        }

        // Updates the appearance of the person in GUI wearing a
        // summer suit according to weather conditions.
        private void UseSummerSuit()
        {
            // If it rains and temp below 25 or otherwise if temp below 20
            if ((_rain && (_temp < 25)) || (_temp < 20))
            {
                this.body.Image = _summerSuitCold;
            }
            else
            {
                this.body.Image = _summerSuitComfort;
            }
        }

        // Updates the appearance of the person in GUI wearing a
        // spring suit according to weather conditions.
        private void UseSpringSuit()
        {
            if ((_rain && (_temp < 15)) || (_temp < 10))
            {
                this.body.Image = _springSuitCold;
            }
            else if ((!_rain && (_temp > 20)) || (_temp > 25))
            {
                this.body.Image = _springSuitWarm;
            }
            else
            {
                this.body.Image = _springSuitWarm;
            }
        }

        // Updates the appearance of the person in GUI wearing a
        // winter suit according to weather conditions.
        private void UseWinterSuit()
        {
            if ((!_rain && (_temp > 10)) || (_temp > 15))
            {
                this.body.Image = _winterSuitWarm;
            }
            else
            {
                this.body.Image = _winterSuitComfort;
            }
        }

        // Loads resources for the form.
        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Loads images for weather
            _coldDry = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.colddry.png"));
            _coldSnowy = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.coldsnow.png"));
            _warmDry = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.warmdry.png"));
            _warmRainy = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.warmrain.png"));

            // Loads images for bodies.
            _summerSuitComfort = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.sumcomf.png"));
            _summerSuitCold = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.sumcold.png"));

            _springSuitWarm = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.sprwarm.png"));
            _springSuitComfort = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.sprcomf.png"));
            _springSuitCold = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.sprcold.png"));

            _winterSuitWarm = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.winwarm.png"));
            _winterSuitComfort = new Bitmap(assembly.GetManifestResourceStream("GetDressed.Resources.wincomf.png"));
        }

        private void RainTrackBar_Scroll(object sender, EventArgs e)
        {
            _rain = (this.RainTrackBar.Value > 5);
            UpdateWeather();
            UpdatePerson();
        }

        private void TempTrackBar_Scroll(object sender, EventArgs e)
        {
            _temp = this.TempTrackBar.Value;
            this.tempLabel.Text = _temp + "°";
            UpdateWeather();
            UpdatePerson();
        }

    }
}
