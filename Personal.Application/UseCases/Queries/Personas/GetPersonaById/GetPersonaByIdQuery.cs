using MediatR;
using Personal.Application.Dto.Personal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Application.UseCases.Queries.Personas.GetPersonaById
{
    public class GetPersonaByIdQuery : IRequest<PersonalDto>
    {
        public Guid Id { get; set; }

        public GetPersonaByIdQuery(Guid id)
        {
            Id = id;
        }

        public GetPersonaByIdQuery() { }
    }
}
