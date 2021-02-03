using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id); //tümünü getir category id ye göre
        List<Product> GetByUnitPrice(decimal min, decimal max);  //şu fiyat aralığında getir
         

    }
}
