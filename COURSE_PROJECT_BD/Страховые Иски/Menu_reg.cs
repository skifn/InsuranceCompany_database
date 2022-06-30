using System;
using System.Windows.Forms;

namespace Страховые_Иски
{
    public partial class Menu_reg : Form
    {
        public Menu_reg()
        {
            InitializeComponent();
        }

        Registration reg = new Registration();//вызов класса регистрации

        private void Registration_Klient_Click(object sender, EventArgs e) //регистрация клиента
        {
            if(password_k.Text != pass_k.Text)
                MessageBox.Show("Пароли не совпадают!");
            else if(Pers_Data_Klient.Checked == false)
                MessageBox.Show("Необходимо согласие на обработку данных!");
            else if(mail_k.Text != "" && password_k.Text != "" &&  pass_k.Text != "" && fam_k.Text != "" && name_k.Text != "" && ot_k.Text != "" && num_k.Text != "")
            {
                reg.Regist_Klient(mail_k.Text, password_k.Text, fam_k.Text, name_k.Text, ot_k.Text, num_k.Text);
                Menu f = new Menu();
                f.Show();
                this.Hide();
            }
        }

        private void Registration_company_Click(object sender, EventArgs e) //регистрация компании
        {
            if (password_c.Text != pass_c.Text)
                MessageBox.Show("Пароли не совпадают!");
            else if (Pers_Data_Company.Checked == false)
                MessageBox.Show("Необходимо согласие на обработку данных!");
            else if(Insurance_Company.CheckedItems.Count == 0)
                MessageBox.Show("Необходимо выбрать форму страхования!");
            else if (mail_c.Text != "" && password_c.Text != "" && pass_c.Text != "" && name_c.Text != "" && adress_c.Text != "" && rek_c.Text != "" && num_c.Text != "" && Insurance_Company.CheckedItems.Count != 0)
            {
                reg.Regist_Company(mail_c.Text, password_c.Text, name_c.Text, rek_c.Text, adress_c.Text, num_c.Text);
                reg.Work_Company(Insurance_Company, name_c.Text);
                Menu f = new Menu();
                f.Show();
                this.Hide();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Insurance_Company_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void name_k_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
