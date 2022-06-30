using System;
using System.Windows.Forms;

namespace Страховые_Иски
{
    public partial class Company : Form
    {
        Insurance ins = new Insurance(); //вызов класса страхования
        Claims cl = new Claims(); //вызов класса исков

        public Company()
        {
            InitializeComponent();
            ins.DisplayData_Com(Table_Insurance); //заполнение таблицы заявками на страхование
            cl.DisplayData_Com(Table_Claims); //заполнение таблицы исками
        }

        public void CleanData() //очистка полей
        {
            Status_Ins.SelectedIndex = -1;
            Status_Claims.SelectedIndex = -1;
            ID_Ins.Text = "";
            ID_Claims.Text = "";
        }

        private void Set_Status_Insurance_Click(object sender, EventArgs e) //кнопка "установить статус" на панели страхования
        {
            if (ID_Ins.Text == "")
                MessageBox.Show("Введите ID!");
            else if (Status_Ins.SelectedIndex == -1)
                MessageBox.Show("Выберите статус!");
            else
            {
                ins.Status(int.Parse(ID_Ins.Text), Status_Ins.Text, Table_Insurance);
                CleanData();
            }
        }

        private void Back_Insurance_Click(object sender, EventArgs e) //кнопка "назад" на панели страхования
        {
            Menu f = new Menu();
            f.Show();
            this.Hide();
        }

        private void Set_Status_Claim_Click(object sender, EventArgs e) //кнопка "установить статус" на панели исков
        {
            if (ID_Claims.Text == "")
                MessageBox.Show("Введите ID!");
            else if (Status_Claims.SelectedIndex == -1)
                MessageBox.Show("Выберите статус!");
            else
            {
                cl.Status(int.Parse(ID_Claims.Text), Status_Claims.Text, Table_Claims);
                CleanData();
            }
        }

        private void Back_Claims_Click(object sender, EventArgs e) //кнопка "назад" на панели исков
        {
            Menu f = new Menu();
            f.Show();
            this.Hide();
        }

        private void Table_Insurance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
