using MediatR;
using Microsoft.Extensions.Logging;
using Personal.Application.Services;
using Personal.Domain.Factories;
using Personal.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal.Domain.Model.Personal;
using System.Threading;


namespace Personal.Application.UseCases.Command.Personas.CrearPersonal
{
    public class CrearPersonalHandler : IRequestHandler<CrearPersonalCommand, Guid>
    {
        private readonly IPersonalRepository _personalRepository;
        private readonly ILogger<CrearPersonalHandler> _logger;
        private readonly IPersonalService _personalService;
        private readonly IPeronalFactory _personalFactory;
        private readonly IUnitOfWork _unitOfWork;

        public CrearPersonalHandler(IPersonalRepository personalRepository, ILogger<CrearPersonalHandler> logger,
            IPersonalService personalService, IPeronalFactory personalFactory, IUnitOfWork unitOfWork)
        {
            _personalRepository = personalRepository;
            _logger = logger;
            _personalService = personalService;
            _personalFactory = personalFactory;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CrearPersonalCommand request, CancellationToken cancellationToken)
        {
            try
            {
                string idPersonal = await _personalService.GenerarIdPeronalAsync();
            
                Personal.Domain.Model.Personal.Personal objPersonal = _personalFactory.Create(idPersonal,0,0);

                foreach (var item in request.Detalle)
                {
                    objPersonal.RegistroPersonal(item.PersonalId, Convert.ToString(item.Nombre), Convert.ToInt16(item.Tipo), Convert.ToInt16(item.Tripulacion));
                }

                objPersonal.ConsolidarPersonal();

                await _personalRepository.CreateAsync(objPersonal);

                await _unitOfWork.Commit();

                return objPersonal.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear personal");
            }
            return Guid.Empty;
        }
    }
}
