using System;
using System.Windows.Forms;

namespace Страховые_Иски
{
    public partial class Klient : Form
    {
        Insurance ins = new Insurance(); //вызов класса страхования
        Claims cl = new Claims(); //вызов класса исков
        DateTime date1 = DateTime.Today; //получение сегодняшней даты

        public Klient()
        {
            InitializeComponent();
            ins.Add_ComboBox(Vid_Ins); //заполнение вида страховок в панели стахования
            ins.Add_ComboBox(Vid_Claims); //заполнение вида страховок в панели исков
            ins.DisplayData(Table_Insurance); //вывод заявок на страхование
            cl.DisplayData(Table_Claims); //вывод исков
        }

        public void CleanData() //очищение полей
        {
            Vid_Ins.SelectedIndex = -1;
            Company_Ins.SelectedIndex = -1;
            Vid_Claims.SelectedIndex = -1;
            Company_Claims.SelectedIndex = -1;
            Sum_Ins.Text = "";
            ID_Ins.Text = "";
            Sum_Claims.Text = "";
            ID_Claims.Text = "";
        }

        private void Find_Company_Click(object sender, EventArgs e) //поиск компаний, которые могут сделать страховку нужного вида
        {
            if (Vid_Ins.SelectedIndex == -1)
                MessageBox.Show("Выберите вид страхования!");
            else
            {
                ins.Find_Company(Company_Ins, Vid_Ins.Text);
            }
        }

        private void Apply_Insurance_Click(object sender, EventArgs e) //кнопка подачи заявки на панели страхования
        {
            if (Vid_Ins.SelectedIndex != -1 && Company_Ins.SelectedIndex != -1 && Sum_Ins.Text != "")
            {
                ins.Add_Strah(Company_Ins.Text, Vid_Ins.Text, int.Parse(Sum_Ins.Text), Convert.ToString(date1.ToShortDateString()), Table_Insurance);
                CleanData();
            }
            else
                MessageBox.Show("Заполните данные!");
        }

        private void Change_Apply_Insurance_Click(object sender, EventArgs e) //кнопка изменения заявок на панели страхования
        {
            if (ID_Ins.Text == "")
                MessageBox.Show("Введите ID заявки!");
            else if (Vid_Ins.SelectedIndex != -1 && Company_Ins.SelectedIndex != -1 && Sum_Ins.Text != "")
            {
                ins.Change_Strah(Company_Ins.Text, Vid_Ins.Text, Sum_Ins.Text, Convert.ToString(date1.ToShortDateString()), Convert.ToInt32(ID_Ins.Text), Table_Insurance);
                CleanData();
            }
        }

        private void Delete_Apply_Insurance_Click(object sender, EventArgs e) //кнопка удаления заявок на панели страхования
        {
            if (ID_Ins.Text == "")
                MessageBox.Show("Введите ID заявки!");
            else
            {
                ins.Delete_Strah(int.Parse(ID_Ins.Text), Table_Insurance);
                CleanData();
            }
        }

        private void Back_Insurance_Click(object sender, EventArgs e) //кнопка назад на панели страхования
        {
            Menu f = new Menu();
            f.Show();
            this.Hide();
        }

        private void Find_Ins_Claims_Click(object sender, EventArgs e) //кнопка поиска компаний, в которых одобрена страховка нужного вида
        {
            if (Vid_Claims.SelectedIndex == -1)
                MessageBox.Show("Выберите вид страхования!");
            else if (Vid_Claims.Items.Count == 0)
                MessageBox.Show("Подходящих страховок не обнаружено!");
            else
                cl.Find_Strah(Company_Claims, Vid_Claims.Text);
        }

        private void Apply_Claims_Click(object sender, EventArgs e) //подача исков
        {
            if (Vid_Claims.SelectedIndex != -1 && Company_Claims.SelectedIndex != -1 && Sum_Claims.Text != "")
            {
                cl.Add_Isk(Company_Claims.Text, Vid_Claims.Text, int.Parse(Sum_Claims.Text), Convert.ToString(date1.ToShortDateString()), Table_Claims);
                CleanData();
            }
            else
                MessageBox.Show("Заполните данные!");
        }

        private void Change_Apply_Claims_Click(object sender, EventArgs e) //изменение исков
        {
            if (ID_Claims.Text == "")
                MessageBox.Show("Введите ID заявки!");
            else if (Vid_Claims.SelectedIndex != -1 && Company_Claims.SelectedIndex != -1 && Sum_Claims.Text != "")
            {
                cl.Change_Isk(Company_Claims.Text, Vid_Claims.Text, Sum_Claims.Text, Convert.ToString(date1.ToShortDateString()), Convert.ToInt32(ID_Claims.Text), Table_Claims);
                CleanData();
            }
        }

        private void Delete_Apply_Claims_Click(object sender, EventArgs e) //удаление исков
        {
            if (ID_Claims.Text == "")
                MessageBox.Show("Введите ID заявки!");
            else
            {
                cl.Delete_Isk(int.Parse(ID_Claims.Text), Table_Insurance);
                CleanData();
            }
        }

        private void Back_Claims_Click(object sender, EventArgs e) //кнопка назад
        {
            Menu f = new Menu();
            f.Show();
            this.Hide();
        }
    }
}
