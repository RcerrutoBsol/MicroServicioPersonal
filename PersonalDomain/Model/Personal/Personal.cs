using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal.Domain.Event;
using Personal.Domain.ValueObjects;
using ShareKernel.Core;
using ShareKernel.ValueObjects;


namespace Personal.Domain.Model.Personal
{
    public class Personal : AggregateRoot<Guid>
    {
        
        public Guid IdPersona { get; set; }
        public PersonNameValue NombreCompleto { get; set; }

        public PeronalTipo Tipo { get; set; }//1 administrativo 2 tripulacion

        public int Tripulacion { get; set; }

        //public ICollection<ControlPersonal> PersonalControl { get; private set; }

        public Personal(string nombreCompleto, int tipo, int tripulacion)
        {
            Id = Guid.NewGuid();
            NombreCompleto = nombreCompleto;
            Tipo = tipo;
            Tripulacion = tripulacion;
        }
        //uso de DOMAIN EVENT
        public void AsignarTripulacion()
        {
            var evento = new TripulacionAsignada(Id, Tripulacion);
            AddDomainEvent(evento);
        }
        public void RegistroPersonal(Guid Id, string NombreCompleto, int Tipo, int Tripulacion)
        {
           AddDomainEvent(new PersonalCreado(Id,NombreCompleto,Tipo,Tripulacion));
        }
    }
  
}
