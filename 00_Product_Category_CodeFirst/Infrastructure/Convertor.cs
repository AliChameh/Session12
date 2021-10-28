using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _00_Product_Category_CodeFirst.Controllers.Dto;

namespace _00_Product_Category_CodeFirst.Infrastructure
{
    public static class Convertor
    {
        #region [- DtoConvertor(Controllers.Dto.ProductCategory dto) -]
        public static Models.DomainModels.ProductCategory DtoConvertor(Controllers.Dto.ProductCategory dto)
        {
            Models.DomainModels.ProductCategory model = new Models.DomainModels.ProductCategory();
            model.Id = dto.Id;
            model.Title = dto.Title;
            return model;
        }
        #endregion

        #region [- DtoConvertor(Controllers.Dto.Product dto) -]
        public static Models.DomainModels.Product DtoConvertor(Controllers.Dto.Product dto)
        {
            Models.DomainModels.Product model = new Models.DomainModels.Product();
            model.Id = dto.Id;
            model.Title = dto.Title;
            model.Quantity = dto.Quantity;
            model.UnitPrice = dto.UnitPrice;
            model.Category = DtoConvertor(dto.Category);
            return model;
        }
        #endregion



        #region [- DtoConvertor(List<Models.DomainModels.ProductCategory> modelList) -]
        public static List<Controllers.Dto.ProductCategory> DtoConvertor(List<Models.DomainModels.ProductCategory> modelList)
        {
            List<Controllers.Dto.ProductCategory> dtoList = new List<Controllers.Dto.ProductCategory>();
            foreach (var item in modelList)
            {
                var dto = new Controllers.Dto.ProductCategory();
                dto.Id = item.Id;
                dto.Title = item.Title;
                dtoList.Add(dto);
            }
            return dtoList;
        }

        
        #endregion

        #region [- DtoConvertor(List<Models.DomainModels.Product> modelList) -]
        public static List<Controllers.Dto.Product> DtoConvertor(List<Models.DomainModels.Product> modelList)
        {
            List<Controllers.Dto.Product> dtoList = new List<Controllers.Dto.Product>();
            foreach (var item in modelList)
            {
                var dto = new Controllers.Dto.Product();
                dto.Id = item.Id;
                dto.Title = item.Title;
                dto.UnitPrice = item.UnitPrice;
                dto.Quantity = item.Quantity;
                dto.Category = DtoConvertor(item.Category);
                dtoList.Add(dto);
            }
            return dtoList;
        }

        public static ProductCategory DtoConvertor(Models.DomainModels.ProductCategory category)
        {
            var dto = new Controllers.Dto.ProductCategory();
            dto.Id = category.Id;
            dto.Title = category.Title;
            return dto;
        }
        #endregion

        //#region [- visual studio auto fix for ProductCategoryViewModel.FillGrid()-]
        //internal static object DtoConvertor(List<Models.DomainModels.ProductCategory> productCategories)
        //{
        //    throw new NotImplementedException();
        //}
        //#endregion

        public static Product DtoConvertor(Models.DomainModels.Product product)
        {
            var dto = new Controllers.Dto.Product();
            dto.Id = product.Id;
            dto.Title = product.Title;
            dto.UnitPrice = product.UnitPrice;
            dto.Quantity = product.Quantity;
            return dto;
        }
    }
}
/*
 * public static Controllers.Dto.Product DtoConvertor(Models.DomainModels.Product product)
        {
            var dto = new Controllers.Dto.Product();
            dto.Id = product.Id;
            dto.Title = product.Title;
            dto.UnitPrice = product.UnitPrice;
            dto.Quantity = product.Quantity;
            return dto;
 */