﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_Guthrie
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnAdvancedFind_Click(object sender, EventArgs e)
        {
            frmAdvancedFind newAdvSearch = new frmAdvancedFind();

            newAdvSearch.ShowDialog();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {

        }
    }
}
