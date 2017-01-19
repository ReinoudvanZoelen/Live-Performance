using System;
using System.Collections.Generic;
using Live_Performance.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Live_Performance.Repositories.MSSQLRepository;

namespace Live_Performance_UnitTest
{
    [TestClass]
    public class TU_MSSQLSaladeRepository
    {
        [TestMethod]
        public void GetAll()
        {
            // Arrange
            MSSQLSaladeRepository SaladeRepository = new MSSQLSaladeRepository();
            List<Salade> salades = SaladeRepository.GetAll();

            // Act
            int count = salades.Count;

            // Assert
            Assert.AreNotEqual(0, count);
        }


        [TestMethod]
        public void GetById()
        {
            // Arrange
            MSSQLSaladeRepository SaladeRepository = new MSSQLSaladeRepository();
            Salade salade = SaladeRepository.GetById(1);

            // Act
            string naam = salade.Naam;

            // Assert
            Assert.AreEqual("Grote salade", naam);
        }


        [TestMethod]
        public void Insert()
        {
            // Arrange
            MSSQLSaladeRepository SaladeRepository = new MSSQLSaladeRepository();
            Salade salade = new Salade(-1, "Vissensoep salade", new decimal(10.2),new decimal(5.0));

            // Act
            int startCount = SaladeRepository.GetAll().Count;

            SaladeRepository.Insert(salade);

            int endCount = SaladeRepository.GetAll().Count;

            // Assert
            Assert.AreNotEqual(startCount, endCount);
        }


        [TestMethod]
        public void Update()
        {
            // Arrange
            MSSQLSaladeRepository SaladeRepository = new MSSQLSaladeRepository();
            List<Salade> salades = SaladeRepository.GetAll();
            Salade salade = salades[salades.Count - 1];
            Salade verifySalade;

            // Act

            salade.Naam = "Sleutelbaarzensalade";
            salade.Inkoopprijs = new decimal(2.0);
            salade.Verkoopprijs = new decimal(40.8);

            SaladeRepository.Update(salade);

            salades = SaladeRepository.GetAll();

            verifySalade = salades[salades.Count - 1];

            // Assert
            Assert.AreEqual("Sleutelbaarzensalade", verifySalade.Naam);
            Assert.AreEqual(new decimal(2.0), verifySalade.Inkoopprijs);
            Assert.AreEqual(new decimal(40.8), verifySalade.Verkoopprijs);
            Assert.AreNotEqual("Vissensoep salade", verifySalade.Naam);
        }


        [TestMethod]
        public void Delete()
        {
            // Arrange
            MSSQLSaladeRepository SaladeRepository = new MSSQLSaladeRepository();
            List<Salade> Salades = SaladeRepository.GetAll();
            Salade salade = Salades[Salades.Count - 1];

            // Act
            int startCount = SaladeRepository.GetAll().Count;

            SaladeRepository.Delete(salade.ID);

            int endCount = SaladeRepository.GetAll().Count;

            // Assert
            Assert.AreNotEqual(startCount, endCount);

        }
    }
}
