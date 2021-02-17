using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {   // C# da static bir sınıfın methodları da static olmalı java da değil
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid) //sonuç geçerli değilse
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
