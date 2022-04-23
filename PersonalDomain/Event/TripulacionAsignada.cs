using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Domain.Event
{
    public record TripulacionAsignada: DomainEvent
    {
        public Guid idAsignacion { get; }
        public int CodTripulacion { get; }

        public TripulacionAsignada(Guid idasignacion, int codtripulacion) : base(DateTime.Now)
        {
            idAsignacion = idasignacion;
            CodTripulacion = codtripulacion;
        }
    }
}
