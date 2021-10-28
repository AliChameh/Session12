using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_Product_Category_CodeFirst_Copy;

namespace _01_Product_Category_CodeFirst_Copy.Infrastructure
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
            model.UnitPrice = dto.UnitPrice;
            model.Quantity = dto.Quantity;
            //model.Category = dto.Category; cast error are we need this?YAGNI
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
                dtoList.Add(dto);
            }
            return dtoList;
        }
        #endregion

        #region [- vs fix for ProductViewModel.ShowDetails(int id) -] 
        internal static object DtoConvertor(Models.DomainModels.Product q)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
