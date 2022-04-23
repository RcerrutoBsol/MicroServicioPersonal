using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal.Domain.Model.Personal;



namespace Personal.Domain.Repositories
{
    public interface IPersonalRepository : IRepository<Personal.Domain.Model.Personal.Personal, Guid>
    {
        Task UpdateAsync(Personal.Domain.Model.Personal.Personal obj);

        Task RemoveAsync(Personal.Domain.Model.Personal.Personal obj);
    }
}
