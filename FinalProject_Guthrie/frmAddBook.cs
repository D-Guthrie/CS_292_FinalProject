using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_Guthrie
{
    public partial class frmAddBook : Form
    {
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void radSearchOnline_CheckedChanged(object sender, EventArgs e)
        {
            // enable Google API Search group box
            if (radSearchOnline.Checked)
            {
                grpSeachOnline.Enabled = true;
                grpEnterManually.Enabled = false;
            }
        }

        private void radEnterInfoManual_CheckedChanged(object sender, EventArgs e)
        {
            // enable Manual Entry group box
            grpSeachOnline.Enabled = false;
            grpEnterManually.Enabled = true;
        }

        private void btnSearchBooksAPI_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBookFromAPI_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBookManual_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developers.google.com/books/");
        }
    }
}
