using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) //istenilen kadar parametre eklemek için liste biçiminde de olabilir
        {
            foreach (var logic in logics)
            {
                if (!logic.Success) //Başarısız olanları business a logic gönder
                {
                    return logic;
                }
            }
            return null;
        }


    }
}
