using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_Autorization : Form
    {
        public Form_Autorization()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string loginCheck = textBox_Login.Text;
            string password = textBox_Passord.Text;
            string passwordCheck = Hash(textBox_Passord.Text);//Шифрование пароля
            string checkCmd = $"Select Login_, Pasword_ from Autoriz where Login_ ='{loginCheck}' and Pasword_ ='{passwordCheck}'";
            SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
            SqlCommand sqlCommand = new SqlCommand(checkCmd, sqlConnection);
            using (sqlConnection)
            {
                try
                {
                    sqlConnection.Open();

                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();
                    if (loginCheck == (string)sqlCommand.ExecuteScalar())
                    {
                        this.Hide();
                        Form_Menu menu_Form = new Form_Menu();
                        menu_Form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Логин или пароль ведены не верно", "Ошибка");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private string Hash(string input) //Хэширование пароля в БД
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Registry form_Registry = new Form_Registry();
            form_Registry.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Connect_DB form_Connect_DB = new Form_Connect_DB();
            form_Connect_DB.Show();
        }
    }
}
