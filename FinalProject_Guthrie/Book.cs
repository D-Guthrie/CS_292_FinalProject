using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Guthrie
{
    class Book
    {
        private string _ISBN;
        private string _author;
        private string _title;
        private DateTime _datePublished;
        private string _category;
        private string _subcategories;

        public string ISBN
        {
            get { return _ISBN; }
        }

        public string Author
        {
            get { return _author; }
        }

        public string Title
        {
            get { return _title; }
        }

        public DateTime DatePublished
        {
            get { return _datePublished; }
        }

        public string Category
        {
            get { return _category; }
        }

        public string SubCategories
        {
            get { return _subcategories; }
        }
    }
}
