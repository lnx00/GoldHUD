using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using GoldHUD.Properties;

namespace GoldHUD
{
    public partial class TF2 : Form
    {

        public int tfWidth = 900;
        public int tfHeight = 500;

        private settings settings;

        Process hlProcess;

        public TF2()
        {
            InitializeComponent();
        }

        private void TF2_Load(object sender, EventArgs e)
        {

            //Resize this form & Get settings
            this.Width = tfWidth + 14;

            //Start TF2
            Process[] tfList = Process.GetProcessesByName("hl2");
            if (tfList.Length == 0)
            {
                Process tf = Process.Start(@"D:\Programme\Steam\Steam.exe", "-applaunch 440 -w " + tfWidth + " -h " + tfHeight + " -sw -dev -novid -nopreload " + settings.customStartParams);
                tf.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                loopHLprocess();
            }
            else if (tfList.Length > 1)
            {
                //More than 1 tf2 found
                for (int i = 0; i < tfList.Length - 1; i++)
                {
                    tfList.FirstOrDefault().Kill();
                }
                hlProcess = tfList.FirstOrDefault();
            }
            else
            {
                //1 tf2 found
                hlProcess = tfList.FirstOrDefault();
            }

        }

        private async void loopHLprocess()
        {
            while (setHLprocess())
            {
                //HL process not found
                await Task.Delay(1000);
            }
            //HL process found
            await Task.Delay(1000);
            MoveWindow(hlProcess.MainWindowHandle, this.Location.X + 7, this.Location.Y + 30, tfWidth, tfHeight, true);
            return;
        }

        private bool setHLprocess()
        {
            try
            {
                Process[] tfList = Process.GetProcessesByName("hl2");
                if (tfList.Length != 0)
                {
                    hlProcess = tfList.FirstOrDefault();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception)
            {
                return true;
            }
        }

        private void TF2_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //foreach (Process process in Process.GetProcessesByName("hl2")) {process.Kill();}
                hlProcess.Kill();
            }
            catch (Exception){}
        }

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        private void TF2_Move(object sender, EventArgs e)
        {
            try
            {
                //foreach (Process process in Process.GetProcessesByName("hl2"))
                //{
                //    MoveWindow(process.MainWindowHandle, this.Location.X + 7, this.Location.Y + 30, tfWidth, tfHeight, true);
                //}
                MoveWindow(hlProcess.MainWindowHandle, this.Location.X + 7, this.Location.Y + 30, tfWidth, tfHeight, true);
            }
            catch(Exception){}
        }

    }
}
