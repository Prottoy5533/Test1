using DevSkill.Library.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.Library.Framework
{
    public interface IBookRepository : IRepository<Book, int, FrameworkContext>
    {
        IList<Book> GetLatestBooks();
    }
}
