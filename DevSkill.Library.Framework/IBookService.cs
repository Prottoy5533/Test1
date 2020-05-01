using DevSkill.Library.Framework;
using System;
using System.Collections.Generic;

namespace DevSkill.Library.Framework
{
    public interface IBookService : IDisposable
    {
        (IList<Book> records, int total, int totalDisplay) GetBooks(int pageIndex, 
                                                                    int pageSize, 
                                                                    string searchText,
                                                                    string sortText);
        void CreateBook(Book book);
    }
}