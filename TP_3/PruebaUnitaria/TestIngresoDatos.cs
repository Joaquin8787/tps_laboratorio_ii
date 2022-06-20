using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace PruebaUnitaria
{
    [TestClass]
    public class TestIngresoDatos
    {
        [TestMethod]
        public void ValidadorDireccion_CuandoIngresanDatosQueNoCorrespondenAUnaDireccion_DeberiaRetornarFalse()
        {
            //Arrange 
            string direccion = " asdasd 123 123";
            bool expected = false;
            bool actual;

            //Act
            actual = Pedido.ValidadorDireccion(direccion);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ValidadorNumeroTelefonico_CuandoIngresanPalabras_DeberiaRetornarFalse()
        {
            //Arrange 
            string numeroTelefono = "asdasdws";
            bool expected = false;
            bool actual;

            //Act
            actual = Pedido.ValidadorNumeroTelefono(numeroTelefono);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidadorNombre_CuandoIngresanNombresConNumeros_DeberiaRetornarFalse()
        {
            //Arrange 
            string nombre = "Joaquin87";
            bool expected = false;
            bool actual;

            //Act
            actual = Pedido.ValidadorNombre(nombre);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
