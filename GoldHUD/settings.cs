using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GoldHUD
{
    public partial class settings : Form
    {

        //Initialize Vars
        public int tfWidth = 900;
        public int tfHeight = 500;

        public string customStartParams = "";

        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult saveBox = MessageBox.Show("Do you want to save the changes?", "Save changes?", MessageBoxButtons.YesNo);
            if (saveBox == DialogResult.Yes)
            {
                tfWidth = (int) tfnum_width.Value;
                tfHeight = (int)tfnum_height.Value;

                customStartParams = txt_startParams.Text;
            }
        }
    }
}
