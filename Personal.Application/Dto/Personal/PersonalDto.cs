using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Application.Dto.Personal
{
    public class PersonalDto
    {
        public Guid PersonalId { get; set; }
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public int Tripulacion { get; set; }

    }
}
