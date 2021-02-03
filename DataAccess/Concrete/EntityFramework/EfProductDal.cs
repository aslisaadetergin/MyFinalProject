using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
       
        public void Add(Product entity)
        {
            //IDisposable pattern implementation of c# 
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); //referansı yakalamak
                addedEntity.State = EntityState.Added; //bu nesne eklenecek EntityState entity durumu
                context.SaveChanges();//işlmeleri yap demek
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity); //referansı yakalamak
               deletedEntity.State = EntityState.Deleted; //bu nesne silinecek EntityState entity durumu
                context.SaveChanges();//işlmeleri yap demek
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter) //bu tek data getirecek
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() 
                    : context.Set<Product>().Where(filter).ToList(); //select * from Products komutunu listele
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity); //referansı yakalamak
                updatedEntity.State = EntityState.Modified; //bu nesne güncellenecek EntityState entity durumu
                context.SaveChanges();//işlmeleri yap demek
            }
        }
    }
}
