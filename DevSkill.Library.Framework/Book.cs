using DevSkill.Library.Data;
using System;

namespace DevSkill.Library.Framework
{
    public class Book : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Edition { get; set; }
    }
}
