using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Страховые_Иски
{
    class Registration //класс для регистрации пользователей
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString); //соединение с бд
        public SqlCommand cmd; //создание переменной для выполнения команд по изменению данных

        public void Regist_Klient(string mail, string pass, string fam, string name, string ot, string num) //регистрация клиента
        {
            cmd = new SqlCommand("insert into Клиент (Эл_почта, Пароль, Фамилия, Имя, Отчество, Номер_полиса)" +
                                 "values (@mail, @pass, @fam, @name, @ot, @num)", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@fam", fam);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@ot", ot);
            cmd.Parameters.AddWithValue("@num", num);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Regist_Company(string mail, string pass, string name, string rek, string adress, string num) //регистрация компании
        {
            cmd = new SqlCommand("insert into Компания (Эл_почта, Пароль, Наименование, Реквизиты, Адрес, Номер_телефона)" +
                                 "values (@mail, @pass, @name, @rek, @adress, @num)", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@rek", rek);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@adress", adress);
            cmd.Parameters.AddWithValue("@num", num);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Work_Company(CheckedListBox box, string name) //добавление видов страховок для компании
        {
            foreach(object item in box.CheckedItems)
            {
                connection.Open();
                cmd = new SqlCommand("insert into Работа_Компании (Наименование, Вид_страхования)" +
                                 "values (@name, @pass)", connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@pass", item.ToString());
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
