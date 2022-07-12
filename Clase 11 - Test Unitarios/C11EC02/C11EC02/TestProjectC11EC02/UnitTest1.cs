/*
 *  Ejercicio C02 - Lanzar, atrapar y probar
 *  
 *  Partir del ejercicio Lanzar y atrapar.
 *  
 *  Realizar un test unitario para cada m�todo y/o constructor. Cada test deber� validar que el m�todo lance la excepci�n que le corresponde.
 * 
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using C11EC02;
using System;
using ExcepcionesC10EI01;

namespace TestProjectC11EC02
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MiClaseMetodoEst�ticoLanzandoException_DebeSerDividedByZeroException()
        {
            string expected = new DivideByZeroException().GetType().Name;
            string actual;

            try
            {
                MiClase.MetodoEstatico();
                actual = null;
            }
            catch(Exception ex)
            {
                actual = ex.GetType().Name;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MiClaseConstructorSinParametroLanzandoException_DebeSerDividedByZeroException()
        {
            MiClase prueba;
            string expected = new DivideByZeroException().GetType().Name;
            string actual;

            try
            {
                prueba = new MiClase();
                actual = null;
            }
            catch (Exception ex)
            {
                actual = ex.GetType().Name;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MiClaseConstructorConParametroLanzandoException_DebeSerUnaException()
        {
            MiClase prueba;
            string expected = new UnaException().GetType().Name;
            string actual;

            try
            {
                prueba = new MiClase("atributoPrueba");
                actual = null;
            }
            catch (Exception ex)
            {
                actual = ex.GetType().Name;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OtraClaseMetodoDeInstanciaLanzandoException_DebeSerMiException()
        {
            OtraClase prueba = new OtraClase();
            string expected = new MiException().GetType().Name;
            string actual;

            try
            {
                prueba.MetodoDeInstancia(); 
                actual = null;
            }
            catch (Exception ex)
            {
                actual = ex.GetType().Name;
            }

            Assert.AreEqual(expected, actual);
        }
    }
}
