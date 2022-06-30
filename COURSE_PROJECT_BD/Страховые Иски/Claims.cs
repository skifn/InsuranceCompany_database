using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Страховые_Иски
{
    class Claims //класс для действий с исками
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString); //соединение с бд
        public SqlDataAdapter adapter; //создание адаптера для считывания данных
        public SqlCommand cmd; //создание переменной для выполнения команд по изменению данных

        public void Find_Strah(ComboBox box, string vid) //поиск компаний, в которых имеется страховка нужного вида и добавление их в combobox (клиент)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from Страхование where Статус='Одобрено' AND " +
                "Фамилия_клиента in (select Фамилия from Клиент where Статус='on') AND Вид_страх='" + vid + "'", connection);
            adapter.Fill(dt);
            box.DataSource = dt;
            box.DisplayMember = "Название_компании";// столбец для отображения
            box.ValueMember = "ID";//столбец с id
            box.SelectedIndex = -1;
            connection.Close();
        }

        public void DisplayData(DataGridView dataGrid) //вывод всех исков в таблицу (клиент)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select ID, Название_компании as Компания, Вид_страх as " +
                "'Вид страховки', Сумма_страх as 'Сумма страховки', Дата_страх as 'Дата подачи', " +
                "Сумма_иска as 'Сумма иска', Дата_иска as 'Дата подачи', Статус from Иски where Фамилия_клиента in (select Фамилия from Клиент where Статус='on')", connection);
            adapter.Fill(dt);
            dataGrid.DataSource = dt;
            connection.Close();
        }

        public void Add_Isk(string comp, string vid, int sum, string data, DataGridView dataGrid) //добавление иска (клиент)
        {
            cmd = new SqlCommand("insert into Иски (Фамилия_клиента, Номер_полиса, Название_компании, Вид_страх, Сумма_страх, Дата_страх, Сумма_иска, Дата_иска, Статус)" +
                "values ((select Фамилия from Клиент where Статус='on')," +
                "(select Номер_полиса from Клиент where Статус='on'), @comp, @vid, " +
                "(select Сумма_страх from Страхование where Название_компании=@comp AND Вид_страх=@vid AND Статус='Одобрено')," +
                "(select Дата_страх from Страхование where Название_компании=@comp AND Вид_страх=@vid AND Статус='Одобрено'), @sum, @data, 'Рассматривается')", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@comp", comp);
            cmd.Parameters.AddWithValue("@vid", vid);
            cmd.Parameters.AddWithValue("@sum", sum);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.ExecuteNonQuery();
            connection.Close();
            DisplayData(dataGrid);
        }

        public void Change_Isk(string comp, string vid, string sum, string data, int id, DataGridView dataGrid) //Изменение иска (клиент)
        {
            cmd = new SqlCommand("update Иски set Название_компании=@comp, Вид_страх=@vid, " +
                "Сумма_иска=@sum, Дата_иска=@data, Статус='Рассматривается' where ID=@id", connection);
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

        public void Delete_Isk(int id, DataGridView dataGrid) //Удаление иска (клиент)
        {
            cmd = new SqlCommand("delete Иски where ID = @id", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
            DisplayData(dataGrid);
        }

        public void DisplayData_Com(DataGridView dataGrid) //Вывод всех исков клиентов для компании
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select ID, Фамилия_клиента as Фамилия, Номер_полиса as Полис, Вид_страх as 'Вид страховки', Сумма_страх as Сумма, Дата_страх as Дата, Сумма_иска as 'Сумма иска', Дата_иска as 'Дата подачи', Статус from Иски where Название_компании in (select Наименование from Компания where Статус='on')", connection);
            adapter.Fill(dt);
            dataGrid.DataSource = dt;
            connection.Close();
        }

        public void Status(int id, string stat, DataGridView dataGrid) //Изменение статуса заявки (компания)
        {
            cmd = new SqlCommand("update Иски set Статус=@stat where ID=@id", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@stat", stat);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
            DisplayData_Com(dataGrid);
        }
    }
}
