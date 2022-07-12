/*
 *  Ejercicio I01 - Test Driven Development
 * 
 *  Crear una calculadora de string con un m�todo int Add (string numeros) y automatizar las pruebas unitarias para cada uno de los siguientes puntos.
 *  
 *  SUGERENCIAS
 *      Comience con el caso de prueba m�s simple de un string vac�o y pase a uno y dos n�meros
 *      Recuerde resolver las cosas de la forma m�s sencilla posible
 *      Recuerde refactorizar despu�s de cada prueba aprobada.
 * 
 *  Parte I
 *  El m�todo Add debe poder tomar hasta dos n�meros separados por comas, y devolver� su suma.
 *  Por ejemplo "" o "1" o "1,2" como entradas (para un string vac�o devolver� 0).
 *  
 *  Parte II
 *  Permitir que el m�todo Add maneje una cantidad desconocida de n�meros.
 *  
 *  Parte III
 *  Permita que el m�todo Add admita salto de l�nea entre n�meros (en lugar de comas).
 *  La siguiente entrada est� bien: "1 \ n2,3" (ser� igual a 6).
 *  La siguiente entrada NO est� bien: "1, \ n" (no es necesario probarlo, solo se aclara)
 *  
 *  Parte IV
 *  Permitir que el m�todo Add soporte diferentes delimitadores.
 *  Para cambiar un delimitador, el comienzo del string contendr� dos barras, debe verse as�:
 *      // [delimitador] \ n [n�meros ...]
 *  
 *  Por ejemplo: "//; \ n1; 2" debe devolver tres donde el valor predeterminado delimitador es ';'.
 *  Las barras son opcionales. Todos los escenarios existentes a�n deben ser compatibles.
 *  
 *  Parte V
 *  Si Add recibe un n�mero negativo arrojar� una excepci�n NegativoNoPermitidoException que en su mensaje contendr� el negativo que se recibi�.
 * 
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C11EI01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculadoraStringAdd_DebeDevolverCeroPorqueStringEsNulo()
        {
            //Arrange
            string stringPrueba = string.Empty;
            int expected = 0;
            int actual;

            //Act
            actual = CalculadoraString.Add(stringPrueba);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculadoraStringAdd_DebeDevolverUno()
        {
            string stringPrueba = "1,NaN";
            int expected = 1;
            int actual;

            actual = CalculadoraString.Add(stringPrueba);

            Assert.AreEqual(expected, actual);
        }

        //PARTE II
        [TestMethod]
        public void CalculadoraStringAdd_DebeDevolverDiez()
        {
            string stringPrueba = "1,3,6";
            int expected = 10;
            int actual;

            actual = CalculadoraString.Add(stringPrueba);

            Assert.AreEqual(expected, actual);
        }

        //PARTE III
        [TestMethod]
        public void CalculadoraStringAdd_DebeDevolverCincuenta()
        {
            string stringPrueba = "10,NaN,14\n6,  ,15,5";
            int expected = 50;
            int actual;

            actual = CalculadoraString.Add(stringPrueba);

            Assert.AreEqual(expected, actual);
        }

        //PARTE IV
        [TestMethod]
        public void CalculadoraStringAdd_DebeDevolverCien()
        {
            string stringPrueba = "//; 10,NaN;14\n6,  ,15,5;50";
            int expected = 100;
            int actual;

            actual = CalculadoraString.Add(stringPrueba);

            Assert.AreEqual(expected, actual);
        }

        //PARTE V
        [TestMethod]
        public void CalculadoraStringAdd_DebeDevolverException()
        {
            string stringPrueba = "//; 10,NaN;-14\n6,  ,15,5;50";
            string expected = new NegativoNoPermitidoException().GetType().Name;
            string actual;

            try
            {
                CalculadoraString.Add(stringPrueba);
                actual = null;
            }
            catch(Exception ex)
            {
                actual = ex.GetType().Name;
            }            

            Assert.AreEqual(expected, actual);
        }
    }
}
