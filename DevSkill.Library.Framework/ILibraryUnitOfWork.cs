using DevSkill.Library.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.Library.Framework
{
    public interface ILibraryUnitOfWork : IUnitOfWork
    {
        IBookRepository BookRepositroy { get; set; }
    }
}
