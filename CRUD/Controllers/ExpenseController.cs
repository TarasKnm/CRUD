using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CRUD.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ExpenseController(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Expense> objList = _db.Expenses;
            return View(objList);
        }
        //GET-Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //SET-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense expense)
        {
            _db.Expenses.Add(expense);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}