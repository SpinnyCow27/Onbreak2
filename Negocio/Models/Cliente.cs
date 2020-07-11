using Negocio.Models.Helpers;
using Negocio.Models.Interfaces;
using Repositorio.BdModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public class Cliente : Interfaces.IOpenString<Cliente>, IValidate
    {

        [Required(ErrorMessage = "El rut es un campo requerido.")]
        [Validations.RutValid(ErrorMessage = "El rut ingresado no es valido.")]
        public string RutCliente { get; set; }

        [Required(ErrorMessage = "La razón social es un campo requerido.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "La razón social debe tener entre 5 y 50 caracteres.")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "El nombre de contacto es un campo requerido")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "El nombre de contacto debe tener entre 1 y 50 caracteres.")]
        public string NombreContacto { get; set; }

        [Required(ErrorMessage = "El email es un campo requerido.")]
        [EmailAddress(ErrorMessage = "El email debe ser valido.")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "El email debe tener entre 5 y 30 caracteres.")]
        public string MailContacto { get; set; }

        [Required(ErrorMessage = "La dirección es un campo requerido.")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "La dirección debe tener entre 5 y 30 caracteres.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El numero de telefono es un campo requerido.")]
        [Range(100000000, 999999999, ErrorMessage = "El numero de telefono debe constar de 9 cifras.")]
        public string Telefono { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un actividad de empresa")]
        public int IdActividadEmpresa { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un tipo de empresa")]
        public int IdTipoEmpresa { get; set; }

        public bool Create()
        {
            try
            {
                OnBreakEntities bd = OnBreakEntities.Instance;

                Repositorio.BdModels.Cliente ClienteBd = new Repositorio.BdModels.Cliente();

                Helpers.Database.Synchronize(this, ClienteBd);

                bd.Cliente.Add(ClienteBd);

                bd.SaveChanges();

                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            Cliente cliente = new Cliente
            {
                RutCliente = id
            };

            return Delete(cliente);
        }

        public bool Delete(Cliente item)
        {
            try
            {
                OnBreakEntities bd = OnBreakEntities.Instance;

                Repositorio.BdModels.Cliente clienteBd = new Repositorio.BdModels.Cliente
                {
                    RutCliente = item.RutCliente
                };

                bd.Entry(clienteBd).State = EntityState.Deleted;

                bd.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Cliente> GetAll()
        {
            try
            {
                OnBreakEntities bd = OnBreakEntities.Instance;

                List<Cliente> clientes = new List<Cliente>();

                bd.Cliente.ToList().ForEach(c => {
                    Cliente cliente = new Cliente();

                    Helpers.Database.Synchronize(c, cliente);

                    clientes.Add(cliente);
                });

                return clientes;
            }
            catch
            {
                throw;
            }
        }

        public Cliente GetOne(string id)
        {
            try
            {
                OnBreakEntities bd = OnBreakEntities.Instance;

                Cliente cliente = new Cliente();

                Helpers.Database.Synchronize(
                    bd.Cliente.Find(id),
                    cliente
                );

                return cliente;
            }
            catch
            {
                throw;
            }
        }

        public void Init()
        {
            RutCliente = String.Empty;
            RazonSocial = String.Empty;
            NombreContacto = String.Empty;
            MailContacto = String.Empty;
            Direccion = String.Empty;
            Telefono = String.Empty;
            IdActividadEmpresa = 0;
            IdTipoEmpresa = 0;
        }

        public bool Update(string id)
        {
            try
            {
                OnBreakEntities bd = OnBreakEntities.Instance;

                Repositorio.BdModels.Cliente ClienteBd = bd.Cliente.Find(id);

                RutCliente = id;

                Helpers.Database.Synchronize(this, ClienteBd);
                bd.Entry(ClienteBd).State = EntityState.Modified;

                bd.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public ValidateClass Validate()
        {
            ValidationContext validador = new ValidationContext(this);
            List<ValidationResult> resultados = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(this, validador, resultados, true);

            if (isValid)
                return new ValidateClass(true);
            else
                return new ValidateClass(resultados);

        }
    }
}
