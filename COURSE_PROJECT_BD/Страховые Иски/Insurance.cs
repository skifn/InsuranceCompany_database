using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Страховые_Иски
{
    class Insurance //класс для действий с заявками на страхование
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString); //соединение с бд
        public SqlDataAdapter adapter; //создание адаптера для считывания данных
        public SqlCommand cmd; //создание переменной для выполнения команд по изменению данных

        public void Add_ComboBox(ComboBox box) //Заполнение видов страхования в comboBox (клиент)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from Вид_страхования", connection);
            adapter.Fill(dt);
            box.DataSource = dt;
            box.DisplayMember = "Вид";// столбец для отображения
            box.ValueMember = "ID";//столбец с id
            box.SelectedIndex = -1;
            connection.Close();
        }

        public void Find_Company(ComboBox box, string vid) //Поиск компаний, в которых имеется нужный вид страхования
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from Работа_Компании where Вид_страхования='" + vid + "'", connection);
            adapter.Fill(dt);
            box.DataSource = dt;
            box.DisplayMember = "Наименование";// столбец для отображения
            box.ValueMember = "ID";//столбец с id
            box.SelectedIndex = -1;
            connection.Close();
        }

        public void DisplayData(DataGridView dataGrid) //Вывод всех заявок на страхование (клиент)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select ID, Название_компании as Компания, " +
                "Вид_страх as 'Вид страховки', Сумма_страх as Сумма, Дата_страх as 'Дата подачи', " +
                "Статус from Страхование where Фамилия_клиента in (select Фамилия from Клиент where Статус='on')", connection);
            adapter.Fill(dt);
            dataGrid.DataSource = dt;
            connection.Close();
        }

        public void Add_Strah(string comp, string vid, int sum, string data, DataGridView dataGrid) //Добавление заявки на страхование (клиент)
        {
            cmd = new SqlCommand("insert into Страхование (Фамилия_клиента, Номер_полиса, Название_компании, Вид_страх, Сумма_страх, Дата_страх, Статус)" +
                "values ((select Фамилия from Клиент where Статус='on'), (select Номер_полиса from Клиент where Статус='on')," +
                "@comp, @vid, @sum, @data, 'Рассматривается')", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@comp", comp);
            cmd.Parameters.AddWithValue("@vid", vid);
            cmd.Parameters.AddWithValue("@sum", sum);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.ExecuteNonQuery();
            connection.Close();
            DisplayData(dataGrid);
        }

        public void Change_Strah(string comp, string vid, string sum, string data, int id, DataGridView dataGrid) //изменение заявки на страхование (клиент)
        {
            cmd = new SqlCommand("update Страхование set Название_компании=@comp, Вид_страх=@vid, " +
                "Сумма_страх=@sum, Дата_страх=@data, Статус='Рассматривается' where ID=@id", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@comp", comp);
            cmd.Parameters.AddWithValue("@vid", vid);
            cmd.Parameters.AddWithValue("@sum", sum);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
            DisplayData(dataGrid);
        }

        public void Delete_Strah(int id, DataGridView dataGrid) //удаление заявки на страхование (клиент)
        {
            cmd = new SqlCommand("delete Страхование where ID = @id", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
            DisplayData(dataGrid);
        }

        public void DisplayData_Com(DataGridView dataGrid) //вывод заявок на страхование (компания)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select ID, Фамилия_клиента as Фамилия, Номер_полиса as Полис, " +
                "Вид_страх as 'Вид страховки', Сумма_страх as Сумма, Дата_страх as Дата, Статус " +
                "from Страхование where Название_компании in (select Наименование from Компания where Статус='on')", connection);
            adapter.Fill(dt);
            dataGrid.DataSource = dt;
            connection.Close();
        }

        public void Status(int id, string stat, DataGridView dataGrid) //изменение статуса заявки на страхование (компания)
        {
            cmd = new SqlCommand("update Страхование set Статус=@stat where ID=@id", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@stat", stat);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
            DisplayData_Com(dataGrid);
        }

    }
}
