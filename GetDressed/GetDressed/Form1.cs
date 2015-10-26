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

        const int SummerSuit = 0;
        const int SpringSuit = 1;
        const int WinterSuit = 2;

        public Form1()
        {
            InitializeComponent();
            this.TempTrackBar.Value = _temp;
            this.TempLabel.Text = _temp + "°";
            this.RainTrackBar.Value = 0;
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
                case SummerSuit:
                    UseSummerSuit();
                    break;
                case SpringSuit:
                    UseSpringSuit();
                    break;
                case WinterSuit:
                    UseWinterSuit();
                    break;
            }
        }

        // Selects summer suit
        private void SelectSummerSuit_Click(object sender, EventArgs e)
        {
            _suit = SummerSuit;
            UpdatePerson();
        }

        // Selects spring suit
        private void SelectSpringSuit_Click(object sender, EventArgs e)
        {
            _suit = SpringSuit;
            UpdatePerson();
        }

        private void TempLabel_Click(object sender, EventArgs e)
        {

        }

        // Selects winter suit
        private void SelectWinterSuit_Click(object sender, EventArgs e)
        {
            _suit = WinterSuit;
            UpdatePerson();
        }

        // Act on settings dialog
        private void settingsIcon_click(object sender, EventArgs e)
        {
            SettingsDialog dialog = new SettingsDialog();
            // If the user has clicked on button Get Dressed, change to
            // suitable clothes based on selected weather conditions.
            if (dialog.ShowDialog()) 
            {
                if (_rain)
                {
                    if (_temp < 15)
                    {
                        _suit = WinterSuit;
                    }
                    else if (_temp < 25)
                    {
                        _suit = SpringSuit;
                    }
                    else
                    {
                        _suit = WinterSuit;
                    }
                }
                else
                {
                    if (_temp < 10)
                    {
                        _suit = WinterSuit;
                    }
                    else if (_temp < 20)
                    {
                        _suit = SpringSuit;
                    }
                    else
                    {
                        _suit = SummerSuit;
                    }
                }
                UpdatePerson();
            }
        }

        // Updates the appearance of the person in GUI wearing a
        // summer suit according to weather conditions.
        private void UseSummerSuit()
        {
            // If it rains and temp below 25 or otherwise if temp below 20
            if ((_rain && (_temp < 25)) || (_temp < 20))
            {
                this.Body.Image = _summerSuitCold;
            }
            else
            {
                this.Body.Image = _summerSuitComfort;
            }
        }

        // Updates the appearance of the person in GUI wearing a
        // spring suit according to weather conditions.
        private void UseSpringSuit()
        {
            if ((_rain && (_temp < 15)) || (_temp < 10))
            {
                this.Body.Image = _springSuitCold;
            }
            else if ((!_rain && (_temp > 20)) || (_temp > 25))
            {
                this.Body.Image = _springSuitWarm;
            }
            else
            {
                this.Body.Image = _springSuitComfort;
            }
        }

        // Updates the appearance of the person in GUI wearing a
        // winter suit according to weather conditions.
        private void UseWinterSuit()
        {
            if ((!_rain && (_temp > 10)) || (_temp > 15))
            {
                this.Body.Image = _winterSuitWarm;
            }
            else
            {
                this.Body.Image = _winterSuitComfort;
            }
        }

        // Response to changes in RainTrackBar
        private void RainTrackBar_Scroll(object sender, EventArgs e)
        {
            _rain = (this.RainTrackBar.Value > 5);
            UpdateWeather();
            UpdatePerson();
        }

        // Response to changes in TempTrackBar
        private void TempTrackBar_Scroll(object sender, EventArgs e)
        {
            _temp = this.TempTrackBar.Value;
            this.TempLabel.Text = _temp + "°";
            UpdateWeather();
            UpdatePerson();
        }

    }
}
