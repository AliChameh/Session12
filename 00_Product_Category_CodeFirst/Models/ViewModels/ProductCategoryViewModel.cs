using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _00_Product_Category_CodeFirst.Infrastructure;

namespace _00_Product_Category_CodeFirst.Models.ViewModels
{
    public class ProductCategoryViewModel
    {
        #region [- ctor -]
        public ProductCategoryViewModel()
        {
            Ref_ProcductCategoryService = new Services.ProductCategoryService();
        }
        #endregion

        #region [- props for class -]
        public Services.ProductCategoryService Ref_ProcductCategoryService { get; private set; }
        #endregion
        
        #region [- FillGrid() -]
        public dynamic FillGrid()
        {
            var q = Convertor.DtoConvertor(Ref_ProcductCategoryService.Select());
            return q;
        }
        #endregion

        #region [- Save(Controllers.Dto.ProductCategory productCategory) -]
        public void Save(Controllers.Dto.ProductCategory productCategory)
        {
            Ref_ProcductCategoryService.Insert(Convertor.DtoConvertor(productCategory));
        }
        #endregion

        #region [- ShowDetails(int? id) -]
        public DomainModels.ProductCategory ShowDetails(int? id)
        {
            var q = Ref_ProcductCategoryService.FindId(id);
            return q;
        }
        #endregion

        #region [- Edit(Controllers.Dto.ProductCategory productCategory) -]
        public void Edit(Controllers.Dto.ProductCategory productCategory)
        {
            Ref_ProcductCategoryService.Update(Convertor.DtoConvertor(productCategory));
        }
        #endregion

        #region [- Delete(int? id) -]
        public void Delete(int? id)
        {
            Ref_ProcductCategoryService.Delete(id);
        }
        #endregion


    }
}
