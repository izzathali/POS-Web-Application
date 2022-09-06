using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS.IBL;
using POS.Model;

namespace POS.WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepo _iCategoryRepo;
        private readonly INotyfService _notyf;
        public CategoryController(ICategoryRepo iCategoryRepo, INotyfService notyf)
        {
            _iCategoryRepo = iCategoryRepo;
            _notyf = notyf;
        }
        // GET: CategoryController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("CategoryId,Category")] CategoryM categoryM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int cat = await _iCategoryRepo.Create(categoryM);

                    if (cat > 0)
                    {
                        _notyf.Success("Category Saved Successfully!!", 4);
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        _notyf.Error("Something went wrong!!", 4);
                    }
                }
            }
            catch
            {
                _notyf.Error("Something went wrong!!", 4);
            }
            return View(categoryM);

        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryController/Edit/5
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

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
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
