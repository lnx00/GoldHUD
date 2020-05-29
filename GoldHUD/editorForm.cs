using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;

namespace GoldHUD
{
    public partial class editorForm : Form
    {

        private FileInfo fileInfo;
        private bool allowStart = true;

        //Syntax styles
        Style styleGreen = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        Style styleBoldGreen = new TextStyle(Brushes.Green, null, FontStyle.Bold);
        Style styleBlue = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
        Style styleRed = new TextStyle(Brushes.Red, null, FontStyle.Regular);
        Style styleDeepSkyBlue = new TextStyle(Brushes.DeepSkyBlue, null, FontStyle.Regular);
        Style styleBoldBlack = new TextStyle(Brushes.Black, null, FontStyle.Bold);
        Style stylePurple = new TextStyle(Brushes.Purple, null, FontStyle.Regular);

        Style styleTrue = new TextStyle(Brushes.Black, Brushes.LightGreen, FontStyle.Regular);
        Style styleFalse = new TextStyle(Brushes.White, Brushes.Red, FontStyle.Bold);

        public editorForm()
        {
            InitializeComponent();
        }

        #region Properties
        public FileInfo FileInfo
        {
            get
            {
                return fileInfo;
            }
            set
            {
                fileInfo = value;
                this.Text = FileInfo.Name + " | GoldHUD";
                using (StreamReader sr = new StreamReader(fileInfo.FullName))
                {
                    textBox.Text = sr.ReadToEnd();
                    if (textBox.Text.Contains("�"))
                    {
                        DialogResult binResult = MessageBox.Show("This file contains unknown characters." + Environment.NewLine + "Do you really want to edit this file?", "Unknown chars detected." ,MessageBoxButtons.YesNo);
                        if(binResult == DialogResult.No)
                        {
                            allowStart = false;
                        }
                    }
                }
                Invalidate();
            }
        }

        #endregion

        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editorForm_Load(object sender, EventArgs e)
        {
            if(!allowStart)
            {
                this.BeginInvoke(new MethodInvoker(closeMe));
            }
        }

        private void closeMe()
        {
            this.Close();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.ChangedRange.ClearFoldingMarkers();
            e.ChangedRange.SetFoldingMarkers("{", "}");
            e.ChangedRange.SetFoldingMarkers(@"//region\s.", @"//endregion");

            e.ChangedRange.ClearStyle(styleBoldGreen);
            e.ChangedRange.SetStyle(styleBoldGreen, @".\b(region)\s+(?<range>[\w_]+?)\b", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(styleBoldGreen, @".\b(fieldName).*", RegexOptions.Multiline);

            e.ChangedRange.ClearStyle(styleBoldBlack);
            e.ChangedRange.SetStyle(styleBoldBlack, @".\b(base).*", RegexOptions.Multiline);

            e.ChangedRange.ClearStyle(styleDeepSkyBlue);
            e.ChangedRange.SetStyle(styleDeepSkyBlue, @".\b(xpos|ypos|zpos).*", RegexOptions.Multiline);

            e.ChangedRange.ClearStyle(stylePurple);
            e.ChangedRange.SetStyle(stylePurple, @".\b(wide|tall).*", RegexOptions.Multiline);

            e.ChangedRange.ClearStyle(styleTrue);
            e.ChangedRange.SetStyle(styleTrue, @".\b(visible|enabled).*[1].", RegexOptions.Multiline);

            e.ChangedRange.ClearStyle(styleFalse);
            e.ChangedRange.SetStyle(styleFalse, @".\b(visible|enabled).*[0].", RegexOptions.Multiline);

            e.ChangedRange.ClearStyle(styleRed);
            e.ChangedRange.SetStyle(styleRed, @".\b(TeamRed).*", RegexOptions.Multiline);

            e.ChangedRange.ClearStyle(styleBlue);
            //e.ChangedRange.SetStyle(styleBlue, @"\s\w*", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(styleBlue, @".\b(ui_version|file|MeterFG|MeterBG|PaintBackgroundType|priority|priority_lodef|x_offset|y_offset|FlashColor|BgAlpha|icon_xposicon_ypos|MinimumWidth|MaximumWidth|StartRadius|EndRadius|MinimumHeight|MaximumHeight|IconScale|LineHeight|LineSpacing|CornerRadius|TeamBlue).*", RegexOptions.Multiline);

            e.ChangedRange.ClearStyle(styleGreen);
            e.ChangedRange.SetStyle(styleGreen, @"//.*$", RegexOptions.Multiline);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteFile();
        }

        public void deleteFile()
        {
            try
            {
                if (fileInfo != null)
                {
                    FileInfo selFileInfo = fileInfo;
                    DialogResult delResult = MessageBox.Show("Are you sure you want to delete '" + selFileInfo.Name + "'?", "Delete File", MessageBoxButtons.YesNo);
                    if (delResult == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        File.Delete(selFileInfo.FullName);
                    }
                }
                else
                {
                    MessageBox.Show("File Type not found.");
                    return;
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(System.NullReferenceException))
                {
                    MessageBox.Show("Please select a file first.");
                }
                else
                {
                    MessageBox.Show("An error occurred:" + Environment.NewLine + ex.Message, "Deleting failed.");
                }
            }
        }

        public void saveFile()
        {

            try
            {
                using (StreamWriter sw = new StreamWriter(fileInfo.FullName))
                {
                    sw.WriteLine(textBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + Environment.NewLine + ex.Message, "Saving failed.");
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileInfo.FullName))
                {
                    sw.WriteLine(textBox.Text);
                    MessageBox.Show(fileInfo.Name + " saved succesfully!", "Succesfully saved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + Environment.NewLine + ex.Message, "Saving failed.");
            }
        }
    }
}
