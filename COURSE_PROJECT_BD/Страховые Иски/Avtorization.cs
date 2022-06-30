using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Страховые_Иски
{
    class Avtorization //класс для авторизации пользователей
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString); //соединение с бд
        public SqlDataAdapter adapter; //создание адаптера для считывания данных
        public SqlCommand cmd; //создание переменной для выполнения команд по изменению данных

        public bool Avto_Klient(string mail, string pass) //авторизация клиента, mail - логин, pass - пароль
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from Клиент where Эл_почта='" + mail + 
                "' AND Пароль='" + pass + "'", connection);
            adapter.Fill(dt);
            bool check = false;
            if(adapter.Fill(dt) != 0) //если найдено совпадение логина и пароля, то check = true 
                check = true;
            connection.Close();
            return check;
        }

        public void Status_klient(string mail, string pass) //изменение статуса клиента на "онлайн" при входе в аккаунт
        {
            cmd = new SqlCommand("update Клиент set Статус='on' where Эл_почта=@mail AND Пароль=@pass", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public bool Avto_Company(string mail, string pass) //авторизация компаний
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from Компания where Эл_почта='" + mail + 
                "' AND Пароль='" + pass + "'", connection);
            adapter.Fill(dt);
            bool test = false;
            if (adapter.Fill(dt) != 0) //аналогично клиенту
                test = true;
            connection.Close();
            return test;
        }

        public void Status_company(string mail, string pass) //статус "онлайн" для компаний
        {
            cmd = new SqlCommand("update Компания set Статус='on' where Эл_почта=@mail AND Пароль=@pass", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Company_off() //статус "оффлайн" для компаний
        {
            cmd = new SqlCommand("update Компания set Статус='off' where Статус ='on'", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Klient_off() //статус "оффлайн" для клиентов
        {
            cmd = new SqlCommand("update Клиент set Статус='off' where Статус ='on'", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
