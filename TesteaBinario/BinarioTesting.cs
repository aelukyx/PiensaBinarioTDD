using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using PiensaBinario;

namespace TesteaBinario
{
    [TestFixture]
    public class BinarioTesting
    {

        private PensandoBinario pensandoBinario { get; set; }

        [SetUp]
        public void InstaciasAntesDeCadaTest()
        {
            // Arrange
            pensandoBinario = new PensandoBinario();
        }

        [Test]
        public void CombinacionBinarios3y8()
        {
            // Act
            var result = pensandoBinario.GetNumeroDeCombinaciones(3);

            // Assert
            Assert.AreEqual(8, result);
        }


        [Test]
        public void CombinacionBinarios2y4()
        {
            // Act
            var result = pensandoBinario.GetNumeroDeCombinaciones(2);

            // Assert
            Assert.AreEqual(4, result);
        }


        [Test]
        public void CombinacionBinarios4y16()
        {
            // Act
            var result = pensandoBinario.GetNumeroDeCombinaciones(4);

            // Assert
            Assert.AreEqual(16, result);
        }



    }
}
