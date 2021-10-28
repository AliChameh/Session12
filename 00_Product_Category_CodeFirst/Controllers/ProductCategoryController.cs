using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00_Product_Category_CodeFirst.Controllers
{
    public class ProductCategoryController : Controller
    {
        #region [- ctor -]
        public ProductCategoryController()
        {
            ProductCategoryViewModel = new Models.ViewModels.ProductCategoryViewModel();
        }
        #endregion

        #region [- props -]
        public Models.ViewModels.ProductCategoryViewModel ProductCategoryViewModel { get; private set; }
        #endregion

        #region [- Actions -]

        #region [- index() -]
        public IActionResult Index()
        {
            return View(ProductCategoryViewModel.FillGrid());
        }
        #endregion

        #region [- Create() -]

        #region [- GET -]
        public IActionResult Create()
        {
            return View();
        }

        #endregion

        #region [- POST -]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ID,Title")]Dto.ProductCategory productCategory)
        {
            if (ModelState.IsValid)
            {
                ProductCategoryViewModel.Save(productCategory);
                return RedirectToAction("Index");
            }
            return View(productCategory);
        }
        #endregion

        #endregion

        #region [- Details(int? id) -]
        public IActionResult Details(int? id)
        {
            return View(ProductCategoryViewModel.ShowDetails(id));
        }
        #endregion

        #region [- Edit(int? id) -]

        #region [- GET -]
        public  IActionResult Edit(int? id)
        {
            return View(ProductCategoryViewModel.ShowDetails(id));
        }
        #endregion

        #region [- POST -]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("ID,Titel")]Dto.ProductCategory productCategory)
        {
            if (ModelState.IsValid)
            {
                ProductCategoryViewModel.Edit(productCategory);
                return RedirectToAction("Index");
            }
            return View(productCategory);
        }
        #endregion

        #endregion

        #region [- Delete(int? id) -]

        #region [- GET -]
        public IActionResult Delete(int? id)
        {
            return View(ProductCategoryViewModel.ShowDetails(id));
        }
        #endregion

        #region [- POST -]
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            ProductCategoryViewModel.Delete(id);
            return RedirectToAction("Index");
        }
        #endregion

        #endregion

        #endregion
    }
}
