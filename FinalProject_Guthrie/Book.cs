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
        private List<string> _subcategories;

        public string ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public DateTime DatePublished
        {
            get { return _datePublished; }
            set { _datePublished = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public List<string> SubCategories
        {
            get { return _subcategories; }
            set { _subcategories = value; }
        }
    }
}
