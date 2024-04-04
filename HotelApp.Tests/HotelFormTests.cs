using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp.Tests
{
    [TestClass]
    public class HotelFormTests
    {
        [TestMethod]
        public void HotelStatus_StringReturned()
        {
            //arrange
            string checkInDate = "25.03.2024";
            string checkOutDate = "01.04.2024";
            string expected = "Выписываются";

            //act
            HotelForm hotelForm = new HotelForm();
            string actual = hotelForm.HotelStatus(checkInDate, checkOutDate);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
