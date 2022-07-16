using MediatR;
using Microsoft.Extensions.Logging;
using Personal.Application.Dto.Personal;
using Personal.Domain.Model.Personal;
using Personal.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Personal.Application.UseCases.Queries.Personas.GetPersonaById
{
    public class GetPersonaByIdHandler : IRequestHandler<GetPersonaByIdQuery, PersonalDto>

    {   
        private readonly IPersonalRepository _personalRepository;
        private readonly ILogger<GetPersonaByIdQuery> _logger;

        public GetPersonaByIdHandler(IPersonalRepository personalRepository, ILogger<GetPersonaByIdQuery> logger)
        {
            _personalRepository = personalRepository;
            _logger = logger;
        }

        public Task<PersonalDto> Handle(GetPersonaByIdQuery request, CancellationToken cancellationToken)
        {
            PersonalDto result = null;
            try
            {
                Personal.Domain.Model.Personal.Personal objPersona = null;//await _personalRepository.FindByIdAsync(request.Id);

                result = new PersonalDto()
                {
                    PersonalId = objPersona.Id,
                    //Nombre = objPersona.NombreCompleto,
                    //Tipo = objPersona.Tipo,
                    //Tripulacion = objPersona.Tripulacion,
                };

                //foreach (var item in objPersona.Regis)
                //{
                //    result.Detalle.Add(new DetallePedidoDto()
                //    {
                //        Cantidad = item.Cantidad,
                //        Instrucciones = item.Instrucciones,
                //        Precio = item.Precio,
                //        ProductoId = item.ProductoId
                //    });
                //}
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener id: { Id }", request.Id);
            }

            return Task.FromResult(result);
        }
    }
}


