using Autofac;
using DevSkill.Library.Framework;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSkill.LibrarySystem.Web.Areas.Admin.Models
{
    public class BookModel : BookBaseModel
    {
        public BookModel(IBookService bookService) : base(bookService) { }
        public BookModel() : base() { }

        internal object GetBooks(DataTablesAjaxRequestModel tableModel)
        {
            var data = _bookService.GetBooks(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Title", "Author", "Edition", "PublicationDate" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Title,
                                record.Author,
                                record.Edition,
                                record.PublicationDate.ToString()
                        }
                    ).ToArray()

            };
        }
    }
}
