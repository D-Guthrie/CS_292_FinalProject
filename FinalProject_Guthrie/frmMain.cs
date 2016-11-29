/*
 * Name: David Guthrie
 * Project: Final Project - Book Catalog
 * Date: 10/24/16
 * Purpose: To keep track of a collection of books, and to allow searching
 * 
 */

using System;
using System.Windows.Forms;

namespace FinalProject_Guthrie
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSeachMain_Click(object sender, EventArgs e)
        {
            frmSearch newSearch = new frmSearch();

            newSearch.ShowDialog();
        }

        private void btnAddBookMain_Click(object sender, EventArgs e)
        {
            frmAddBook newAddBook = new frmAddBook();

            newAddBook.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // lblNumberOfBooks.Text=
        }
    }
}
