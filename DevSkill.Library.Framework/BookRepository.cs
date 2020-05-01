using DevSkill.Library.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DevSkill.Library.Framework
{
    public class BookRepository : Repository<Book, int, FrameworkContext>, IBookRepository
    {
        public BookRepository(FrameworkContext dbContext)
            : base(dbContext)
        {

        }

        public IList<Book> GetLatestBooks()
        {
            return Get(x => x.PublicationDate < DateTime.Now.AddDays(-7)).ToList();
        }
    }
}
