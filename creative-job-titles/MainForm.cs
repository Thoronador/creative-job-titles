/* This program is free software. It comes without any warranty, to
 * the extent permitted by applicable law. You can redistribute it
 * and/or modify it under the terms of the Do What The Fuck You Want
 * To Public License, Version 2, as published by Sam Hocevar. See
 * http://www.wtfpl.net/ for more details. */

using System;
using System.Windows.Forms;

namespace creative_job_titles
{
    /// <summary>
    /// the main form of the application
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            generateThreeTitles();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            generateThreeTitles();
        }

        
        /// <summary>
        /// puts three different titles onto the label in the main window
        /// </summary>
        private void generateThreeTitles()
        {
            string one = Generator.Generate();
            string two = "";
            do
            {
                two = Generator.Generate();
            } while (one == two);
            string three = "";
            do
            {
                three = Generator.Generate();
            } while (one == three || three == two);
            lblJobTitles.Text = one + System.Environment.NewLine + System.Environment.NewLine + two + System.Environment.NewLine + System.Environment.NewLine + three;
        }
    }
}
