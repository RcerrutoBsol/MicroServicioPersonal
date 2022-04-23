using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal.Domain.Model.Personal;
namespace Personal.Domain.Factories
{
    public class PedidoFactory : IPeronalFactory
    {
        public Personal.Domain.Model.Personal.Personal Create(string nombreCompleto, int tipo, int tripulacion)
        {
            return new Personal.Domain.Model.Personal.Personal(nombreCompleto, tipo, tripulacion);
        }
    }
}
