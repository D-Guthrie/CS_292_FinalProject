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
using System.Reflection;
using System.IO;

// For the Google Books API Search
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace FinalProject_Guthrie
{
    public partial class frmAddBook : Form
    {
        public static BooksService service = new BooksService(new BaseClientService.Initializer
        {
            ApplicationName = "ISBNBookSearch",
            ApiKey = "PLACE API KEY HERE!!!",               // PLACE API KEY HERE!!!
        });

        public static async Task<Volume> SearchISBN(string isbn)
        {
            var result = await service.Volumes.List(isbn).ExecuteAsync();

            if (result != null && result.Items != null)
            {
                var item = result.Items.FirstOrDefault();
                return item;
            }
            return null;
        }

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

        public async void btnSearchBooksAPI_Click(object sender, EventArgs e)
        {
            string isbn = txtISBNSearchAPI.Text;
            var output = await SearchISBN(isbn);
            var result = output;

            if(result != null)
            {
                txtTitle.Text = result.VolumeInfo.Title;
                txtAuthor.Text = result.VolumeInfo.Authors.FirstOrDefault();
                txtISBN.Text = isbn;
                dtpDatePublished.Value = DateTime.Parse(result.VolumeInfo.PublishedDate);
                lstSubCategories.DataSource = result.VolumeInfo.Categories;
            }
            else
            {
                lblStatusStrip.Text = "Book not found";
            }

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
