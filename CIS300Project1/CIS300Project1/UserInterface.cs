/*
 UserInterface.cs
 Diqing Wu
 
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS300Project1
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// OpenFileButton, open a file and pass it into matching finder and get the correct result and display it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenFileButton_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fn = uxOpenFileDialog.FileName;
                try
                {
                    uxTextBox.Text = MatchingFinder.GetTournament(fn);
                    uxSaveTounamentButton.Enabled = true;
                    // Read and process the file.
                }
                catch (Exception ex)
                {
                    // If any exception of type Exception (i.e., any
                    // exception at all) occurs in the above try-block,
                    // control will immediately transfer here. The
                    // variable ex will contain the exception.
                    //
                    MessageBox.Show(ex.ToString());
                    uxTextBox.Text = (ex.ToString());
                }
            }
        }
        /// <summary>
        /// SaveTounamentButton, will save the result in the text file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSaveTounamentButton_Click(object sender, EventArgs e)
        {
            // save file
            if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(uxSaveFileDialog.FileName, uxTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
    }
}
