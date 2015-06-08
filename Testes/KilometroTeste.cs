using Conversor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testes
{
    [TestClass]
    public class KilometroTeste
    {
        [TestMethod]
        [TestCategory("Kilometro")]
        public void KilometroMaisKilometro()
        {
            var kilometro = new Kilometro(10);
            var kilometro2 = new Kilometro(20);
            var resutado = kilometro + kilometro2;

            Assert.AreEqual(resutado.Valor, 30);
        }

        [TestMethod]
        [TestCategory("Kilometro")]
        public void KilometroMenosKilometro()
        {
            var kilometro = new Kilometro(10);
            var kilometro2 = new Kilometro(20);
            var resutado = kilometro2 - kilometro; 

            Assert.AreEqual(resutado.Valor, 10);
        }

        [TestMethod]
        [TestCategory("Kilometro")]
        public void KilometroMaisMetro()
        {
            var kilometro = new Kilometro(1);
            var metro = new Metro(1990);
            var resutado =  (kilometro + metro);

            Assert.AreEqual(resutado.Valor, 2.99M);
        }

        [TestMethod]
        [TestCategory("Kilometro")]
        public void KilometroMenosMetro()
        {
            var kilometro = new Kilometro(2);
            var metro = new Metro(1990);
            var resutado = kilometro - metro;

            Assert.AreEqual(resutado.Valor, 0.01M);
        }

        [TestMethod]
        [TestCategory("Kilometro")]
        public void KilometroMaisMilimetro()
        {
            var kilometro = new Kilometro(1);
            var milimetro = new Milimetro(1000000);
            var resutado = kilometro + milimetro;

            Assert.AreEqual(resutado.Valor, 2);
        }

        [TestMethod]
        [TestCategory("Kilometro")]
        public void KilometroMenosMilimetro()
        {
            var kilometro = new Kilometro(3);
            var milimetro = new Milimetro(2000000);
            var resutado = kilometro - milimetro;

            Assert.AreEqual(resutado.Valor, 1);
        }

        [TestMethod]
        [TestCategory("Kilometro")]
        public void KilometroParaMetro()
        {
            var kilometro = new Kilometro(3);
            Metro resultado = kilometro;

            Assert.AreEqual(resultado.Valor, 3000);
        }

        [TestMethod]
        [TestCategory("Kilometro")]
        public void KilometroParaMilimetro()
        {
            var kilometro = new Kilometro(3);
            Milimetro resultado = kilometro;

            Assert.AreEqual(resultado.Valor, 3000000);
        }
    }
}
