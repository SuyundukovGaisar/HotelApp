using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Tests
{
    [TestClass]
    public class GuestInfoFormTests
    {
        [TestMethod]
        public void CalculateStayDays_DaysReturned()
        {
            //arrange
            string checkInDate = "25.03.2024";
            string checkOutDate = "05.04.2024";
            int expected = 11;

            //act
            GuestInfoForm guestInfoForm = new GuestInfoForm("1");
            int actual = guestInfoForm.CalculateStayDays(checkInDate, checkOutDate);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GuestInfoForm_ValidGuestIdReturned()
        {
            // arrange
            string guestId = "1";
            GuestInfoForm form = new GuestInfoForm(guestId);

            // act

            // assert
            Assert.AreEqual("ФИО: Петров Александр Григорьевич", form.nameGuestTextBox.Text);
            Assert.AreEqual("Дата рождения: 01.11.1984", form.dateOfBirthTextBox.Text);
            Assert.AreEqual("Оплата: Карта", form.PaymentInfoLabel.Text);
            Assert.AreEqual("Количество дней: 10", form.NumberOfDaysLabel.Text);
            Assert.IsFalse(form.WithAnimalsCheckBox.Checked);
        }

        [TestMethod]
        public void GuestInfoForm_InvalidGuestIdReturned()
        {
            // arrange
            string guestId = "99";
            GuestInfoForm form = new GuestInfoForm(guestId);

            // act

            // assert
            Assert.IsTrue(string.IsNullOrEmpty(form.nameGuestTextBox.Text));
        }
    }
}
