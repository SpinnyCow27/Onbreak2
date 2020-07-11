using Repositorio.BdModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public class TipoEvento : Interfaces.ICloseInt<TipoEvento>
    {
        public int IdTipoEvento { get; set; }

        public string Descripcion { get; set; }

        public List<TipoEvento> GetAll()
        {
            OnBreakEntities bd = OnBreakEntities.Instance;

            List<TipoEvento> tipoEventos = new List<TipoEvento>();

            bd.TipoEvento.ToList().ForEach(te => {
                TipoEvento tipoEvento = new TipoEvento();

                Helpers.Database.Synchronize(te, tipoEvento);

                tipoEventos.Add(tipoEvento);
            });

            return tipoEventos;
        }

        public TipoEvento GetOne(int id)
        {
            OnBreakEntities bd = OnBreakEntities.Instance;

            TipoEvento tipoEvento = new TipoEvento();

            Repositorio.BdModels.TipoEvento tipoEventoBd = bd.TipoEvento.Find(id);

            Helpers.Database.Synchronize(tipoEventoBd, tipoEvento);

            return tipoEvento;
        }

        public void Init()
        {
            IdTipoEvento = 0;
            Descripcion = String.Empty;
        }
    }
}
