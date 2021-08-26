using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Licenta
{
    class Constante
    {
       public static MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=licenta");

        public static bool EmailValidate(string email)
        {
            try
            {
                var mail =new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void Log(string actiune,string data, int id_utilizator)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("Insert into log(actiune,data,id_utilizator) values(@actiune,@data,@id_utilizator)",mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@actiune",actiune);
                mySqlCommand.Parameters.AddWithValue("@data", data);
                mySqlCommand.Parameters.AddWithValue("@id_utilizator", id_utilizator);
                mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                mySqlConnection.Close();
                mySqlCommand.Parameters.Clear();
            }
            catch(MySqlException Ex)
            {
                throw Ex;
            }
        }
    }
}
