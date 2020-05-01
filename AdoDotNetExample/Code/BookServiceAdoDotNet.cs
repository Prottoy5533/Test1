using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DevSkill.Library.Data;

namespace DevSkill.Library.Framework
{
    public class BookServiceAdoDotNet : IBookService
    {
        private string _connectionString;

        public BookServiceAdoDotNet(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            
        }

        public (IList<Book> records, int total, int totalDisplay) GetBooks(int pageIndex, 
            int pageSize, string searchText, string sortText)
        {
            using var dbProvider = new SqlServerDataProvider<Book>(_connectionString);
            var books = dbProvider.GetData("GetBooks", new List<(string, object, bool)>
            {
                ("PageIndex", pageIndex, false),
                ("PageSize", pageSize , false),
                ("SearchText", searchText , false),
                ("OrderBy", sortText, false),
                ( "Total", 0, true),
                ( "TotalDisplay", 0, true)
            });

            return (books.result, books.total, books.totalDisplay);
        }
    }
}
