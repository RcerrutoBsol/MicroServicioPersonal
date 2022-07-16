
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Xunit;

using Personal.Application.Dto.Personal;
using NUnit.Framework;

namespace Personal.Test.Application
{
    public class PersonalDto_Tests
    {
        [Test]
        public void PersonalDto_CheckPropertiesValid()
        { 
            var idTest = Guid.NewGuid();

            var nombreTest = "Ronald Cerruto";

            var tipotest = 1;
            var tripulacionTest = 2;

            var objPersonal = new PersonalDto();

            Assert.AreEqual(Guid.Empty, objPersonal.PersonalId);
            Assert.Null(objPersonal.Nombre);    
            Assert.AreEqual(0, objPersonal.Tipo);
            Assert.AreEqual(0, objPersonal.Tripulacion);

            objPersonal.PersonalId = idTest;
            objPersonal.Nombre = nombreTest;
            objPersonal.Tipo = tipotest;    
            objPersonal.Tripulacion = tripulacionTest;  

            Assert.AreEqual(tipotest, objPersonal.Tipo);    
            Assert.AreEqual(nombreTest, objPersonal.Nombre);    
            Assert.AreEqual(tipotest , objPersonal.Tipo);
            Assert.AreEqual(tripulacionTest, objPersonal.Tripulacion);
            
    }
    }
}
