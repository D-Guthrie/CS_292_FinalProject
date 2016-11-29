using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Guthrie
{
    class SQLiteDatabaseUtil
    {
        // Connection string
        private const string dbBooks = "Data Source = BooksDB.db; Version = 3";

        // To connect/work with the database
        SQLiteConnection connection = new SQLiteConnection(dbBooks);
        SQLiteDataAdapter dataAdapter;
        SQLiteCommand command;
        DataSet ds = new DataSet();
        string sql;


    }
}
