using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Application.Services
{
    public interface IPersonalService
    {
        Task<string> GenerarIdPeronalAsync();

    }
}
