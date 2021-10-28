using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00_Product_Category_CodeFirst.Controllers
{
    public class ProductController : Controller
    {
        #region [- ctor -]
        public ProductController()
        {
            ProductViewModel = new Models.ViewModels.ProductViewModel();
        }
        #endregion

        #region [- props -]
        public Models.ViewModels.ProductViewModel ProductViewModel { get; private set; }
        #endregion

        #region [- Actions -]

        #region [- Index() -]
        public IActionResult Index()
        {
            return View(ProductViewModel.FillGrid());
        }
        #endregion

        #region [- Create() -]

        #region [- GET -]
        public IActionResult Create()
        {
            ViewBag.Category = new SelectList(ProductViewModel.FillCategory(), "Id", "Title");
            return View();
        }
        #endregion

        #region [- POST -]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind(include: "ID,Category,Title,UnitPrice,Quantity")] Dto.Product product)
        {
            if (ModelState.IsValid)
            {
                ProductViewModel.Save(product);
                return RedirectToAction("Index");
            }
            ViewBag.Category = new SelectList(ProductViewModel.FillCategory(), "Id", "Title", product.Category);
            return View(product);
        }
        #endregion

        #endregion

        #region [- Edit(int? id) -]

        #region [- GET -]
        public IActionResult Edit(int? id)
        {
            ViewBag.Category =
                new SelectList(ProductViewModel.FillCategory(), "Id", "Titel", ProductViewModel.ShowDetails(id).Category);
            return View(ProductViewModel.ShowDetails(id));
        }
        #endregion

        #region [- POST -]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind(include: "ID,Category,Code,Name,Amount,UnitPrice")] Dto.Product product)
        {
            if (ModelState.IsValid)
            {
                ProductViewModel.Edit(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }
        #endregion

        #endregion

        #region [- Details(int? id) -]
        public IActionResult Details(int? id)
        {
            return View(ProductViewModel.ShowDetails(id));
        }
        #endregion

        #region [- Delete(int? id) -]

        #region [- GET -]
        public IActionResult Delete(int? id)
        {
            return View(ProductViewModel.ShowDetails(id));
        }
        #endregion

        #region [- POST -]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            ProductViewModel.Delete(id);
            return RedirectToAction("Index");
        }
        #endregion

        #endregion

        #endregion

    }
}
