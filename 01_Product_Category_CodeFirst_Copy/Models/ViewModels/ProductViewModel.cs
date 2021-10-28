using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_Product_Category_CodeFirst_Copy.Infrastructure;

namespace _01_Product_Category_CodeFirst_Copy.Models.ViewModels
{
    public class ProductViewModel
    {
        #region [- ctor -]
        public ProductViewModel()
        {

        }
        #endregion

        #region [- props -]
        public Services.ProductService Ref_ProductService { get; private set; }
        #endregion

        #region [- FillGrid() -]
        public dynamic FillGrid()
        {
            var q = Convertor.DtoConvertor(Ref_ProductService.Select());
            return q;
        }
        #endregion

        #region [- FillCategory() -]
        public dynamic FillCategory()
        {
            var q = Convertor.DtoConvertor(Ref_ProductService.FillCategory());
            return q;
        }
        #endregion

        #region [- Save(Controllers.Dto.Product product) -]
        public void Save(Controllers.Dto.Product product)
        {
            var q = Convertor.DtoConvertor(product);
            Ref_ProductService.Insert(q);
        }
        #endregion

        #region [- Delete(int id) -]
        public void Delete(int id)
        {
            Ref_ProductService.Delete(id);
        }
        #endregion

        #region [- ShowDetails(int id) -]
        //public Models.DomainModels.Product ShowDetails(int id)
        //{
        //    var q = Ref_ProductService.FindId(id);
        //    return q;
        //}
        public Controllers.Dto.Product ShowDetails(int id)
        {
            var q = Ref_ProductService.FindId(id);
            var r = Convertor.DtoConvertor(q);
            return r;
        }
        #endregion

        #region [- Edit(Controllers.Dto.Product product) -]
        public void Edit(Controllers.Dto.Product product)
        {
            var q = Convertor.DtoConvertor(product);
            Ref_ProductService.Update(q);
        }
        #endregion
    }
}
