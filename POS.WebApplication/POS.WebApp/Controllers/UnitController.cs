using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS.IBL;
using POS.Model;

namespace POS.WebApp.Controllers
{
    public class UnitController : Controller
    {
        private readonly IUnitRepo _iUnitRepo;
        private readonly INotyfService _notyf;
        public UnitController(IUnitRepo iUnitRepo, INotyfService notyf)
        {
            _iUnitRepo = iUnitRepo;
            _notyf = notyf;
        }
        // GET: UnitController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UnitController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UnitController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("UnitId,Unit")] UnitM unitM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int unit = await _iUnitRepo.Create(unitM);

                    if (unit > 0)
                    {
                        _notyf.Success("Unit Saved Successfully!!", 4);
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
            return View(unitM);
        }

        // GET: UnitController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UnitController/Edit/5
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

        // GET: UnitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UnitController/Delete/5
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
