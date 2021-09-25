using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private EMSContext db;
        public EmployeeController(EMSContext _db)
        {
            db = _db;
        }
        public ActionResult Index()
        {
            var employees=db.Persons.ToList();
            return View(employees);
        }

        public ActionResult Detail([FromQuery] int id)
        {
            var employee = db.Persons.Find(id);
            return View(employee);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add([FromForm] Person person)
        {
            db.Persons.Add(person);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var employee = db.Persons.Find(id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(Person person)
        {
            db.Persons.Attach(person);
            db.Persons.Update(person);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int id)
        {
            var employee = db.Persons.Find(id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Delete(Person person)
        {
            db.Persons.Attach(person);
            db.Persons.Remove(person);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }

    
}
