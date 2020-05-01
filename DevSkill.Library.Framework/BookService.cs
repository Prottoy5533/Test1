using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DevSkill.Library.Framework
{
    public class BookService : IBookService, IDisposable
    {
        private ILibraryUnitOfWork _libraryUnitOfWork;

        public BookService(ILibraryUnitOfWork libraryUnitOfWork)
        {
            _libraryUnitOfWork = libraryUnitOfWork;
        }

        public void CreateBook(Book book)
        {
            _libraryUnitOfWork.BookRepositroy.Add(book);
            _libraryUnitOfWork.Save();
        }

        public void Dispose()
        {
            _libraryUnitOfWork?.Dispose();
        }

        public (IList<Book> records, int total, int totalDisplay) GetBooks(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _libraryUnitOfWork.BookRepositroy.GetAll().ToList();
            return (result, 0, 0);
        }
    }
}
