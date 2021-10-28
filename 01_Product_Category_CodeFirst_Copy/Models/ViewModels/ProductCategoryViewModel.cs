using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_Product_Category_CodeFirst_Copy.Models.Services;
using _01_Product_Category_CodeFirst_Copy.Infrastructure;


namespace _01_Product_Category_CodeFirst_Copy.Models.ViewModels
{
    public class ProductCategoryViewModel
    {
        #region [- ctor -]
        public ProductCategoryViewModel()
        {

        }
        #endregion

        #region [- props -]
        public ProductCategoryService Ref_ProductCategoryService { get; private set; }
        #endregion

        #region [- FillGrid() -]
        public dynamic FillGrid()
        {
            var q = Convertor.DtoConvertor(Ref_ProductCategoryService.Select());
            return q;
        }
        #endregion

        #region [- Save(Controllers.Dto.ProductCategory productCategory) -]
        public void Save(Controllers.Dto.ProductCategory productCategory)
        {
            var q = Convertor.DtoConvertor(productCategory);
            Ref_ProductCategoryService.Insert(q);
        }
        #endregion

        #region [- ShowDetails(int? id) -] 
        public DomainModels.ProductCategory ShowDetails(int? id)
        {
            var q = Ref_ProductCategoryService.FindId(id);
            return q;
        }
        #endregion

        #region [- Edit() -]
        public void Edit(Controllers.Dto.ProductCategory productCategory)
        {
            var q = Convertor.DtoConvertor(productCategory);
            Ref_ProductCategoryService.Update(q);
        }
        #endregion

        #region [- Delete(int id) -]
        public void Delete(int id)
        {
            Ref_ProductCategoryService.Delete(id);
        }
        #endregion
    }
}
