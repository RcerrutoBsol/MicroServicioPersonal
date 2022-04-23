using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Domain.Event
{
    public record PersonalCreado : DomainEvent
    {
        public Guid IdPersona { get; }
        public string NombreCompleto { get; }

        public int Tipo { get;  }//1 administrativo 2 tripulacion

        public int Tripulacion { get;  }

        public PersonalCreado(Guid idPersona, string nombreCompleto, int tipo,int tripulacion) : base(DateTime.Now)
        {
            IdPersona = idPersona;
            NombreCompleto = nombreCompleto;
            Tipo = Tipo;
            Tripulacion = tripulacion;  
        }
    }
}
