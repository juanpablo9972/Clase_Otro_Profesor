using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDecirHolaMundo()
        {
            //organizar
            Marmotas_Ancestrales.Saludar obj = new Marmotas_Ancestrales.Saludar();
            string valoresperado = "Hola Mundo";
            //actuar

            string valorrespuesta = obj.DecirHola();

            //afirmar
            Assert.AreEqual(valoresperado, valorrespuesta);

        }

        [TestMethod]
        public void TestSumaDosMasDosIgual4()
        {
            //organizar
            Marmotas_Ancestrales.Arimetica obj = new Marmotas_Ancestrales.Arimetica();
            int valoresperado = 4;

            //actuar
            int valorrespuesta = obj.Sumar(2, 2);

            //afirmar
            Assert.AreEqual(valoresperado, valorrespuesta);
        }

        [TestMethod]
        public void TestSumaDosMasNuloIgualCero()
        {
            //organizar
            Marmotas_Ancestrales.Arimetica obj = new Marmotas_Ancestrales.Arimetica();
            int valoresperado = 0;

            //actuar
            int valorrespuesta = obj.Sumar(2, null);

            //afirmar
            Assert.AreEqual(valoresperado, valorrespuesta);
        }
    }
}
