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
        private Personaje2 p1;

        // A Test behaves as an ordinary method
        [SetUp]
        public void SetUp() {
            //Arrage
            this.p1 = new Personaje2();
            //Debug.Log("Empezando la prueba");
        }

        [TestCase(0, 0)]
        [TestCase(51, 1)]
        [TestCase(101, 2)]
        [TestCase(151, 3)]
        public void test1(int fuerza, int esperado)
        {
            int actual = p1.darPuñetazo(fuerza);

            //Assert
            Assert.AreEqual(esperado, actual);
        }
    }
}
