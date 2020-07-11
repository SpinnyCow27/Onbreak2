using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models.Helpers
{
    public class ValidateClass
    {
        public bool IsValid { get; set; }
        public List<ValidationResult> Errors { get; set; }

        public ValidateClass()
        {
            IsValid = true;
            Errors = new List<ValidationResult>();
        }
        public ValidateClass(bool isValid)
        {
            IsValid = isValid;
            Errors = new List<ValidationResult>();
        }

        public ValidateClass(List<ValidationResult> errors)
        {
            IsValid = false;
            Errors = errors;
        }
    }
}
