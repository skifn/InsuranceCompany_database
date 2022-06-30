using System;
using System.Windows.Forms;

namespace Страховые_Иски
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Avtorization avt = new Avtorization(); //вызов класса авторизации

        private void Menu_Load(object sender, EventArgs e) //при запуске ставит статус "оффлайн" всем пользователям
        {
            avt.Klient_off();
            avt.Company_off();
        }

        private void come_on_Click(object sender, EventArgs e) //кнопка входа
        {
            bool check_klient = avt.Avto_Klient(mail.Text, pass.Text); //проверка аккаунтов
            bool check_company = avt.Avto_Company(mail.Text, pass.Text);

            if (check_klient == false && check_company == false)
                MessageBox.Show("Неверный логин или пароль!");
            if (check_klient == true)
            {
                avt.Status_klient(mail.Text, pass.Text);
                Klient f = new Klient();
                f.Show();
                this.Hide();
            }
            if (check_company == true)
            {
                avt.Status_company(mail.Text, pass.Text);
                Company f = new Company();
                f.Show();
                this.Hide();
            }
        }

        private void registration_Click(object sender, EventArgs e) //кнопка регистрации
        {
            Menu_reg f = new Menu_reg();
            f.Show();
            this.Hide();
        }

        private void mail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
