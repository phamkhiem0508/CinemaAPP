using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Presenters.Utilities
{
    public class ModelDataValidation
    {
       
        public bool Validate(object model)
        {
            string message = "";
            List<ValidationResult> errors = new List<ValidationResult>();
            var context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, errors, true);
            if (!isValid)
            {
                foreach (ValidationResult result in errors)
                {
                    message += result.ErrorMessage + "\n";
                }
                
                throw new Exception(message);
            }
            return true;
        }
    }
}
