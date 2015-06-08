using Conversor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testes
{
    [TestClass]
    public class MilimetroTeste
    {
        [TestMethod]
        [TestCategory("Milimetro")]
        public void MilimetroMaisMilimetro()
        {
            var milimetro = new Milimetro(10);
            var milimetro2 = new Milimetro(20);
            var resultado = milimetro + milimetro2;

            Assert.AreEqual(resultado.Valor, 30);
        }

        [TestMethod]
        [TestCategory("Milimetro")]
        public void MilimetroMenosMilimetro()
        {
            var milimetro = new Milimetro(10);
            var milimetro2 = new Milimetro(20);
            var resultado = milimetro2 - milimetro;

            Assert.AreEqual(resultado.Valor, 10);
        }

        [TestMethod]
        [TestCategory("Milimetro")]
        public void MilimetroMaisMetro()
        {
            var milimetro = new Milimetro(100);
            var metro = new Metro(2);
            var resutado = milimetro + metro;

            Assert.AreEqual(resutado.Valor, 2100);
        }

        [TestMethod]
        [TestCategory("Milimetro")]
        public void MilimetroMenosMetro()
        {
            var milimetro = new Milimetro(2000);
            var metro = new Metro(1);
            var resutado = milimetro - metro;

            Assert.AreEqual(resutado.Valor, 1000);
        }

        [TestMethod]
        [TestCategory("Milimetro")]
        public void MilimetroParaMetro()
        {
            var milimetro = new Milimetro(3000);
            Metro resultado = milimetro;

            Assert.AreEqual(resultado.Valor, 3);
        }

        [TestMethod]
        [TestCategory("Milimetro")]
        public void MilimetroMaisKilometro()
        {
            var kilometro = new Kilometro(1);
            var milimetro = new Milimetro(1000000);
            var resutado = milimetro + kilometro;

            Assert.AreEqual(resutado.Valor, 2000000);
        }

        [TestMethod]
        [TestCategory("Milimetro")]
        public void MilimetroMenosKilometro()
        {
            var kilometro = new Kilometro(1);
            var milimetro = new Milimetro(2000000);
            var resutado = milimetro - kilometro;

            Assert.AreEqual(resutado.Valor, 1000000);
        }

        [TestMethod]
        [TestCategory("Milimetro")]
        public void MilimetroParaKilometro()
        {
            var milimetro = new Milimetro(3000000);
            Kilometro resultado = milimetro;

            Assert.AreEqual(resultado.Valor, 3);
        }
    }
}