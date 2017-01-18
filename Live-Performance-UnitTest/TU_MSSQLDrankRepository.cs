using System;
using System.Collections.Generic;
using Live_Performance.Classes;
using Live_Performance.Repositories.MSSQLRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Live_Performance_UnitTest
{
    [TestClass]
    public class TU_MSSQLDrankRepository
    {
        [TestMethod]
        public void GetAll()
        {
            // Arrange
            MSSQLDrankRepository DrankRepository = new MSSQLDrankRepository();
            List<Drank> dranken = DrankRepository.GetAll();

            // Act
            int count = dranken.Count;

            // Assert
            Assert.AreNotEqual(0, count);
        }


        [TestMethod]
        public void GetById()
        {
            // Arrange
            MSSQLDrankRepository DrankRepository = new MSSQLDrankRepository();
            Drank drank = DrankRepository.GetById(1);

            // Act
            string naam = drank.Naam;

            // Assert
            Assert.AreEqual("Cola", naam);
        }


        [TestMethod]
        public void Insert()
        {
            // Arrange
            MSSQLDrankRepository DrankRepository = new MSSQLDrankRepository();
            Drank drank = new Drank(-1, "Cola", new decimal(2.20), new decimal(1.10), false);
            
            // Act
            int startCount = DrankRepository.GetAll().Count;

            DrankRepository.Insert(drank);

            int endCount = DrankRepository.GetAll().Count;

            // Assert
            Assert.AreEqual(startCount + 1, endCount);
        }


        [TestMethod]
        public void Update()
        {
            // Arrange
            MSSQLDrankRepository DrankRepository = new MSSQLDrankRepository();
            List<Drank> dranken = DrankRepository.GetAll();
            Drank drank = dranken[dranken.Count - 1];
            Drank verifyDrank;

            // Act

            drank.Naam = "Vies suikerwater";
            drank.Alcoholhoudend = true;
            drank.Inkoopprijs = new decimal(4.20);
            drank.Verkoopprijs = new decimal(5.20);

            DrankRepository.Update(drank);

            dranken = DrankRepository.GetAll();
            verifyDrank = dranken[dranken.Count - 1];

            // Assert
            Assert.AreEqual("Vies suikerwater", verifyDrank.Naam);
            Assert.AreEqual(true, verifyDrank.Alcoholhoudend);
            Assert.AreEqual(new decimal(4.20), verifyDrank.Inkoopprijs);
            Assert.AreEqual(new decimal(5.20), verifyDrank.Verkoopprijs);
        }


        [TestMethod]
        public void Delete()
        {
            // Arrange
            MSSQLDrankRepository DrankRepository = new MSSQLDrankRepository();
            List<Drank> dranken = DrankRepository.GetAll();
            Drank drank = dranken[dranken.Count - 1];

            // Act
            int startCount = DrankRepository.GetAll().Count;

            DrankRepository.Delete(drank.ID);

            int endCount = DrankRepository.GetAll().Count;

            // Assert
            Assert.AreEqual(startCount - 1, endCount);
        }
    }
}
