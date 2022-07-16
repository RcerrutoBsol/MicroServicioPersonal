
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Personal.Application.Services;
//using Xunit;

namespace Personal.Test.Application.Service
{
    public class PersonalService_Test
    {
        [Test]
        public async Task GenerarIdPeronalCheckValidDataAsync()
        {
            var personalService = new PersonalService();
            string idPersonal = await personalService.GenerarIdPeronalAsync();
            Assert.AreEqual("ABC", idPersonal);
        }
        [Test]
        public async Task GenerarIdPeronalInValidDataAsync()
        {
            var personalService = new PersonalService();
            string idPersonal = await personalService.GenerarIdPeronalAsync();
            Assert.AreNotEqual("156", idPersonal);
        }
        
        [Theory]
        [TestCase("ABC", true)]
        [TestCase("ABC5", false)]
        public async Task GenerarIdPeronalCheckValidDataAsync2(string expidPersonal, bool isEqual)
        {
            var personalService = new PersonalService();
            string idPersonal = await personalService.GenerarIdPeronalAsync();
            if (isEqual)
            {
                Assert.AreEqual(expidPersonal, idPersonal);
            }
            else
            {
                Assert.AreNotEqual(expidPersonal, idPersonal);
            }

        }

    }
}

