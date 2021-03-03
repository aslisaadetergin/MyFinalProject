using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        
        IDataResult<List<Product>> GetAll(); //List<Product> dönderir  //IDataResult olarak değiştirince hem result hemde list döner
        IDataResult<List<Product>> GetAllByCategoryId(int id); //tümünü getir category id ye göre
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);  //şu fiyat aralığında getir
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);

        IResult Add(Product product);

        IResult Update(Product product);

        IResult AddTransactionalTest(Product product);

    }
}
