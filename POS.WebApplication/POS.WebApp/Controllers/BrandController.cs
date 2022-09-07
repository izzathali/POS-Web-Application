using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using POS.IBL;
using POS.Model;

namespace POS.WebApp.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandRepo _iBrandRepo;
        private readonly INotyfService _notyf;

        public BrandController(IBrandRepo iBrandRepo,INotyfService notyf)
        {
            _iBrandRepo = iBrandRepo;
            _notyf = notyf;
        }
        // GET: BrandController
        public  ActionResult Index()
        {
            return View();
        }

        // GET: BrandController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BrandController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BrandController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("BrandId,Brand")] BrandM brandM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int changes = await _iBrandRepo.Create(brandM);
                    if (changes > 0)
                    {
                        _notyf.Success("Brand Saved Successfully!!", 4);
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        _notyf.Error("Something went wrong!!", 4);
                    }
                }
            }
            catch (Exception ex)
            {
                _notyf.Error("Something went wrong!!", 4);
            }
            return View(brandM);

        }

        // GET: BrandController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BrandController/Edit/5
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

        // GET: BrandController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BrandController/Delete/5
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
