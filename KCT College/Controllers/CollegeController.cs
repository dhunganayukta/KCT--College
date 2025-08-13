using KCT_College.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KCT_College.Controllers
{
    public class CollegeController : Controller
    {
        private readonly ICollegeService _collegeService;

        public CollegeController(ICollegeService collegeService)
        {
            _collegeService = collegeService;
        }
        // GET: CollegeController1
        public ActionResult Index()
        {
            var data = _collegeService.GetInfo();
            return View(data);
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
