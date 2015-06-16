using System;
using GQSLab.WindowsForms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GQSLab.Tests
{
    [TestClass]
    public class OperacoesUnitTest
    {
        [TestMethod]
        public void SomaZeros()
        {
            int a = 0;
            int b = 0;
            int expected = 0;
            int actual = 0;
                
            var target = new Operacoes();

            actual = target.Soma(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SomaInteiros()
        {
            int a = 1;
            int b = 2;
            int expected = 3;
            int actual = 0;

            var target = new Operacoes();

            actual = target.Soma(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtraiInteiros()
        {
            int a = 10;
            int b = 7;
            int expected = 6;
            int actual = 0;

            var target = new Operacoes();

            actual = target.Subtrai(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
