using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.Library.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
