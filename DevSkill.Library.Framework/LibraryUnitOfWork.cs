using DevSkill.Library.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.Library.Framework
{
    public class LibraryUnitOfWork : UnitOfWork, ILibraryUnitOfWork
    {
        public IBookRepository BookRepositroy { get; set; }
        public LibraryUnitOfWork(FrameworkContext context, IBookRepository bookRepositroy)
            : base(context)
        {
            BookRepositroy = bookRepositroy;
        }
    }
}
