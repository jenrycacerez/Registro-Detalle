using Microsoft.VisualStudio.TestTools.UnitTesting;
using TareaDetalle.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using TareaDetalle.Models;

namespace TareaDetalle.BLL.Tests
{
    [TestClass()]
    public class PersonasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Personas personas = new Personas();

            personas.PersonaId = 0;
            personas.Nombres = "Jenry";
            personas.Cedula = "40226550420";
            personas.Telefono = "8092445061";
            personas.Direccion = "JEnry Cacerez ";
            personas.FechaNacimiento = Convert.ToDateTime("24/05/1997");
            personas.Balance = 0;

            paso = PersonasBLL.Guardar(personas);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = PersonasBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            bool paso;
            Personas personas = new Personas();

            personas.PersonaId = 0;
            personas.Nombres = "Lola";
            personas.Cedula = "40243434987";
            personas.Telefono = "8094347564";
            personas.Direccion = "La javiela";
            personas.FechaNacimiento = DateTime.Now;
            personas.Balance = 0;
            paso = PersonasBLL.Guardar(personas);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Personas personas = new Personas();

            personas.PersonaId = 2;
            personas.Nombres = "Daniela";
            personas.Cedula = "40243454349";
            personas.Telefono = "8292933929";
            personas.Direccion = "PruebaTest";
            personas.FechaNacimiento = DateTime.Now;
            personas.Balance = 0;
            paso = PersonasBLL.Modificar(personas);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;

            if (PersonasBLL.Eliminar(2))
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            var persona = PersonasBLL.Buscar(2);
            if (persona != null)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso;
            var lista = PersonasBLL.GetList(x => true);

            if (lista != null)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }
    }
}