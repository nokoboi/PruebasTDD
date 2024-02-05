using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Personajes;

namespace Test
{
    public class codigoED
    {
        private Personaje1 p1;
        private Personaje1 p2;

        // A Test behaves as an ordinary method
        [SetUp]
        public void SetUp()
        {
            //Arrage
            this.p1 = new Personaje1();
            this.p2 = new Personaje1();
            //Debug.Log("Empezando la prueba");
        }

        [TearDown]
        public void TearDown()
        {
            Debug.Log("Terminando la prueba");
        }

        [TestCase(10, 0)]
        [TestCase(51, 1)]
        [TestCase(101, 2)]
        [TestCase(151, 3)]
        public void test1(int intensidad, int esperado)
        {
            //Acc
            int actual = p1.darPuñetazo(intensidad);

            //Assert
            Assert.AreEqual(esperado, actual);
        }

        [Test]
        public void test2()
        {
            // Act
            bool resultadoPelea = p1.peleaCon(p2);

            // Asserts
            Assert.IsFalse(resultadoPelea, "p1 no debería ganar la pelea contra p2");
        }

        [Test]
        public void test3()
        {
            // Act
            bool estaVivoAntesDePuñetazo = p1.estaVivo();

            // Acc
            p1.darPuñetazo(50);

            // Asserts
            Assert.IsTrue(estaVivoAntesDePuñetazo, "p1 debería estar vivo antes de recibir el puñetazo");
            Assert.IsTrue(p1.estaVivo(), "p1 debería estar vivo después de recibir el puñetazo");
        }
    }
}
