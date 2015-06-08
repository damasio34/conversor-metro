using Conversor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testes
{
    [TestClass]
    public class MetroTeste
    {
        [TestMethod]
        [TestCategory("Metro -- Metro")]
        public void MetroMaisMetro()
        {
            var metro = new Metro(10);
            var metro2 = new Metro(20);
            var resultado = metro + metro2;

            Assert.AreEqual(resultado.Valor, 30);
        }

        [TestMethod]
        [TestCategory("Metro -- Metro")]
        public void MetroMenosMetro()
        {
            var metro = new Metro(20);
            var metro2 = new Metro(10);
            var resultado = metro - metro2;

            Assert.AreEqual(resultado.Valor, 10);
        }

        [TestMethod]
        [TestCategory("Metro -- Metro")]
        public void MetroIgualMetro()
        {
            var metro = new Metro(3);
            var metro2 = new Metro(3);
            var resultado = metro == metro2;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        [TestCategory("Metro -- Metro")]
        public void MetroEqualsMetro()
        {
            var metro = new Metro(3);
            var metro2 = metro;
            var resultado = metro.Equals(metro2);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        [TestCategory("Metro -- Metro")]
        public void MetroDiferenteMetro()
        {
            var metro = new Metro(3);
            var metro2 = new Metro(2);
            var resultado = metro != metro2;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        [TestCategory("Metro -- Metro")]
        public void MetroMaiorQueMetro()
        {
            var metro = new Metro(3);
            var metro2 = new Metro(2);
            var resultado = metro > metro2;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        [TestCategory("Metro -- Metro")]
        public void MetroMenorQueMetro()
        {
            var metro = new Metro(3);
            var metro2 = new Metro(5);
            var resultado = metro < metro2;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        [TestCategory("Metro -- Kilometro")]
        public void MetroMaisKilometro()
        {
            var metro = new Metro(1990);
            var kilometro = new Kilometro(1);
            var resultado = metro + kilometro;

            Assert.AreEqual(resultado.Valor, 2990);
        }

        [TestMethod]
        [TestCategory("Metro -- Kilometro")]
        public void MetroMenosKilometro()
        {
            var metro = new Metro(3000);
            var kilometro = new Kilometro(1);
            var resultado = metro - kilometro;

            Assert.AreEqual(resultado.Valor, 2000);
        }

        [TestMethod]
        [TestCategory("Metro -- Kilometro")]
        public void MetroIgualKilometro()
        {
            var metro = new Metro(3000);
            var kilometro = new Kilometro(3);

            Assert.IsTrue(metro == kilometro);
        }

        [TestMethod]
        [TestCategory("Metro -- Kilometro")]
        public void MetroParaKilometro()
        {
            var metro = new Metro(3000);
            Kilometro resultado = metro;

            Assert.AreEqual(resultado.Valor, 3);
        }

        [TestMethod]
        [TestCategory("Metro -- Milimetro")]
        public void MetroMaisMilimetro()
        {
            var metro = new Metro(1);
            var milimetro = new Milimetro(1000);
            var resultado = metro + milimetro;

            Assert.AreEqual(resultado.Valor, 2);
        }

        [TestMethod]
        [TestCategory("Metro -- Milimetro")]
        public void MetroMenosMilimetro()
        {
            var metro = new Metro(3);
            var milimetro = new Milimetro(1000);
            var resultado = metro - milimetro;

            Assert.AreEqual(resultado.Valor, 2);
        }

        [TestMethod]
        [TestCategory("Metro -- Milimetro")]
        public void MetroParaMilimetro()
        {
            var metro = new Metro(3);
            Milimetro resultado = metro;

            Assert.AreEqual(resultado.Valor, 3000);
        }
    }
}