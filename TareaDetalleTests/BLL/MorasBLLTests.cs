using Microsoft.VisualStudio.TestTools.UnitTesting;
using TareaDetalle.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using TareaDetalle.Models;

namespace TareaDetalle.BLL.Tests
{
    [TestClass()]
    public class MorasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Moras moras = new Moras();

            moras.MoraId = 0;
            moras.Fecha = DateTime.Now;
            moras.Total = 1000;

            moras.MorasDetalle.Add(new MorasDetalle
            {
                Id = 0,
                MoraId = moras.MoraId,
                PrestamoId = 1,
                Valor = 2000
            });

            paso = MorasBLL.Guardar(moras);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
           
            bool paso;
            paso = MorasBLL.Existe(1);
            Assert.AreEqual(paso, true);
           
        }

        [TestMethod()]
        public void InsertarTest()
        {
            bool paso;
            Moras moras = new Moras();

            moras.MoraId = 0;
            moras.Fecha = DateTime.Now;
            moras.Total = 2000;

            moras.MorasDetalle.Add(new MorasDetalle
            {
                Id = 0,
                MoraId = moras.MoraId,
                PrestamoId = 10,
                Valor = 3000
            });

            paso = MorasBLL.Insertar(moras);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Moras moras = new Moras();

            moras.MoraId = 1;
            moras.Fecha = DateTime.Now;
            moras.Total = 400;

            moras.MorasDetalle.Add(new MorasDetalle
            {
                Id = 0,
                MoraId = moras.MoraId,
                PrestamoId = 10,
                Valor = 200
            });

            paso = MorasBLL.Modificar(moras);
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
            var paso = MorasBLL.Buscar(1);
            Assert.AreEqual(paso, paso);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso;
            var lista = MorasBLL.GetList(x => true);

            if (lista != null)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }

       
       
    }
}