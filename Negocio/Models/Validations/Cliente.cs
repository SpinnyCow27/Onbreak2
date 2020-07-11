using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models.Validations
{
    public class MayorDeEdad : ValidationAttribute
    {
        public int EdadMinima { get; set; }

        public MayorDeEdad(int edadMinima = 18)
        {
            EdadMinima = edadMinima;
        }

        public override bool IsValid(object value)
        {
            DateTime? fechaNacimiento = value as DateTime?;

            if (fechaNacimiento.HasValue)
            {
                TimeSpan diferencia = DateTime.Now - fechaNacimiento.Value;

                int edad = (int)diferencia.TotalDays / 365;

                if (edad > 17)
                {
                    return true;
                }

                return false;
            }

            return true;
        }
    }
    public class RutValid : ValidationAttribute
    {
        public RutValid() { }

        protected override ValidationResult IsValid(object value, ValidationContext model)
        {
            int? rut = value as int?;

            if (rut.HasValue)
            {
                bool EsValido = Helpers.Rut.ValidaRut(rut.Value.ToString());
                if (EsValido)
                    return ValidationResult.Success;
                else
                    return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
