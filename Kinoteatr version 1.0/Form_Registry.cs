using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_Registry : Form
    {
        SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
        Class_Connection_DB connect_DB = new Class_Connection_DB();
        public Form_Registry()
        {
            InitializeComponent();
        }

        private void Form_Registry_Load(object sender, EventArgs e)
        {
            comboBox_Dolj.DataSource = connect_DB.TableFill("SELECT Nazv_Dolj, Id_Dolj FROM Dolj", sqlConnection).Tables[0];
            comboBox_Dolj.DisplayMember = "Nazv_Dolj";
            comboBox_Dolj.ValueMember = "Id_Dolj";
        }

        private string GetHash(string input) //Хэширование пароля в БД
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

        private void button_Reg_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = Class_Connection_DB.DatabaseSQL();
            using (sqlConnect)
            {
                try
                {
                    string passwordCheck = GetHash(textBox_Password.Text);
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("Autoriz_Insert", sqlConnect)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCommand.Parameters.AddWithValue("@Login_", textBox_Login.Text);
                    sqlCommand.Parameters.AddWithValue("@Pasword_", passwordCheck);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Регистрация прошла успешно.", "Уведомление");
                    Form_Autorization form = new Form_Autorization();
                    form.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Какие либо данные введены не корректно." + ex, "Ошибка");
                }
            }
        }

        private void button_End_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
