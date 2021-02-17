using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();//productname boş olamaz
            RuleFor(p => p.ProductName).MinimumLength(2); //productname min 2 karakter olmalı
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(P => P.UnitPrice).GreaterThan(0);//unitprice 0 dan büyük olmalı
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);//catergoryıd si 1 olan ürünlerin fiyatı 10 dan az olmamalı
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı"); //ürün adı must (uymalı) A ile başlamalı
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");// true yada false döner
        }
    }
}
