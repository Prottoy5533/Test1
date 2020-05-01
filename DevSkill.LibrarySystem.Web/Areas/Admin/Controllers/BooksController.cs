﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevSkill.LibrarySystem.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Autofac;

namespace DevSkill.LibrarySystem.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        private readonly IConfiguration _configuration;
        public BooksController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var model = Startup.AutofacContainer.Resolve<BookModel>();
            return View(model);
        }

        public IActionResult AddBook()
        {
            var model = new CreateBookModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddBook(CreateBookModel model)
        {
            model.Create();
            return View(model);
        }

        public IActionResult GetBooks()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<BookModel>();
            var data = model.GetBooks(tableModel);
            return Json(data);
        }
    }
}