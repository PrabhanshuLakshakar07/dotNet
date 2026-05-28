using ConnectedDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConnectedDB.Controllers
{
    public class EmpController : Controller
    {
        private readonly MyDbContext _DbContext;

        //ctrl + . to generate private field 
        public EmpController(MyDbContext context)
        {
            _DbContext = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Emp> emps = _DbContext.emps.ToList();
            return View(emps);
        }

        [HttpGet]     // /Home/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertRecord(Emp emp)
        {

            //ModelState checks if class modelbinder has succesfully create emp
            //class emp class object and succesfully initailizeed that object, so that it can be passed as a parameter to a action method
            //
            if (ModelState.IsValid)
            {
                _DbContext.emps.Add(emp);
                _DbContext.SaveChanges();


            }


            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Emp empTobeEdited = _DbContext.emps.Find(id);

            if (empTobeEdited == null)
            {
                return NotFound();
            }

            return View(empTobeEdited);
        }


        [HttpPost]   // /Home/UpdateRecord
        public IActionResult UpdateRecord(Emp empTobeEdited)
        {
            


            if (ModelState.IsValid)
            {
                Emp toBeupdated = _DbContext.emps.Find(empTobeEdited.Id);
                toBeupdated.Name = empTobeEdited.Name;
                toBeupdated.Address = empTobeEdited.Address;
                _DbContext.SaveChanges();
            }
            return RedirectToAction("Index");




        }

        // /Home/Delete/id
        public IActionResult Delete(int id)
        {
            Emp empTobeDeleted = _DbContext.emps.Find(id);
            _DbContext.emps.Remove(empTobeDeleted);
            _DbContext.SaveChanges();
            return RedirectToAction("Index");
        }






    }
}
