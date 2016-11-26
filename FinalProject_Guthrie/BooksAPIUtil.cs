using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For the Google Books API Search
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace FinalProject_Guthrie
{
    class BooksAPIUtil
    {

        private Book currentBook = new Book();

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

        public async void GetInfo(string pISBN)
        {
            string isbn = pISBN;
            var output = await SearchISBN(isbn);
            var result = output;

            if (result != null)
            {
                // currentBook = new Book();

                currentBook.Title = result.VolumeInfo.Title;
                currentBook.Author = result.VolumeInfo.Authors.FirstOrDefault();
                currentBook.ISBN = isbn;
                currentBook.DatePublished = DateTime.Parse(result.VolumeInfo.PublishedDate);

                // currentBook.SubCategories = result.VolumeInfo.Categories;

                currentBook.Category = result.VolumeInfo.MainCategory;
            }
            else
            {
                // lblStatusStrip.Text = "Book not found";
            }

        }

    }
}
