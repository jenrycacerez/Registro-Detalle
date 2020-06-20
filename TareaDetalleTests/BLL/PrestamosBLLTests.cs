using Microsoft.VisualStudio.TestTools.UnitTesting;
using TareaDetalle.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using TareaDetalle.Models;

namespace TareaDetalle.BLL.Tests
{
    [TestClass()]
    public class PrestamosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Prestamos prestamos = new Prestamos();

            prestamos.PrestamoId = 0;
            prestamos.PersonaID = 1;
            prestamos.Fecha = DateTime.Now;
            prestamos.Concepto = "Pago";
            prestamos.Monto = 2000;
            prestamos.Balance = 0;


            paso = PrestamosBLL.Guardar(prestamos);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso;
            paso = PrestamosBLL.Existe(2);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            bool paso;
            Prestamos prestamos = new Prestamos();

            prestamos.PrestamoId = 0;
            prestamos.PersonaID = 1;
            prestamos.Fecha = DateTime.Now;
            prestamos.Concepto = "PrestamoTest";
            prestamos.Monto = 2000;
            prestamos.Balance = 2000;


            paso = PrestamosBLL.Insertar(prestamos);
            PrestamosBLL.LlenarBalance(prestamos.PersonaID, prestamos.Balance);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Prestamos prestamo = new Prestamos();
            prestamo.PrestamoId = 1;
            prestamo.PersonaID = 1;
            prestamo.Concepto = " Modificada";
            prestamo.Fecha = DateTime.Now;
            prestamo.Monto = 200;

            paso = PrestamosBLL.Modificar(prestamo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;

            paso = PrestamosBLL.Eliminar(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            var prestamo = PrestamosBLL.Buscar(2);

            if (prestamo != null)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso;
            var lista = PrestamosBLL.GetList(x => true);

            if (lista != null)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }

        
        

       
    }
}