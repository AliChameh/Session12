using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00_Product_Category_CodeFirst.Models.Services
{
    public class ProductService
    {
        #region [- ctor -]
        public ProductService()
        {

        }
        #endregion

        #region [- props -]
        public string Message { get; private set; }
        #endregion

        #region [- Select() -]
        public List<DomainModels.Product> Select()
        {
            using (var context = new DomainModels.SimpleDbContext())
            {
                try
                {
                    var q = context.Product.Include(p => p.Category).ToList();
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

        #region [- FillCategrory() -]
        public List<DomainModels.ProductCategory> FillCategory()
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

        #region [- Insert(DomainModels.Product product) -]
        public void Insert(DomainModels.Product product)
        {
            using (var context = new DomainModels.SimpleDbContext())
            {
                try
                {
                    context.Product.Add(product);
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
        public DomainModels.Product FindId(int? id)
        {
            using (var context = new DomainModels.SimpleDbContext())
            {
                try
                {
                    var q = context.Product.Find(id);
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

        #region [- Update(DomainModels.Product product) -]
        public void Update(DomainModels.Product product)
        {
            using (var context = new DomainModels.SimpleDbContext())
            {
                try
                {
                    var q = context.Entry(product).State = EntityState.Modified;
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
                    var q = context.Product.Find(id);
                    context.Product.Remove(q);
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
