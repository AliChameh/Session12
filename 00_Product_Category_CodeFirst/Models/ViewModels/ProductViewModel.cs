using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _00_Product_Category_CodeFirst.Infrastructure;
using _00_Product_Category_CodeFirst.Models.Services;

namespace _00_Product_Category_CodeFirst.Models.ViewModels
{
    public class ProductViewModel
    {
        #region [- ctor -]
        public ProductViewModel()
        {
            ProductService = new ProductService();
        }
        #endregion

        #region [- props for class -]
        public ProductService ProductService { get; private set; }
        #endregion

        #region [- FillGrid() -]
        public dynamic FillGrid()
        {
            return Convertor.DtoConvertor(ProductService.Select());
        }
        #endregion

        #region [- FillCategory() -]
        public List<Controllers.Dto.ProductCategory> FillCategory()
        {
            return Convertor.DtoConvertor(ProductService.FillCategory());
        }
        #endregion

        #region [- Save(Controllers.Dto.Product product) -]
        public void Save(Controllers.Dto.Product product)
        {
            var q = Convertor.DtoConvertor(product);
            ProductService.Insert(q);
        }
        #endregion
        #region [- ShowDetails(int? id) -]
        //public DomainModels.Product ShowDetails(int? id)
        //{
        //    return ProductService.FindId(id);
        //}

        public Controllers.Dto.Product ShowDetails(int? id)
        {
            return Convertor.DtoConvertor(ProductService.FindId(id));
        }
        #endregion

        #region [- Edit(Contollers.Dto.Product product) -]
        public void Edit(Controllers.Dto.Product product)
        {
            ProductService.Update(Convertor.DtoConvertor(product));
        }
        #endregion

        #region [- Delete(int? id) -]
        public void Delete(int? id)
        {
            ProductService.Delete(id);
        }
        #endregion
    }
}
