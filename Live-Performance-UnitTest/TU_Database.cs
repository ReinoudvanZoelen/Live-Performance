using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Repositories.MSSQLRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Live_Performance_UnitTest
{
    [TestClass]
    public class TU_Database
    {
        [TestMethod]
        public void test_Database()
        {
            // Arrange
            Database db = new Database();

            // Act
            bool connected = db.OpenConnection();
            db.CloseConnection();

            // Assert
            Assert.AreEqual(true, connected);
        }
    }
}
