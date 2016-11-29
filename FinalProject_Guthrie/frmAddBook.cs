using System;
using System.Linq;
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

        public void btnSearchBooksAPI_Click(object sender, EventArgs e)
        {
            if(txtISBNSearchAPI.Text != "" && (txtISBNSearchAPI.Text.Length == 13 || txtISBNSearchAPI.Text.Length == 10))
            {
                string isbn = txtISBNSearchAPI.Text;

                Book result = new Book();

                if (result != null)
                {
                    txtTitle.Text = result.Title;
                    txtAuthor.Text = result.Author;
                    txtISBN.Text = isbn;
                    dtpDatePublished.Value = result.DatePublished;
                    lstSubCategories.Items.Add(result.SubCategories);

                    // lstSubCategories.Items.Add(result.VolumeInfo.MainCategory);
                }
                else
                {
                    lblStatusStrip.Text = "Book not found";
                }
            }
            else
            {
                lblStatusStrip.Text = "Plese enter a valid ISBN";
            }
            

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developers.google.com/books/");
        }

    }

}
