using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_Add_Sotrudcs : Form
    {
        SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
        Class_Connection_DB connect_DB = new Class_Connection_DB();
        public Form_Add_Sotrudcs()
        {
            InitializeComponent();
        }

        private void Form_Add_Sotrudcs_Load(object sender, System.EventArgs e)
        {
            comboBox_Dolj.DataSource = connect_DB.TableFill("SELECT Nazv_Dolj, Id_Dolj FROM Dolj", sqlConnection).Tables[0];
            comboBox_Dolj.DisplayMember = "Nazv_Dolj";
            comboBox_Dolj.ValueMember = "Id_Dolj";

            comboBox_Akk.DataSource = connect_DB.TableFill("SELECT Login_, Id_Auto FROM Autoriz", sqlConnection).Tables[0];
            comboBox_Akk.DisplayMember = "Login_";
            comboBox_Akk.ValueMember = "Id_Auto";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            SqlConnection sqlConnect = Class_Connection_DB.DatabaseSQL();
            using (sqlConnect)
            {
                try
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("Sotrud_Insert", sqlConnect)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCommand.Parameters.AddWithValue("@F_K", textBox_F.Text);
                    sqlCommand.Parameters.AddWithValue("@I_K", textBox_I.Text);
                    sqlCommand.Parameters.AddWithValue("@O_K", textBox_O.Text);
                    sqlCommand.Parameters.AddWithValue("@Phone_Number", maskedTextBox_Phone.Text);
                    sqlCommand.Parameters.AddWithValue("@Date_Of_Bithd", maskedTextBox_Date.Text);
                    sqlCommand.Parameters.AddWithValue("@Dolj_S", comboBox_Dolj.SelectedValue);
                    sqlCommand.Parameters.AddWithValue("@Autorir_S", comboBox_Akk.SelectedValue);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Сотрудник принят на работу", "Уведомление");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Какие либо данные введены не корректно." + ex, "Ошибка");
                }
            }
        }
    }
}
