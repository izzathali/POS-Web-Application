using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS.IBL;
using POS.Model;

namespace POS.WebApp.Controllers
{
    public class SizeController : Controller
    {
        private readonly ISizeRepo _iSizeRepo;
        private readonly INotyfService _notyf;
        public SizeController(ISizeRepo iSizeRepo,INotyfService notyf)
        {
            _iSizeRepo = iSizeRepo;
            _notyf = notyf;
        }
        // GET: SizeController
        public async Task<ActionResult> Index()
        {
            return View(await _iSizeRepo.GetAll());
        }

        // GET: SizeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SizeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SizeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("SizeId,Size")] SizeM sizeM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int changes = await _iSizeRepo.Create(sizeM);

                    if (changes > 0)
                    {
                        _notyf.Success("Size Saved Successfully!!", 4);
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
            return View();

        }

        // GET: SizeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SizeController/Edit/5
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

        // GET: SizeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SizeController/Delete/5
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
