using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.Sistema;
using System;
using Biblioteca.Entitdades;

namespace TestProject1
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AgregarEscritorioAEstante_CuandoMetrosCuadradosEsCeroOMenor_LansaExepcion()
        {
            Escritorio auxEscritorio= new Escritorio("Esquinero", 0);

            bool resultado = Sistema.EstanteEscritorio.Agregar(auxEscritorio);
        }

        [TestMethod]
        public void AgregarEscritorioAEstante_CuandoLosDatosSonCorrectos_RetronaTrue()
        {
            Escritorio auxEscritorio = new Escritorio("Esquinero", 1);

            bool resultado = Sistema.EstanteEscritorio.Agregar(auxEscritorio);

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AgregarEscritorioEstante_CuandoEsNull_LasaExepcion()
        {
            Escritorio auxEscritorio = null;

            bool resultado = Sistema.EstanteEscritorio.Agregar(auxEscritorio);           
        }

        [TestMethod]
        public void BuscarMouseEnEstante_CuandoExiste_RetornaMouse()
        {
            Mouse auxMouse;

            Mouse originalMouse = new Mouse(1, 2);
            Sistema.EstanteMouse.Agregar(originalMouse);

            auxMouse = Sistema.EstanteMouse.Buscar(0);

            Assert.AreEqual(auxMouse, originalMouse);
        }

        [TestMethod]
        public void EliminarMonitor_CuandoExiste_retornaTrue()
        {
            Monitor auxMoniotr;

            auxMoniotr = new Monitor(2, 3);

            bool resultado = Sistema.EstanteMonitor.Eliminar(auxMoniotr);

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void EliminarMonitor_CuandoNoExiste_retornaTrue()
        {
            bool resultado = Sistema.EstanteMonitor.Eliminar(null);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void PisarEscritorio_CuandoExiste_RetornarTrue()
        {

            string modelo;
            string metrosCuadrados;
            Escritorio auxEscritorio;

            modelo = "Esquinero";
            metrosCuadrados = "5";
            auxEscritorio = new Escritorio("Gamer", 3);

            bool resultado = Sistema.PisarInfoEscritorio(modelo, metrosCuadrados, auxEscritorio);

            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void PisarEscritorio_CuandoLosDatosSonIncorrectos_LansaExepcion()
        {

            string modelo;
            string metrosCuadrados;
            Escritorio auxEscritorio;

            modelo = "Esquinero";
            metrosCuadrados = "aaaaaaaaaa";
            auxEscritorio = new Escritorio("Gamer", 3);

            bool resultado = Sistema.PisarInfoEscritorio(modelo, metrosCuadrados, auxEscritorio);

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PisarEscritorio_CuandoLosDatosSonNull_LansaExepcion()
        {

            string modelo;
            string metrosCuadrados;
            Escritorio auxEscritorio;

            modelo = null;
            metrosCuadrados = null;
            auxEscritorio = new Escritorio("Gamer", 3);

            bool resultado = Sistema.PisarInfoEscritorio(modelo, metrosCuadrados, auxEscritorio);

            Assert.AreEqual(true, resultado);
        }

    }
}
