using KCT_College.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KCT_College.Controllers
{
    public class CollegeController1 : Controller
    {
       private readonly CollegeInterface _collegeInterface;
        public CollegeController1(CollegeInterface collegeInterface)
        {
            _collegeInterface = collegeInterface;
        }
        // GET: CollegeController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: CollegeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CollegeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CollegeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CollegeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CollegeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CollegeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CollegeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
