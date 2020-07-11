using Negocio.Models.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models.Interfaces
{
    public interface IValidate
    {
        ValidateClass Validate();
    }
}
