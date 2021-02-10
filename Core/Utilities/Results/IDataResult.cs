using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult    //mesajla işlem sonucunu IResult içerir   <T> Generic ifadedir her türü dönderebilir
    {

        T Data { get; }
    }
}
