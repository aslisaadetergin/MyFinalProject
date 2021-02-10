using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results

{
    //Temel voidler için başlangıç
 public  interface IResult
    {
        bool Success { get; }  //get sadece okunabilir - eklendi veya eklenmedi olarak ture,false döndürür
        String Message { get; } //Ürün eklendi gibi bilgilendirme veya yönlendirme 
    }
}
