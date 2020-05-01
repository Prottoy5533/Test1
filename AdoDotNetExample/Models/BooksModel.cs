using DevSkill.Library.Framework;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSkill.LibrarySystem.Web.Areas.Admin.Models
{
    //public class BooksModel : AdminBaseModel, IDisposable
    //{
    //    private readonly IBookService _bookService;
    //    public BooksModel(IConfiguration configuration)
    //    {
    //        _bookService = new BookServiceAdoDotNet(configuration.GetConnectionString("DefaultConnection"));
    //    }

    //    public void Dispose()
    //    {
    //        _bookService?.Dispose();
    //    }

    //    internal object GetBooks(DataTablesAjaxRequestModel tableModel)
    //    {
    //        var data = _bookService.GetBooks(
    //            tableModel.PageIndex,
    //            tableModel.PageSize,
    //            tableModel.SearchText,
    //            tableModel.GetSortText(new string[] { "Title", "Author", "Edition", "PublicationDate" }));

    //        return new
    //        {
    //            recordsTotal = data.total,
    //            recordsFiltered = data.totalDisplay,
    //            data = (from record in data.records
    //                    select new string[]
    //                    {
    //                            record.Title,
    //                            record.Author,
    //                            record.Edition,
    //                            record.PublicationDate.ToString()
    //                    }
    //                ).ToArray()

    //        };
    //    }
    //}
}
