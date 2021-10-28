using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_Product_Category_CodeFirst_Copy.Models.DomainModels;

namespace _01_Product_Category_CodeFirst_Copy.Models.Services
{
    public class ProductCategoryService
    {
        #region [- ctor -]
        public ProductCategoryService()
        {

        }
        #endregion

        #region [- props -]
        public string Message { get; private set; }
        #endregion

        #region [- Select() -]
        public List<ProductCategory> Select()
        {
            using (var context = new SimpleDbContext())
            {
                try
                {
                    var q = context.ProductCategory.ToList();
                    return q;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Insert(ProductCategory productCategory)
        public void Insert(ProductCategory productCategory)
        {
            using (var context = new SimpleDbContext())
            {
                try
                {
                    context.ProductCategory.Add(productCategory);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- FindId(int id) -]
        public ProductCategory FindId(int? id)
        {
            using (var context = new SimpleDbContext())
            {
                try
                {
                    var q = context.ProductCategory.Find(id);
                    return q;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Update(ProductCategory productCategory)
        public void Update(ProductCategory productCategory)
        {
            using (var context = new SimpleDbContext())
            {
                try
                {
                    context.Entry(productCategory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if(context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Delete(int id) -]
        public void Delete(int id)
        {
            using (var context = new SimpleDbContext())
            {
                try
                {
                    var q = context.ProductCategory.Find(id);
                   context.ProductCategory.Remove(q);
                    context.SaveChanges();   
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if(context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion
    }
}
