using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class HotelForm : Form
    {
        public string guestInfoId;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public HotelForm()
        {
            InitializeComponent();

            reserveRadioButton.CheckedChanged += ReserveRadioButton_CheckedChanged;
            freeRadioButton.CheckedChanged += FreeRadioButton_CheckedChanged;
            occupiedRadioButton.CheckedChanged += OccupiedRadioButton_CheckedChanged;
            checkoutRadioButton.CheckedChanged += ChecksOutRadioButton_CheckedChanged;
            logger.Info("Форма отеля успешно инициализирована");
        }
        private void HotelForm_Load(object sender, EventArgs e)
        {
            timer.Start();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void ReserveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                guestsGridView.Rows.Clear();
                guestsGridView.Columns.Clear();
                DatabaseService databaseService = new DatabaseService();
                try
                {
                    List<string[]> reservedList = databaseService.GetReservedGuests();
                    guestsGridView.Columns.Add("id", "id");
                    guestsGridView.Columns.Add("guest_id", "guest_id");
                    foreach (var reserved in reservedList)
                    {
                        guestsGridView.Rows.Add(reserved);
                    }
                    logger.Info("Загружены данные о зарезервированных гостях");
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "Ошибка получения зарезервированных гостей");
                }
            }
        }
        private void FreeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                guestsGridView.Rows.Clear();
                guestsGridView.Columns.Clear();
                DatabaseService databaseService = new DatabaseService();
                try
                {
                    List<string[]> freeList = databaseService.GetFreeGuests();
                    guestsGridView.Columns.Add("id", "id");
                    guestsGridView.Columns.Add("guest_id", "guest_id");
                    foreach (var free in freeList)
                    {
                        guestsGridView.Rows.Add(free);
                    }
                    logger.Info("Загружены данные о свободных гостях");
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "Ошибка получения свободных гостей");
                }
            }
        }
        private void OccupiedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                guestsGridView.Rows.Clear();
                guestsGridView.Columns.Clear();
                DatabaseService databaseService = new DatabaseService();
                try
                {
                    List<string[]> occupiedList = databaseService.GetOccupiedGuests();
                    guestsGridView.Columns.Add("id", "id");
                    guestsGridView.Columns.Add("guest_id", "guest_id");
                    foreach (var occupied in occupiedList)
                    {
                        guestsGridView.Rows.Add(occupied);
                    }
                    logger.Info("Загружены данные о занятых гостях");
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "Ошибка получения занятых гостей");
                }
            }
        }
        private void ChecksOutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                guestsGridView.Rows.Clear();
                guestsGridView.Columns.Clear();
                DatabaseService databaseService = new DatabaseService();
                try
                {
                    List<string[]> checksoutList = databaseService.GetChecksOutGuests();
                    guestsGridView.Columns.Add("id", "id");
                    guestsGridView.Columns.Add("guest_id", "guest_id");
                    foreach (var checksout in checksoutList)
                    {
                        guestsGridView.Rows.Add(checksout);
                    }
                    logger.Info("Загружены данные о выписывающихся гостях");
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "Ошибка получения выселяющихся гостей");
                }
            }
        }

        private void guestsGridView_DoubleClick(object sender, EventArgs e)
        {
            if (guestsGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guestsGridView.SelectedRows[0];

                int guestId = Convert.ToInt32(selectedRow.Cells["guest_id"].Value);

                DatabaseService databaseService = new DatabaseService();
                List<string[]> guestInfo = databaseService.GetGuests();

                statusInfotextBox.Text = null;
                FIOtextBox.Text = null;
                guestpictureBox.Text = null;
                check_in_dateTextBox.Text = null;
                departure_dateTextBox.Text = null;
                guestpictureBox.Image = null;

                if (reserveRadioButton.Checked)
                {
                    statusInfotextBox.Text = "Зарезервировано";
                    foreach (var guest in guestInfo)
                    {
                        if (guestId == Convert.ToInt32(guest[0]))
                        {
                            guestInfoId = guest[0];
                            FIOtextBox.Text = "ФИО: " + guest[1] + " " + guest[2] + " " + guest[3];
                            check_in_dateTextBox.Text = "Дата заезда: " + guest[5];
                            departure_dateTextBox.Text = "Дата выезда: " + guest[6];
                            try
                            {
                                logger.Trace("Попытка заполнение фото из БД");
                                byte[] imageBytes = null;
                                string connectionString = "Data Source=GuestsDB.db";
                                using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
                                {
                                    sqliteCon.Open();
                                    string query = "SELECT photo FROM guests WHERE id = @guestId";
                                    using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                                    {
                                        cmd.Parameters.AddWithValue("@guestId", guestId);
                                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                                        {
                                            if (reader.Read())
                                            {
                                                imageBytes = (byte[])reader["photo"];
                                            }
                                        }
                                    }
                                }

                                if (imageBytes != null)
                                {
                                    using (MemoryStream memoryS = new MemoryStream(imageBytes))
                                    {
                                        Image image = Image.FromStream(memoryS);
                                        guestpictureBox.Image = image;
                                        logger.Trace("Успешное заполнение фото из БД");
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                logger.Error(ex, "Ошибка получения изображения");
                            }
                        }
                    }
                }
                if (freeRadioButton.Checked)
                {
                    statusInfotextBox.Text = "Свободные";
                    foreach (var guest in guestInfo)
                    {
                        if (guestId == Convert.ToInt32(guest[0]))
                        {
                            guestInfoId = guest[0];
                            FIOtextBox.Text = "ФИО: " + guest[1] + " " + guest[2] + " " + guest[3];
                            check_in_dateTextBox.Text = "Дата заезда: " + guest[5];
                            departure_dateTextBox.Text = "Дата выезда: " + guest[6];

                            try
                            {
                                logger.Trace("Попытка заполнение фото из БД");
                                byte[] imageBytes = null;
                                string connectionString = "Data Source=GuestsDB.db";
                                using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
                                {
                                    sqliteCon.Open();
                                    string query = "SELECT photo FROM guests WHERE id = @guestId";
                                    using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                                    {
                                        cmd.Parameters.AddWithValue("@guestId", guestId);
                                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                                        {
                                            if (reader.Read())
                                            {
                                                imageBytes = (byte[])reader["photo"];
                                            }
                                        }
                                    }
                                }

                                if (imageBytes != null)
                                {
                                    using (MemoryStream memoryS = new MemoryStream(imageBytes))
                                    {
                                        Image image = Image.FromStream(memoryS);
                                        guestpictureBox.Image = image;
                                        logger.Trace("Успешное заполнение фото из БД");
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                logger.Error(ex, "Ошибка получения изображения");
                            }
                        }
                    }
                }
                if (occupiedRadioButton.Checked)
                {
                    statusInfotextBox.Text = "Заняты";
                    foreach (var guest in guestInfo)
                    {
                        if (guestId == Convert.ToInt32(guest[0]))
                        {
                            guestInfoId = guest[0];
                            FIOtextBox.Text = "ФИО: " + guest[1] + " " + guest[2] + " " + guest[3];
                            check_in_dateTextBox.Text = "Дата заезда: " + guest[5];
                            departure_dateTextBox.Text = "Дата выезда: " + guest[6];

                            try
                            {
                                logger.Trace("Попытка заполнение фото из БД");
                                byte[] imageBytes = null;
                                string connectionString = "Data Source=GuestsDB.db";
                                using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
                                {
                                    sqliteCon.Open();
                                    string query = "SELECT photo FROM guests WHERE id = @guestId";
                                    using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                                    {
                                        cmd.Parameters.AddWithValue("@guestId", guestId);
                                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                                        {
                                            if (reader.Read())
                                            {
                                                imageBytes = (byte[])reader["photo"];
                                            }
                                        }
                                    }
                                }

                                if (imageBytes != null)
                                {
                                    using (MemoryStream memoryS = new MemoryStream(imageBytes))
                                    {
                                        Image image = Image.FromStream(memoryS);
                                        guestpictureBox.Image = image;
                                        logger.Trace("Успешное заполнение фото из БД");
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                logger.Error(ex, "Ошибка получения изображения");
                            }
                        }
                    }
                }
                if (checkoutRadioButton.Checked)
                {
                    statusInfotextBox.Text = "Выписываются";
                    foreach (var guest in guestInfo)
                    {
                        if (guestId == Convert.ToInt32(guest[0]))
                        {
                            guestInfoId = guest[0];
                            FIOtextBox.Text = "ФИО: " + guest[1] + " " + guest[2] + " " + guest[3];
                            check_in_dateTextBox.Text = "Дата заезда: " + guest[5];
                            departure_dateTextBox.Text = "Дата выезда: " + guest[6];

                            try
                            {
                                logger.Trace("Попытка заполнение фото из БД");
                                byte[] imageBytes = null;
                                string connectionString = "Data Source=GuestsDB.db";
                                using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
                                {
                                    sqliteCon.Open();
                                    string query = "SELECT photo FROM guests WHERE id = @guestId";
                                    using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                                    {
                                        cmd.Parameters.AddWithValue("@guestId", guestId);
                                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                                        {
                                            if (reader.Read())
                                            {
                                                imageBytes = (byte[])reader["photo"];
                                            }
                                        }
                                    }
                                }

                                if (imageBytes != null)
                                {
                                    using (MemoryStream memoryS = new MemoryStream(imageBytes))
                                    {
                                        Image image = Image.FromStream(memoryS);
                                        guestpictureBox.Image = image;
                                        logger.Trace("Успешное заполнение фото из БД");
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                logger.Error(ex, "Ошибка получения изображения");
                            }
                        }
                    }
                }
            }
        }

        private void InfoCardbutton_Click(object sender, EventArgs e)
        {
            if(guestpictureBox.Image == null)
            {
                MessageBox.Show("Введите в поиске нужного гостя или найдите в таблице", "Ошибка");
            }
            else
            {
                logger.Info("Открытие карточки гостя");
                GuestInfoForm form = new GuestInfoForm(guestInfoId);
                form.Show();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        private void searchPictureBox_Click(object sender, EventArgs e)
        {
            logger.Info("Поиск гостя по ФИО, фамилии или ID");
            DatabaseService databaseService = new DatabaseService();
            List<string[]> guestsList = databaseService.GetGuests();
            string enteredText = searchtextBox.Text;
            statusInfotextBox.Text = null;
            FIOtextBox.Text = null;
            guestpictureBox.Text = null;
            check_in_dateTextBox.Text = null;
            departure_dateTextBox.Text = null;
            guestpictureBox.Text = null;
            guestpictureBox.Image = null;

            if (enteredText != null)
            {
                foreach(var guest in guestsList)
                {
                    if(enteredText == guest[0])
                    {
                        statusInfotextBox.Text = HotelStatus(guest[5], guest[6]);
                        guestInfoId = guest[0];
                        FIOtextBox.Text = "ФИО: " + guest[1] + " " + guest[2] + " " + guest[3];
                        check_in_dateTextBox.Text = "Дата заезда: " + guest[5];
                        departure_dateTextBox.Text = "Дата выезда: " + guest[6];

                        try
                        {
                            logger.Trace("Попытка заполнение фото из БД");
                            byte[] imageBytes = null;
                            string connectionString = "Data Source=GuestsDB.db";
                            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
                            {
                                sqliteCon.Open();
                                string query = "SELECT photo FROM guests WHERE id = @guestInfoId";
                                using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                                {
                                    cmd.Parameters.AddWithValue("@guestInfoId", guestInfoId);
                                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            imageBytes = (byte[])reader["photo"];
                                        }
                                    }
                                }
                            }

                            if (imageBytes != null)
                            {
                                using (MemoryStream memoryS = new MemoryStream(imageBytes))
                                {
                                    Image image = Image.FromStream(memoryS);
                                    guestpictureBox.Image = image;
                                    logger.Trace("Успешное заполнение фото из БД");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            logger.Error(ex, "Ошибка получения изображения");
                        }
                    }
                    else if(enteredText == guest[1])
                    {
                        statusInfotextBox.Text = HotelStatus(guest[5], guest[6]);
                        guestInfoId = guest[0];
                        FIOtextBox.Text = "ФИО: " + guest[1] + " " + guest[2] + " " + guest[3];
                        check_in_dateTextBox.Text = "Дата заезда: " + guest[5];
                        departure_dateTextBox.Text = "Дата выезда: " + guest[6];

                        try
                        {
                            logger.Trace("Попытка заполнение фото из БД");
                            byte[] imageBytes = null;
                            string connectionString = "Data Source=GuestsDB.db";
                            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
                            {
                                sqliteCon.Open();
                                string query = "SELECT photo FROM guests WHERE id = @guestInfoId";
                                using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                                {
                                    cmd.Parameters.AddWithValue("@guestInfoId", guestInfoId);
                                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            imageBytes = (byte[])reader["photo"];
                                        }
                                    }
                                }
                            }

                            if (imageBytes != null)
                            {
                                using (MemoryStream memoryS = new MemoryStream(imageBytes))
                                {
                                    Image image = Image.FromStream(memoryS);
                                    guestpictureBox.Image = image;
                                    logger.Trace("Успешное заполнение фото из БД");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            logger.Error(ex, "Ошибка получения изображения");
                        }
                    }
                    else if(enteredText == guest[1] + " " + guest[2] + " " + guest[3])
                    {
                        statusInfotextBox.Text = HotelStatus(guest[5], guest[6]);
                        guestInfoId = guest[0];
                        FIOtextBox.Text = "ФИО: " + guest[1] + " " + guest[2] + " " + guest[3];
                        check_in_dateTextBox.Text = "Дата заезда: " + guest[5];
                        departure_dateTextBox.Text = "Дата выезда: " + guest[6];

                        try
                        {
                            logger.Trace("Попытка заполнение фото из БД");
                            byte[] imageBytes = null;
                            string connectionString = "Data Source=GuestsDB.db";
                            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
                            {
                                sqliteCon.Open();
                                string query = "SELECT photo FROM guests WHERE id = @guestInfoId";
                                using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                                {
                                    cmd.Parameters.AddWithValue("@guestInfoId", guestInfoId);
                                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            imageBytes = (byte[])reader["photo"];
                                        }
                                    }
                                }
                            }

                            if (imageBytes != null)
                            {
                                using (MemoryStream memoryS = new MemoryStream(imageBytes))
                                {
                                    Image image = Image.FromStream(memoryS);
                                    guestpictureBox.Image = image;
                                    logger.Trace("Успешное заполнение фото из БД");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            logger.Error(ex, "Ошибка получения изображения");
                        }
                    }
                }
            }
        }
        public string HotelStatus(string checkInDate, string checkOutDate)
        {
            logger.Debug("Определение статуса гостя");
            if (checkOutDate == "01.04.2024")
            {
                return "Выписываются";
            }
            else if (DateTime.Parse(checkInDate) > DateTime.Parse("01.04.2024"))
            {
                return "Зарезервировано";
            }
            else if (DateTime.Parse(checkOutDate) < DateTime.Parse("01.04.2024"))
            {
                return "Свободные";
            }
            else
            {
                return "Заняты";
            }
        }
    }
}
