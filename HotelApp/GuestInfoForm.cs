using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class GuestInfoForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public GuestInfoForm(string guestId)
        {
            InitializeComponent();
            DatabaseService databaseService = new DatabaseService();
            List<string[]> guests = databaseService.GetGuests();
            foreach (var guest in guests) 
            {
                if (guest[0] == guestId)
                {
                    string checkindate = guest[5];
                    string checkoutdate = guest[6];
                    nameGuestTextBox.Text = "ФИО: " + guest[1] + " " + guest[2] + " " + guest[3];
                    dateOfBirthTextBox.Text = "Дата рождения: " + guest[4];
                    PaymentInfoLabel.Text = "Оплата: " + guest[8];
                    NumberOfDaysLabel.Text = "Количество дней: " + CalculateStayDays(checkindate, checkoutdate);
                    WithAnimalsCheckBox.Text = "Путешествую с животными";
                    if (guest[7] == "1")
                    {
                        WithAnimalsCheckBox.Checked = true;
                    }
                }
            }
        }
        public int CalculateStayDays(string checkInDate, string checkOutDate)
        {
            logger.Trace("Попытка получения количество дней в отеле");
            DateTime startDate = DateTime.ParseExact(checkInDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(checkOutDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            TimeSpan difference = endDate - startDate;

            logger.Trace("Успешное получения количество дней");
            logger.Trace("Сколько получено дней: " + difference.Days);
            return difference.Days;            
        }
    }
}
