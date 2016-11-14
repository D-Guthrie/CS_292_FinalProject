using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string isbn = "978-1118847282";

            try
            {
                new Program().Run().Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    MessageBox.Show("ERROR: " + e.Message);
                }
            }

            //var output = BookSearch.SearchISBN(isbn);

            //var result = output.Result;
            //MessageBox.Show("\nBook Name: " + result.VolumeInfo.Title);
            //MessageBox.Show("Author: " + result.VolumeInfo.Authors.FirstOrDefault());
            //MessageBox.Show("Publisher: " + result.VolumeInfo.Publisher);
        }

        private async Task Run()
        {
            UserCredential credential;
            using (var stream = new Google.Apis.Books.v1.BooksService
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { BooksService.Scope.Books },
                    "user", CancellationToken.None, new FileDataStore("Books.ListMyLibrary"));


            // Create the service.
            var service = new BooksService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Books API Sample",
            }); }

        private void btnAddBookManual_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developers.google.com/books/");
        }

        //public static async Task<Volume> SearchISBN(string isbn)
        //{
        //    var result = await service.Volumes.List(isbn).ExecuteAsync();
        //    if (result != null && result.Items != null)
        //    {
        //        var item = result.Items.FirstOrDefault();
        //        return item;
        //    }
        //    return null;
        //}

        //public static BooksService service = new BooksService(new BaseClientService.Initializer
        //    {
        //        ApplicationName = "ISBNBookSearch",
        //        ApiKey = "ABCDEFGHIJKLMNOP123456789",  
        //    });     // Place Google Books API key here

        //public void TestIsbnSearch()
        //{
        //    string isbn = "0071807993";
        //    var output = BookSearch.SearchISBN(isbn);

        //    var result = output.Result;
        //    MessageBox.Show("\nBook Name: " + result.VolumeInfo.Title);
        //    MessageBox.Show("Author: " + result.VolumeInfo.Authors.FirstOrDefault());
        //    MessageBox.Show("Publisher: " + result.VolumeInfo.Publisher);
        //}
    }

    public class BookSearch
    {
        //You need to substitute this with your own API key.
        //For more information, visit http://wp.me/paUXZ-TY 
        private static string API_KEY = "ABCDEFGHIJKLMNOP123456789";  // Place Google Books API key here

        public static BooksService service = new BooksService(new BaseClientService.Initializer
        {
            ApplicationName = "ISBNBookSearch",
            ApiKey = API_KEY,
        });

        public static async Task<Volume> SearchISBN(string isbn)
        {
            MessageBox.Show("Executing a book search request for ISBN: {0} ...", isbn);
            var result = await service.Volumes.List(isbn).ExecuteAsync();

            if (result != null && result.Items != null)
            {
                var item = result.Items.FirstOrDefault();
                return item;
            }
            return null;
        }

    }


}
