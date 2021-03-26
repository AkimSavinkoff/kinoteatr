using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_Dolj_Upd : Form
    {
        SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
        Class_Connection_DB connect_DB = new Class_Connection_DB();
        public Form_Dolj_Upd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form_Dolj_Upd_Load(object sender, EventArgs e)
        {
            comboBox_Sot.DataSource = connect_DB.TableFill("SELECT F_S, Id_Sotrud FROM Sotrud", sqlConnection).Tables[0];
            comboBox_Sot.DisplayMember = "F_S";
            comboBox_Sot.ValueMember = "Id_Sotrud";

            comboBox_Dolj.DataSource = connect_DB.TableFill("SELECT Nazv_Dolj, Id_Dolj FROM Dolj", sqlConnection).Tables[0];
            comboBox_Dolj.DisplayMember = "Nazv_Dolj";
            comboBox_Dolj.ValueMember = "Id_Dolj";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = Class_Connection_DB.DatabaseSQL();
            using (sqlConnect)
            {
                try
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("Sotrud_Update_Dolj", sqlConnect)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCommand.Parameters.AddWithValue("@Id", comboBox_Sot.SelectedValue);
                    sqlCommand.Parameters.AddWithValue("@Dolj_S", comboBox_Dolj.SelectedValue);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Должность сотрудника обновлена", "Уведомление");
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
