using NLog;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    public class DatabaseService
    {
        private string connectionString = "Data Source=GuestsDB.db";

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public List<string[]> GetGuests()
        {
            List<string[]> guestsList = new List<string[]>();

            logger.Trace("Попытка открыть подключение к БД");
            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
            {
                try
                {
                    sqliteCon.Open();
                    string query = "SELECT id, last_name, first_name, otchestvo, date_of_birth, check_in_date, departure_date, with_animals, payment FROM guests";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                guestsList.Add(new string[] { reader["id"].ToString(), reader["last_name"].ToString(), reader["first_name"].ToString(), reader["otchestvo"].ToString(), reader["date_of_birth"].ToString(), reader["check_in_date"].ToString(), reader["departure_date"].ToString(), reader["with_animals"].ToString(), reader["payment"].ToString() });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "Ошибка получения гостей из таблицы guests");
                }
            }
            logger.Trace("Успешное подключение к БД");
            logger.Trace("Сколько записей извлечено: " + guestsList.Count);
            return guestsList;
        }
        
        public List<string[]> GetReservedGuests()
        {
            List<string[]> reserve_guestsList = new List<string[]>();
            logger.Trace("Попытка открыть подключение к БД");
            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
            {
                try
                {
                    sqliteCon.Open();
                    string query = "SELECT * FROM reserved";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                reserve_guestsList.Add(new string[] { reader["id"].ToString(), reader["guest_id"].ToString() });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "Ошибка получения зарезервированных гостей");
                }
            }
            logger.Trace("Успешное подключение к БД");
            logger.Trace("Сколько записей извлечено: " + reserve_guestsList.Count);
            return reserve_guestsList;
        }
        public List<string[]> GetFreeGuests()
        {
            List<string[]> free_guestsList = new List<string[]>();
            logger.Trace("Попытка открыть подключение к БД");
            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
            {
                try
                {
                    sqliteCon.Open();
                    string query = "SELECT * FROM free";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                free_guestsList.Add(new string[] { reader["id"].ToString(), reader["guest_id"].ToString() });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "Ошибка получения свободных гостей");
                }
            }
            logger.Trace("Успешное подключение к БД");
            logger.Trace("Сколько записей извлечено: " + free_guestsList.Count);
            return free_guestsList;
        }
        public List<string[]> GetOccupiedGuests()
        {
            List<string[]> occupied_guestsList = new List<string[]>();
            logger.Trace("Попытка открыть подключение к БД");
            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
            {
                try
                {
                    sqliteCon.Open();
                    string query = "SELECT * FROM occupied";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                occupied_guestsList.Add(new string[] { reader["id"].ToString(), reader["guest_id"].ToString() });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "Ошибка получения занятых гостей");
                }
            }
            logger.Trace("Успешное подключение к БД");
            logger.Trace("Сколько записей извлечено: " + occupied_guestsList.Count);
            return occupied_guestsList;
        }
        public List<string[]> GetChecksOutGuests()
        {
            List<string[]> checksout_guestsList = new List<string[]>();
            logger.Trace("Попытка открыть подключение к БД");
            using (SQLiteConnection sqliteCon = new SQLiteConnection(connectionString))
            {
                try
                {
                    sqliteCon.Open();
                    string query = "SELECT * FROM checks_out";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteCon))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                checksout_guestsList.Add(new string[] { reader["id"].ToString(), reader["guest_id"].ToString() });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "Ошибка получения выселяющихся гостей");
                }
            }
            logger.Trace("Успешное подключение к БД");
            logger.Trace("Сколько записей извлечено: " + checksout_guestsList.Count);
            return checksout_guestsList;
        }
        
    }
}
