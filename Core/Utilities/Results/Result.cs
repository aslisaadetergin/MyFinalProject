using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        

        public Result(bool success, string message):this(success)   //alttaki kodda çalışır kapsadığı için
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success; //overload
        }

        public bool Success { get; }

        public string Message { get; } //read only dir. read only ler constructor da set edilebilir
    }
}
