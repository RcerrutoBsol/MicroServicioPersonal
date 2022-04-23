using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal.Domain.Model.Personal;

namespace Personal.ConsoleUI
{
    static class PersonalConsoleUI
    {
        static void Main(string[] args)
        {
            Personal.Domain.Model.Personal.Personal objPersonal = new Personal.Domain.Model.Personal.Personal("Ronald CErruto",2,1);
            Personal.Domain.Model.Personal.Personal objPersonal2 = new Personal.Domain.Model.Personal.Personal("Jose Perez", 1, 1);

        }
    }
}
