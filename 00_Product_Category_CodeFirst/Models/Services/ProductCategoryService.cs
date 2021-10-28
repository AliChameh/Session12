using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00_Product_Category_CodeFirst.Models.Services
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
        public List<DomainModels.ProductCategory> Select()
        {
            using (var context = new DomainModels.SimpleDbContext())
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

        #region [- Insert(DomainModels.ProductCategory productCategory) -]
        public void Insert(DomainModels.ProductCategory productCategory)
        {
            using (var context = new DomainModels.SimpleDbContext())
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

        #region [- FindId(int? id) -]
        public DomainModels.ProductCategory FindId(int? id)
        {
            using (var context = new DomainModels.SimpleDbContext())
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

        #region [- Update(DomainModels.ProductCategory productCategory) -]
        public void Update(DomainModels.ProductCategory productCategory)
        {
            using (var context = new DomainModels.SimpleDbContext())
            {
                try
                {
                    context.Entry(productCategory).State = EntityState.Modified;
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

        #region [- Delete(int? id) -]
        public void Delete(int? id)
        {
            using (var context = new DomainModels.SimpleDbContext())
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
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

    }
}
