using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetDressed
{
    /// <summary>
    /// Settings Dialog for GetDressed application.
    /// </summary>
    public partial class SettingsDialog : Form
    {
        bool result = false;

        public SettingsDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = true;
            this.Close();
        }

        /// <summary>
        /// Shows the SettingsDialog.
        /// </summary>
        /// <returns>Returns true if the user has clicked the Get Dressed-button.</returns>
        public new bool ShowDialog()
        {
            base.ShowDialog();
            return result;
        }

    }

}
