using System;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_Connect_DB : Form
    {
        public Form_Connect_DB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Задаем параеметы названия базы данных
            Class_Connection_DB.InitialCatalog = textBox_Name_BD.Text;

            //Задаем параеметы логина
            Class_Connection_DB.UserID = textBox_Login.Text;

            //Задаем параеметы пароля для входа
            Class_Connection_DB.Password = textBox_Passord.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form_Connect_DB_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Рекомендуется не пользоваться данной формой. Использовать данную форму рекомендуется только в том случе есть в знаете что делаете!!!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
