using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.Library.Data
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
