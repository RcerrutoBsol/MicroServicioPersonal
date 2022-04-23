using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal.Domain.Model.Personal;

namespace Personal.Domain.Factories
{
    public interface IPeronalFactory
    {
        Personal.Domain.Model.Personal.Personal Create(string nombreCompleto, int tipo, int tripulacion);
    }
}
