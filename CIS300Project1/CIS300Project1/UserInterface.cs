﻿using System;
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

        private void uxOpenFileButton_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fn = uxOpenFileDialog.FileName;
                try
                {
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
                }
            }
        }

        private void uxSaveTounamentButton_Click(object sender, EventArgs e)
        {

        }
    }
}