using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS.IBL;
using POS.Model;

namespace POS.WebApp.Controllers
{
    public class ColourController : Controller
    {
        private readonly IColourRepo _iColourRepo;
        private readonly INotyfService _notyf;
        public ColourController(IColourRepo iColourRepo, INotyfService notyf)
        {
            _iColourRepo = iColourRepo;
            _notyf = notyf;
        }
        // GET: ColourController
        public async Task<ActionResult> Index()
        {
            return View(await _iColourRepo.GetAll());
        }

        // GET: ColourController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ColourController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ColourController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("ColourId,ColourCode")] ColourM colourM)
        {
            try
            {
                int changes = await _iColourRepo.Create(colourM);

                if (changes > 0)
                {
                    _notyf.Success("Colour Saved Successfully!!", 4);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    _notyf.Error("Something went wrong!!", 4);
                }
            }
            catch
            {
                _notyf.Error("Something went wrong!!", 4);
            }
            return View();
        }

        // GET: ColourController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ColourController/Edit/5
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

        // GET: ColourController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ColourController/Delete/5
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
