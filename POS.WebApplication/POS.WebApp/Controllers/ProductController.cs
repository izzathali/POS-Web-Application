using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using POS.IBL;
using POS.Model;

namespace POS.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo _iProductRepo;
        private readonly ICategoryRepo _iCategoryRepo;
        private readonly IBrandRepo _iBrandRepo;
        private readonly IColourRepo _iColourRepo;
        private readonly ISizeRepo _iSizeRepo;
        private readonly IUnitRepo _iUnitRepo;

        private readonly INotyfService _notyf;
        public ProductController(IProductRepo iProductRepo, INotyfService notyf, ICategoryRepo iCategoryRepo, IBrandRepo iBrandRepo, IColourRepo iColourRepo, ISizeRepo iSizeRepo, IUnitRepo iUnitRepo)
        {
            _iProductRepo = iProductRepo;
            _notyf = notyf;
            _iCategoryRepo = iCategoryRepo;
            _iBrandRepo = iBrandRepo;
            _iColourRepo = iColourRepo;
            _iSizeRepo = iSizeRepo;
            _iUnitRepo = iUnitRepo;
        }

        // GET: ProductController
        public async Task<ActionResult> Index()
        {
            return View(await _iProductRepo.GetAll());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: ProductController/Create
        public async Task<ActionResult> Create()
        {
            ViewData["CategoryId"] = new SelectList(await _iCategoryRepo.GetAll(), "CategoryId", "Category");
            ViewData["BrandId"] = new SelectList(await _iBrandRepo.GetAll(), "BrandId", "Brand");
            ViewData["ColourId"] = new SelectList(await _iColourRepo.GetAll(), "ColourId", "ColourCode");
            ViewData["SizeId"] = new SelectList(await _iSizeRepo.GetAll(), "SizeId", "Size");
            ViewData["UnitId"] = new SelectList(await _iUnitRepo.GetAll(), "UnitId", "Unit");

            ProductM product = new ProductM();
            product.subproducts.Add(new SubProductM() { SubProductId = 1 });

            return View(product);
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProductM productM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int changes = await _iProductRepo.Create(productM);

                    if (changes > 0)
                    {
                        _notyf.Success("Product Saved Successfully!!", 4);
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

            ViewData["CategoryId"] = new SelectList(await _iCategoryRepo.GetAll(), "CategoryId", "Category");
            ViewData["BrandId"] = new SelectList(await _iBrandRepo.GetAll(), "BrandId", "Brand");
            //ViewData["ColourId"] = new SelectList(await _iColourRepo.GetAll(), "ColourId", "ColourCode");
            //ViewData["SizeId"] = new SelectList(await _iSizeRepo.GetAll(), "SizeId", "Size");
            ViewData["UnitId"] = new SelectList(await _iUnitRepo.GetAll(), "UnitId", "Unit");

            return View(productM);
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
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

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
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
