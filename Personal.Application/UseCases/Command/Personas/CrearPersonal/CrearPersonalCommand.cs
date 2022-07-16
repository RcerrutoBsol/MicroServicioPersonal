using MediatR;
using Personal.Application.Dto.Personal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Application.UseCases.Command.Personas.CrearPersonal
{
    public class CrearPersonalCommand : IRequest<Guid>
    {
        private CrearPersonalCommand() { }

        public CrearPersonalCommand(List<PersonalDto> detalle)
        {
            Detalle = detalle;
        }

        public List<PersonalDto> Detalle { get; set; }



    }
}
