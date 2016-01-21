using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TDDHOMEWORD2.Tests
{
    [TestClass()]
    public class TDDHW2Tests
    {
        [TestMethod()]
        public void AccountingTest_id_1_quantity_1_shouldbe_100()
        {
            //arrange
            List<Book> book = new List<Book>() {
            new Book{Id=1,Quantity = 1},
            new Book{Id=2,Quantity = 0},
            new Book{Id=3,Quantity = 0},
            new Book{Id=4,Quantity = 0},
            new Book{Id=5,Quantity = 0},
            };
            int price = 100;
            var target = new TDDHW2();
            int actual = 0;

            int expected = 100;
            //act
            actual = target.Accounting(book, price);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}