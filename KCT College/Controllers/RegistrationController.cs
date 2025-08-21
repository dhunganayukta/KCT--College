using KCT_College.Models;
using KCT_College.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace KCT_College.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IRepository<Registration> _repository;

        public RegistrationController(IRepository<Registration> repository)
        {
            _repository = repository;
        }

        // MVC Action: show all registrations in a view
        public async Task<IActionResult> Index()
        {
            var registrations = await _repository.GetAllAsync();
            return View(registrations);
        }

        // MVC Details view
        public async Task<IActionResult> Details(int id)
        {
            var registration = await _repository.GetByIdAsync(id);
            if (registration == null)
                return NotFound();

            return View(registration);
        }

        // MVC Create view
        public IActionResult Create()
        {
            return View();
        }

        // MVC POST Create (form submit)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Registration model)
        {
            if (ModelState.IsValid)
            {
                await _repository.AddAsync(model);
                await _repository.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // MVC Edit view
        public async Task<IActionResult> Edit(int id)
        {
            var registration = await _repository.GetByIdAsync(id);
            if (registration == null)
                return NotFound();

            return View(registration);
        }

        // MVC POST Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Registration model)
        {
            if (id != model.ID)
                return BadRequest();

            if (ModelState.IsValid)
            {
                _repository.Update(model);
                await _repository.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // MVC Delete view
        public async Task<IActionResult> Delete(int id)
        {
            var registration = await _repository.GetByIdAsync(id);
            if (registration == null)
                return NotFound();

            return View(registration);
        }

        // MVC POST Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registration = await _repository.GetByIdAsync(id);
            if (registration == null)
                return NotFound();

            _repository.Remove(registration);
            await _repository.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // --------- API endpoints for AJAX ---------

        // GET: /Registration/GetAll  (returns JSON list)
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var registrations = await _repository.GetAllAsync();
            return Json(registrations);
        }

        // POST: /Registration/Create (accepts JSON body)
        [HttpPost]
        public async Task<IActionResult> CreateJson([FromBody] Registration model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _repository.AddAsync(model);
            await _repository.SaveChangesAsync();

            return Json(new { message = "Registration created successfully" });
        }

        // POST: /Registration/Delete/{id} (JSON delete)
        [HttpPost]
        public async Task<IActionResult> DeleteJson(int id)
        {
            var registration = await _repository.GetByIdAsync(id);
            if (registration == null)
                return NotFound();

            _repository.Remove(registration);
            await _repository.SaveChangesAsync();

            return Json(new { message = "Deleted successfully" });
        }
    }
}
